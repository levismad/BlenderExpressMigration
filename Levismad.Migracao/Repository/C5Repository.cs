using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C5Repository : BaseRepository<C5Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C5";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C5";

        public C5Repository() : base(SqlOrigem, SqlDestino, 23, GetModels, GetParameters)
        {
        }

        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C5Repository");
        }

        

        private static C5Model GetModels(List<object> reader, int i)
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
            var o21 = reader[20];
            var o22 = reader[21];
            var o23 = reader[22];





            
            //decimal? nullDecimal = null;
            decimal decimalAux;
            var contato = new C5Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? (decimal?) null : decimal.Parse(o5.ToString()),
                Conidtcontato = i,
                Concodextcontato = o7.ToString(),
                Concodextpessoa = o8.ToString(),
                Connomcontato = o9.ToString(),
                Connumdddtelefone =
                    o10.ToString() == ""
                        ? (decimal?) null
                        : decimal.Parse(o10.ToString().Substring(0, Math.Min(3, o10.ToString().Length))),
                Connumtelefone = o11.ToString() == "" ? (decimal?) null : decimal.Parse(o11.ToString()),
                Connumramal =
                    o12.ToString() == "" || !decimal.TryParse(o12.ToString(), out decimalAux)
                        ? (decimal?) null
                        : decimal.Parse(o12.ToString()),
                Connumdddfax = o13.ToString() == "" ? (decimal?) null : decimal.Parse(o13.ToString()),
                Connumfax = o14.ToString() == "" ? (decimal?) null : decimal.Parse(o14.ToString()),
                Condesemail = o15.ToString(),
                Ctridtctrleitura =
                    o16.ToString() == "" || decimal.Parse(o16.ToString()) == 0
                        ? (decimal?) null
                        : decimal.Parse(o16.ToString()),
                Ctridtctrgravacao =
                    o17.ToString() == "" || decimal.Parse(o17.ToString()) == 0
                        ? (decimal?) null
                        : decimal.Parse(o17.ToString()),
                Conidtperfil =
                    o18.ToString() == "" || decimal.Parse(o18.ToString()) == 0
                        ? (decimal?) null
                        : decimal.Parse(o18.ToString()),
                Contiptelcontato = o19.ToString() == "" ? (decimal?) null : decimal.Parse(o19.ToString()),
                Conidttelprincipal = o20.ToString() == "" ? (decimal?) null : decimal.Parse(o20.ToString()),
                Conidtmarketingsms = o21.ToString() == "" ? (decimal?) null : decimal.Parse(o21.ToString()),
                Conidtmarketingemail = o22.ToString() == "" ? (decimal?) null : decimal.Parse(o22.ToString()),
                Condesafinidade = o23.ToString()
            };
            //o6.ToString() == "" ? nullDecimal : decimal.Parse(o6.ToString());


            #endregion
            return contato;
        }
        private static List<OracleParameter> GetParameters(List<C5Model> models)
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
                result.Add(new OracleParameter("inCONIDTCONTATO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Conidtcontato).ToArray()
                });
                result.Add(new OracleParameter("inCONCODEXTCONTATO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Concodextcontato).ToArray()
                });
                result.Add(new OracleParameter("inCONCODEXTPESSOA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Concodextpessoa).ToArray()
                });
                result.Add(new OracleParameter("inCONNOMCONTATO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Connomcontato).ToArray()
                });
                result.Add(new OracleParameter("inCONNUMDDDTELEFONE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Connumdddtelefone).ToArray()
                });
                result.Add(new OracleParameter("inCONNUMTELEFONE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Connumtelefone).ToArray()
                });
                result.Add(new OracleParameter("inCONNUMRAMAL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Connumramal).ToArray()
                });
                result.Add(new OracleParameter("inCONNUMDDDFAX", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Connumdddfax).ToArray()
                });
                result.Add(new OracleParameter("inCONNUMFAX", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Connumfax).ToArray()
                });
                result.Add(new OracleParameter("inCONDESEMAIL", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Condesemail).ToArray()
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
                result.Add(new OracleParameter("inCONIDTPERFIL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Conidtperfil).ToArray()
                });
                result.Add(new OracleParameter("inCONTIPTELCONTATO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Contiptelcontato).ToArray()
                });
                result.Add(new OracleParameter("inCONIDTTELPRINCIPAL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Conidttelprincipal).ToArray()
                });
                result.Add(new OracleParameter("inCONIDTMARKETINGSMS", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Conidtmarketingsms).ToArray()
                });
                result.Add(new OracleParameter("inCONIDTMARKETINGEMAIL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Conidtmarketingemail).ToArray()
                });
                result.Add(new OracleParameter("inCONDESAFINIDADE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Condesafinidade).ToArray()
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