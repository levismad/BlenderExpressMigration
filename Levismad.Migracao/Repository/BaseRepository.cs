using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
//using System.IO;
using System.Linq;
using System.Reflection;
//using System.Text;
using System.Threading;
using Levismad.Model;
using log4net;
using Oracle.ManagedDataAccess.Client;
using static System.Threading.ThreadPool;

namespace Levismad.Repository
{
    public abstract class BaseRepository<T> where T : IModel
    {
        // ReSharper disable once StaticMemberInGenericType
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // ReSharper disable once StaticMemberInGenericType
        private static Semaphore _mSemaphore;

        private string ConexaoOrigem { get; }
        // ReSharper disable once StaticMemberInGenericType
        private static string ConexaoDestino { get; set; }
        private long QuantidadeRegistrosPorTransacao { get;  }
        private string ComandoSqlOrigem { get; }
        // ReSharper disable once StaticMemberInGenericType
        private static string ComandoSqlDestino { get; set; }
        private int QuantidadeCampos { get; }
        private static Func<List<object>, int, T> GetModel { get; set; }
        private static Func<List<T>, List<OracleParameter>> GetParameter { get; set; }
        // ReSharper disable once StaticMemberInGenericType
        private static Dictionary<string, KeyValuePair<string, bool>> PreRequisits { get; set; }

        protected BaseRepository(string sqlOrigem, string sqlDestino, int campos, Func<List<object>, int, T> method1, Func<List<T>, List<OracleParameter>> method2, Dictionary<string, KeyValuePair<string, bool>> preRequisitList = null)
        {
            ConexaoOrigem = ConfigurationManager.ConnectionStrings["ConexaoOrigem"].ConnectionString;
            ConexaoDestino = ConfigurationManager.ConnectionStrings["ConexaoDestino"].ConnectionString;
            QuantidadeRegistrosPorTransacao = long.Parse(ConfigurationManager.AppSettings["Levismad.QuantidadeRegistrosPorTransacao"]);

            ComandoSqlOrigem = ConfigurationManager.AppSettings[sqlOrigem];
            ComandoSqlDestino = ConfigurationManager.AppSettings[sqlDestino];
            GetModel = method1;
            GetParameter = method2;
            QuantidadeCampos = campos;
            PreRequisits = preRequisitList;
        }

        private void EfetuarPreRequisits(KeyValuePair<string, KeyValuePair<string, bool>> req)
        {
            Log.Info(req.Key);

            var con = new OracleConnection { ConnectionString = ConexaoOrigem };
            con.Open();
            var cmd = new OracleCommand(req.Value.Key)
            {
                Connection = con,
                CommandType = CommandType.Text
            };
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (req.Value.Value)
                {
                    throw new AprimoramentosException($"Não foi possivel aplicar : {req.Key}.Detalhes: {ex.Message}");
                }
            }

        }

