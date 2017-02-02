using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;
using static System.String;

namespace Levismad.Repository
{
    public class C9Repository : BaseRepository<C9Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C9";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C9";
       
        public C9Repository() : base(SqlOrigem, SqlDestino, 18, GetModels, GetParameters)
        {
        }

        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C9");
        }       
       

        private static C9Model GetModels(List<object> reader, int i)
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
            //var o9 = reader[8];
            var o10 = reader[9];
            var o11 = reader[10];
            var o12 = reader[11];
            var o13 = reader[12];
            var o14 = reader[13];
            var o15 = reader[14];
            var o16 = reader[15];
            var o17 = reader[16];
            var o18 = reader[17];


            

            //long? nullLong = null;
            //decimal? nullDecimal = null;

            var model = new C9Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? (long?) null : long.Parse(o5.ToString()),
                Adpidtclienteorgao = i,
                Ctridtcontrole =
                    o7.ToString() == "" || long.Parse(o7.ToString()) == 0 ? (long?) null : long.Parse(o7.ToString()),
                Ctridtcontrolelei =
                    o8.ToString() == "" || long.Parse(o8.ToString()) == 0 ? (long?) null : long.Parse(o8.ToString()),
                Adpcodpessoaprofisext = "99999",
                Adpcodclienteext = o10.ToString(),
                Adpcodorgaoext = o11.ToString(),
                Adpcodsuborgaoext = o12.ToString(),
                Adpcodprofissaoext = IsNullOrEmpty(o13.ToString()) ? "0" : o13.ToString(),
                Adpcodocupacaoext = IsNullOrEmpty(o14.ToString()) ? "0" : o14.ToString(),
                Adpcodmatricula = o15.ToString(),
                Adpvalrendabruta = o16.ToString() == "" ? (decimal?) null : decimal.Parse(o16.ToString()),
                Adpvalrendaliquida = o17.ToString() == "" ? (decimal?) null : decimal.Parse(o17.ToString()),
                Adpidcativo = o18.ToString() == "" ? (long?) null : long.Parse(o18.ToString())
            };
            //o6.ToString() == "" ? nullLong : long.Parse(o6.ToString());
            //String.IsNullOrEmpty(o9.ToString()) ? "0" : o9.ToString();
            //wagner ver
            //wagner ver

            #endregion
            return model;
        }
        private static List<OracleParameter> GetParameters(List<C9Model> models)
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
                result.Add(new OracleParameter("inADPIDTCLIENTEORGAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpidtclienteorgao).ToArray()
                });
                result.Add(new OracleParameter("inCTRIDTCONTROLE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ctridtcontrole).ToArray()
                });
                result.Add(new OracleParameter("inCTRIDTCONTROLELEI", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ctridtcontrolelei).ToArray()
                });
                result.Add(new OracleParameter("inADPCODPESSOAPROFISEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpcodpessoaprofisext).ToArray()
                });
                result.Add(new OracleParameter("inADPCODCLIENTEEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpcodclienteext).ToArray()
                });
                result.Add(new OracleParameter("inADPCODORGAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpcodorgaoext).ToArray()
                });
                result.Add(new OracleParameter("inADPCODSUBORGAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpcodsuborgaoext).ToArray()
                });
                result.Add(new OracleParameter("inADPCODPROFISSAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpcodprofissaoext).ToArray()
                });
                result.Add(new OracleParameter("inADPCODOCUPACAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpcodocupacaoext).ToArray()
                });
                result.Add(new OracleParameter("inADPCODMATRICULA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpcodmatricula).ToArray()
                });
                result.Add(new OracleParameter("inADPVALRENDABRUTA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpvalrendabruta).ToArray()
                });
                result.Add(new OracleParameter("inADPVALRENDALIQUIDA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpvalrendaliquida).ToArray()
                });
                result.Add(new OracleParameter("inADPIDCATIVO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Adpidcativo).ToArray()
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
