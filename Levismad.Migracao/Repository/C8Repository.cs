using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C8Repository : BaseRepository<C8Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C8";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C8";
      

        public C8Repository() : base(SqlOrigem, SqlDestino, 10, GetModels, GetParameters)
        {
        }

        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C8");
        }           

        private static C8Model GetModels(List<object> reader, int i)
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


            //long? nullLong = null;
            var model = new C8Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? (long?) null : long.Parse(o5.ToString()),
                Ocuidtocupacao = i,
                Ocucodocupacaoext = o7.ToString(),
                Ocudesocupacao = (o8.ToString().Length <= 100) ? o8.ToString() : o8.ToString().Substring(0, 100),
                Ctridtcontrole =
                    o9.ToString() == "" || decimal.Parse(o9.ToString()) == 0 ? (long?) null : long.Parse(o9.ToString()),
                Ctridtcontrolelei =
                    o10.ToString() == "" || decimal.Parse(o10.ToString()) == 0
                        ? (long?) null
                        : long.Parse(o10.ToString())
            };

            //o6.ToString() == "" ? nullLong : long.Parse(o6.ToString());

            #endregion
            return model;

        }
        private static List<OracleParameter> GetParameters(List<C8Model> models)
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
                result.Add(new OracleParameter("inOCUIDTOCUPACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ocuidtocupacao).ToArray()
                });
                result.Add(new OracleParameter("inOCUCODOCUPACAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ocucodocupacaoext).ToArray()
                });
                result.Add(new OracleParameter("inOCUDESOCUPACAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ocudesocupacao).ToArray()
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
