using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C14Repository : BaseRepository<C14Model>
    {
        private const string SqlOrigem = "";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C14";


        private string ComandoSqlOrigem1 { get; }
        private string ComandoSqlOrigem2 { get; }
        private string ComandoSqlOrigem3 { get;  }
        private string ComandoSqlOrigem4 { get; }
        private string ComandoSqlOrigem5 { get; }
        public C14Repository() : base(SqlOrigem, SqlDestino, 17, GetModels, GetParameters)
        {
            ComandoSqlOrigem1 = ConfigurationManager.AppSettings["Levismad.ComandoSQLOrigem.C14_1"];
            ComandoSqlOrigem2 = ConfigurationManager.AppSettings["Levismad.ComandoSQLOrigem.C14_2"];
            ComandoSqlOrigem3 = ConfigurationManager.AppSettings["Levismad.ComandoSQLOrigem.C14_3"];
            ComandoSqlOrigem4 = ConfigurationManager.AppSettings["Levismad.ComandoSQLOrigem.C14_4"];
            ComandoSqlOrigem5 = ConfigurationManager.AppSettings["Levismad.ComandoSQLOrigem.C14_5"];
        }


        public void EfetuarCarga(bool infoOnly)
        {
            var lst = !infoOnly ? new List<string>() { ComandoSqlOrigem1, ComandoSqlOrigem2, ComandoSqlOrigem5 } : new List<string>() { ComandoSqlOrigem3, ComandoSqlOrigem4 };
            if (infoOnly && StringUtil.LastInsertC14 == 1)
            {
                StringUtil.LastInsertC14 = 500000000;
            }
            else if (StringUtil.LastInsertC14 > 500000000)
            {
                StringUtil.LastInsertC14 = 1;
            }
            var carga = !infoOnly ? "14" : "15";
            EfetuarCargaDefault($"C{carga}", lst , Finally, Math.Max(1, StringUtil.LastInsertC14));
        }
        
        
        private static int Finally(int index)
        {
            StringUtil.LastInsertC14 = index + 1;
            return 0;
        }
        private static C14Model GetModels(List<object> reader, int i)
        {
            #region Campos
            var o1 = reader[0];
            var o2 = reader[1];
            var o3 = reader[2];
            var o4 = reader[3];
            var o5 = reader[4];
            //var o6 = reader[5];
            var o7 = reader[6];
            var o8 = reader[7];
            var o9 = reader[8];
            var o10 = reader[9];
            var o11 = reader[10];
            var o12 = reader[11];
            var o13 = reader[12];
            var o14 = reader[13];
            var o15 = reader[14];
            var o16 = reader[15];
            var o17 = reader[16];

            DateTime dt;

            //long? nullLong = null;
            var model = new C14Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? (long?) null : long.Parse(o5.ToString()),
                Aopidtocorrproposta = i,
                Aopidtempresa = o7.ToString() == "" ? (long?) null : long.Parse(o7.ToString()),
                Aopnumproposta = o8.ToString(),
                Aopvrsproposta = o9.ToString() == "" ? (long?) null : long.Parse(o9.ToString()),
                Aopidtocorrencia = o10.ToString(),
                Aopdatocorrencia = DateTime.TryParse(o11.ToString(), out dt) ? dt.Date : (DateTime?) null,
                Aopdesocorrencia = o12.ToString(),
                Aopnomusuariogra = o13.ToString(),
                Ctridtcontrolelei = o14.ToString() == "" ? (long?) null : long.Parse(o14.ToString()),
                Ctridtcontrolegra = o15.ToString() == "" ? (long?) null : long.Parse(o15.ToString()),
                Aopdatprocessamento = DateTime.TryParse(o16.ToString(), out dt) ? dt.Date : (DateTime?) null,
                Aopstastatuserro = o17.ToString() == "" ? (long?) null : long.Parse(o17.ToString())
            };
            //o6.ToString() == "" ? nullLong : long.Parse(o6.ToString());


            #endregion
            return model;

        }
        private static List<OracleParameter> GetParameters(List<C14Model> models)
        {
            var result = new List<OracleParameter>();
            try
            {
                #region Campos
                result.Add(new OracleParameter("inHDRDATHOR", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrdathor).ToArray()
                });
                result.Add(new OracleParameter("inHDRCODUSU", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrcodusu).ToArray()
                });
                result.Add(new OracleParameter("inHDRCODETC", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrcodetc).ToArray()
                });
                result.Add(new OracleParameter("inHDRCODPGR", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrcodpgr).ToArray()
                });
                result.Add(new OracleParameter("inHDRCODVER", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrcodver).ToArray()
                });
                result.Add(new OracleParameter("inAOPIDTOCORRPROPOSTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopidtocorrproposta).ToArray()
                });
                result.Add(new OracleParameter("inAOPIDTEMPRESA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopidtempresa).ToArray()
                });
                result.Add(new OracleParameter("inAOPNUMPROPOSTA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopnumproposta).ToArray()
                });
                result.Add(new OracleParameter("inAOPVRSPROPOSTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopvrsproposta).ToArray()
                });
                result.Add(new OracleParameter("inAOPIDTOCORRENCIA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopidtocorrencia).ToArray()
                });
                result.Add(new OracleParameter("inAOPDATOCORRENCIA", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopdatocorrencia).ToArray()
                });
                result.Add(new OracleParameter("inAOPDESOCORRENCIA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopdesocorrencia).ToArray()
                });
                result.Add(new OracleParameter("inAOPNOMUSUARIOGRA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopnomusuariogra).ToArray()
                });
                result.Add(new OracleParameter("inCTRIDTCONTROLELEI", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ctridtcontrolelei).ToArray()
                });
                result.Add(new OracleParameter("inCTRIDTCONTROLEGRA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ctridtcontrolegra).ToArray()
                });
                result.Add(new OracleParameter("inAOPDATPROCESSAMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopdatprocessamento).ToArray()
                });
                result.Add(new OracleParameter("inAOPSTASTATUSERRO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Aopstastatuserro).ToArray()
                });
                #endregion
            }
            catch (Exception)
            {
                // ignored
            }
            return result;
        }
    }
}