        protected void EfetuarCargaDefault(string nomeCarga, Func<int, int> final = null, int index = 1)
        {
            Log.Info("------------------");
            Log.Info($"Migração {nomeCarga}");
            if (PreRequisits != null && PreRequisits.Any())
            {
                foreach (var req in PreRequisits)
                {
                    EfetuarPreRequisits(req);
                }
            }
            var i = index;
            try
            {
                var dt1 = DateTime.Now;

                var con = new OracleConnection { ConnectionString = ConexaoOrigem };
                con.Open();
                var cmdQuery = ComandoSqlOrigem;
                var cmd = new OracleCommand(cmdQuery)
                {
                    InitialLONGFetchSize = 300,
                    Connection = con,
                    CommandType = CommandType.Text
                };
                var lista = new List<T>();

                Log.Info("Inicio Execução do banco de dados");
                var reader = cmd.ExecuteReader();
                Log.Info("Fim Execução do banco de dados");
                while (reader.Read())
                {

                    try
                    {
                        var readerLine = new List<object>();
                        #region Campos

                        int camposIdx;
                        for (camposIdx = 0; camposIdx < QuantidadeCampos; camposIdx++)
                        {
                            readerLine.Add(reader.GetValue(camposIdx));
                        }
                        var model = GetModel(readerLine, i);

                        var valid = model.Validar();

                        if (valid.IsValid)
                        {
                            lista.Add(model);
                        }
                        else
                        {
                            valid.Erros.ForEach(x =>
                            {
                                Log.Error(
                                    $"Campo {x.Campo} possui {x.TamanhoReal} caracteres e deveria ter no maximo {x.TamanhoMaximo} ({x.Valor})");
                            });
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {

                        Log.Error("Erro na leitura do registro : " + i + " - detalhes :  " + ex.Message);
                    }

                    if ((i % QuantidadeRegistrosPorTransacao) == 0)
                    {

                        try
                        {
                            Log.Info("Gravando : " + i.ToString("N0"));

                            var ls = lista;
                            lista = new List<T>();
                            GravarBulk(ls);
                            //log.Info("Gravado com sucesso!");

                        }
                        catch (Exception ex)
                        {

                            Log.Error("Erro na Gravacao dos registros : " + (i - QuantidadeRegistrosPorTransacao) + " até " + i + " - detalhes :  " + ex.Message);
                        }
                    }
                    i++;

                }


                GravarBulk(lista);
                Log.Info("Gravando : " + (i - 1).ToString("N0"));

                reader.Close();
                reader.Dispose();
                con.Close();
                con.Dispose();

                var dt2 = DateTime.Now;

                var elapsed = (dt2 - dt1).TotalSeconds;
                Log.Info("Tempo Total  em Segundos  - " + elapsed);

                Log.Info("------------------");
            }

            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            finally
            {
                final?.Invoke(i);
            }

        }

        protected void EfetuarCargaDefault(string nomeCarga, List<string> queries, Func<int, int> final, int index = 1)
        {
            if (queries == null) throw new ArgumentNullException(nameof(queries));

            Log.Info("------------------");
            Log.Info($"Migração {nomeCarga}");
            var i = index;
            try
            {
                var dt1 = DateTime.Now;

                var con = new OracleConnection { ConnectionString = ConexaoOrigem };
                con.Open();

                int camposIdx;
                List<object> readerLine;
                var lista = new List<T>();

                queries.ForEach(cmdQuery =>
                {
                    var cmd = new OracleCommand(cmdQuery)
                    {
                        InitialLONGFetchSize = 300,
                        Connection = con,
                        CommandType = CommandType.Text
                    };

                    Log.Info("Inicio Execução do banco de dados");
                    var reader = cmd.ExecuteReader();
                    Log.Info("Fim Execução do banco de dados");
                    while (reader.Read())
                    {

                        try
                        {
                            readerLine = new List<object>();
                            #region Campos
                            for (camposIdx = 0; camposIdx < QuantidadeCampos; camposIdx++)
                            {
                                readerLine.Add(reader.GetValue(camposIdx));
                            }
                            var model = GetModel(readerLine, i);

                            var valid = model.Validar();

                            if (valid.IsValid)
                            {
                                lista.Add(model);
                            }
                            else
                            {
                                valid.Erros.ForEach(x =>
                                {
                                    Log.Error($"Campo {x.Campo} possui {x.TamanhoReal} caracteres e deveria ter no maximo {x.TamanhoMaximo} ({x.Valor})");
                                });
                            }
                            #endregion

                        }
                        catch (Exception ex)
                        {

                            Log.Error("Erro na leitura do registro : " + i + " - detalhes :  " + ex.Message);
                        }

                        if ((i % QuantidadeRegistrosPorTransacao) == 0)
                        {

                            try
                            {
                                Log.Info("Gravando : " + i.ToString("N0"));

                                var ls = lista;
                                lista = new List<T>();
                                GravarBulk(ls);
                                //log.Info("Gravado com sucesso!");

                            }
                            catch (Exception ex)
                            {

                                Log.Error("Erro na Gravacao dos registros : " + (i - QuantidadeRegistrosPorTransacao) + " até " + i + " - detalhes :  " + ex.Message);
                            }
                        }
                        i++;

                    }

                    reader.Close();
                    reader.Dispose();
                });


                GravarBulk(lista);
                Log.Info("Gravando : " + (i - 1).ToString("N0"));

                con.Close();
                con.Dispose();

                var dt2 = DateTime.Now;

                var elapsed = (dt2 - dt1).TotalSeconds;
                Log.Info("Tempo Total  em Segundos  - " + elapsed);

                Log.Info("------------------");
            }

            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            finally
            {

                final(i);
            }

        }

        private void GravarBulk(List<T> collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));


            const int batchSize = 2000;
            const int numberOfThreadsToUse = 5;
            _mSemaphore = new Semaphore(numberOfThreadsToUse, numberOfThreadsToUse);
            // get a list of all the key values to process

            while (collection.Count > 0)
            {
                // make of list of customer IDs to process in the next batch
                var dadosToProcess = collection.GetRange(0,
                Math.Min(batchSize, collection.Count));
                // remove those customer IDs from the master list so they are not processed again
                collection.RemoveRange(0, Math.Min(batchSize, collection.Count));

                // wait for the semaphore to let us launch another thread
                _mSemaphore.WaitOne();

                // launch a thread worker and give it the list of customer IDs to process
                QueueUserWorkItem(GravarBulkSql,
                    dadosToProcess);
            }

            // ensure all threads have exited by waiting until we can get all 
            // the semaphore requests
            for (var ctr = 0; ctr < numberOfThreadsToUse; ctr++)
            {
                _mSemaphore.WaitOne();
            }

            _mSemaphore.Release(numberOfThreadsToUse);
        }

