using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C10Repository : BaseRepository<C10Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C10";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C10";
      
        public C10Repository() : base(SqlOrigem, SqlDestino, 11, GetModels, GetParameters)
        {
        }

        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C10");
        }


        private static C10Model GetModels(List<object> reader, int i)
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



            //long? nullLong = null;
            var model = new C10Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? 0 : long.Parse(o5.ToString()),
                Orgidtorgao = o9.ToString() == "" ? 0 : long.Parse(o9.ToString()),
                Ctridtcontrolelei =
                    o7.ToString() == "" || long.Parse(o7.ToString()) == 0 ? (long?) null : long.Parse(o7.ToString()),
                Ctridtcontrole =
                    o8.ToString() == "" || long.Parse(o8.ToString()) == 0 ? (long?) null : long.Parse(o8.ToString()),
                Orgcodorgaoext = o9.ToString(),
                Orgdesorgaoext = o10.ToString(),
                Orgcodprodutoext = o11.ToString()
            };




            #endregion
            return model;
        }
        private static List<OracleParameter> GetParameters(List<C10Model> models)
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
                result.Add(new OracleParameter("inORGIDTORGAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Orgidtorgao).ToArray()
                });
                result.Add(new OracleParameter("inCTRIDTCONTROLELEI", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ctridtcontrolelei).ToArray()
                });
                result.Add(new OracleParameter("inCTRIDTCONTROLE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Ctridtcontrole).ToArray()
                });
                result.Add(new OracleParameter("inORGCODORGAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Orgcodorgaoext).ToArray()
                });
                result.Add(new OracleParameter("inORGDESORGAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Orgdesorgaoext).ToArray()
                });
                result.Add(new OracleParameter("inORGCODPRODUTOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Orgcodprodutoext).ToArray()
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
