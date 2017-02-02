using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C6Repository : BaseRepository<C6Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C6";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C6";

        public C6Repository() : base(SqlOrigem, SqlDestino, 20, GetModels, GetParameters)
        {
        }


        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C6");
        }


        private static C6Model GetModels(List<object> reader, int i)
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
            var o18 = reader[17];
            var o19 = reader[18];
            var o20 = reader[19];




            DateTime dt;

            //long? nullLong = null;
            //decimal? nullDecimal = null;
            var bancario = new C6Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? (decimal?)null : decimal.Parse(o5.ToString()),
                Nobidtnegoutrobanco = i,
                Nobcodexterno = o7.ToString(),
                Nobcodextpessoa = o8.ToString(),
                Nobcodextagenciaext = o9.ToString(),
                Nobcodextbanco = o10.ToString(),
                Nobnumnegocio = o11.ToString(),
                Nobnumdvnegocio = o12.ToString(),
                Nobvalvalorlimite =
                    o13.ToString() == "" || decimal.Parse(o13.ToString()) == 0 ? (long?)null : long.Parse(o13.ToString()),
                Nobvalsaldodevedor =
                    o14.ToString() == "" || decimal.Parse(o14.ToString()) == 0 ? (long?)null : long.Parse(o14.ToString()),
                Nobdatiniciooperacao = DateTime.TryParse(o15.ToString(), out dt) ? dt : (DateTime?)null,
                Nobdatfimoperacao = DateTime.TryParse(o16.ToString(), out dt) ? dt : (DateTime?)null,
                Nobtinegocio = o17.ToString() == "" ? (decimal?)null : decimal.Parse(o17.ToString()),
                Nobidtsituacao = o18.ToString() == "" ? (decimal?)null : decimal.Parse(o18.ToString()),
                Ctridtctrleitura =
                    o19.ToString() == "" || decimal.Parse(o19.ToString()) == 0
                        ? (decimal?)null
                        : decimal.Parse(o19.ToString()),
                Ctridtctrgravacao =
                    o20.ToString() == "" || decimal.Parse(o20.ToString()) == 0
                        ? (decimal?)null
                        : decimal.Parse(o20.ToString())
            };
            //o6.ToString() == "" ? nullDecimal : decimal.Parse(o6.ToString());






            #endregion
            return bancario;
        }
        private static List<OracleParameter> GetParameters(List<C6Model> models)
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
                result.Add(new OracleParameter("inNOBIDTNEGOUTROBANCO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobidtnegoutrobanco).ToArray()
                });
                result.Add(new OracleParameter("inNOBCODEXTERNO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobcodexterno).ToArray()
                });
                result.Add(new OracleParameter("inNOBCODEXTPESSOA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobcodextpessoa).ToArray()
                });
                result.Add(new OracleParameter("inNOBCODEXTAGENCIAEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobcodextagenciaext).ToArray()
                });
                result.Add(new OracleParameter("inNOBCODEXTBANCO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobcodextbanco).ToArray()
                });
                result.Add(new OracleParameter("inNOBNUMNEGOCIO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobnumnegocio).ToArray()
                });
                result.Add(new OracleParameter("inNOBNUMDVNEGOCIO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobnumdvnegocio).ToArray()
                });
                result.Add(new OracleParameter("inNOBVALVALORLIMITE", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobvalvalorlimite).ToArray()
                });
                result.Add(new OracleParameter("inNOBVALSALDODEVEDOR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobvalsaldodevedor).ToArray()
                });
                result.Add(new OracleParameter("inNOBDATINICIOOPERACAO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobdatiniciooperacao).ToArray()
                });
                result.Add(new OracleParameter("inNOBDATFIMOPERACAO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobdatfimoperacao).ToArray()
                });
                result.Add(new OracleParameter("inNOBTINEGOCIO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobtinegocio).ToArray()
                });
                result.Add(new OracleParameter("inNOBIDTSITUACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Nobidtsituacao).ToArray()
                });
                result.Add(new OracleParameter("inCTRIDTCTRLEITURA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ctridtctrleitura).ToArray()
                });
                result.Add(new OracleParameter("inCTRIDTCTRGRAVACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ctridtctrgravacao).ToArray()
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