        private static void GravarBulkSql(object state)
        {
            try
            {
                var collection = (List<T>)state;
                var conn = new OracleConnection(ConexaoDestino);
                var cmd = conn.CreateCommand();
                cmd.CommandText = ComandoSqlDestino;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.BindByName = true;

                #region Campos
                cmd.Parameters.AddRange(GetParameter(collection).ToArray());

                #endregion
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            finally
            {
                _mSemaphore.Release();
            }
        }

        /*
        public void ReadFromFile(string location)
        {
            Log.Info("Inicio Gravacao em Disco");
            using (var sw = new StreamReader(location, Encoding.UTF8))
            {

                var i = 1;
                var lista = new List<T>();
                var dt1 = DateTime.Now;

                while (!sw.EndOfStream)
                {
                    try
                    {
                        var line = sw.ReadLine();
                        if (line != null)
                        {
                            var value = line.Split('|');
                            var readerLine = value.Cast<object>().ToList();

                            #region Campos

                            lista.Add(GetModel(readerLine, i));
                        }

                        #endregion


                        if ((i % QuantidadeRegistrosPorTransacao) == 0)
                        {

                            try
                            {
                                Log.Info("Gravando : " + i.ToString("N0"));

                                var ls = lista;
                                lista = new List<T>();
                                GravarBulk(ls);
                                //log.Info("Gravado com sucesso!");

                            }
                            catch (Exception ex)
                            {

                                Log.Error("Erro na Gravacao dos registros : " + (i - QuantidadeRegistrosPorTransacao) + " até " + i + " - detalhes :  " + ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        Log.Error("Erro na leitura do registro : " + i + " - detalhes :  " + ex.Message);
                    }
                    i++;
                }

                GravarBulk(lista);
                Log.Info("Gravando : " + (i - 1).ToString("N0"));


                var dt2 = DateTime.Now;

                var elapsed = (dt2 - dt1).TotalSeconds;
                Log.Info("Tempo Total  em Segundos  - " + elapsed);

                Log.Info("------------------");

            }
        }*/
    }
}
