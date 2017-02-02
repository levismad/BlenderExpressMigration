using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model.TransferenciaAtraso;
using Oracle.ManagedDataAccess.Client;

// ReSharper disable once CheckNamespace
namespace Levismad.Repository
{
    public class C12Repository : BaseRepository<C12Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C12";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C12";

        public C12Repository() : base(SqlOrigem, SqlDestino, 24, GetModels, GetParameters)
        {
        }

        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C12", Finally, Math.Max(1, StringUtil.LastInsertC12));
        }

        private static int Finally(int index)
        {
            StringUtil.LastInsertC12 = index + 1;
            return 0;
        }
        private static C12Model GetModels(List<object> reader, int i)
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
            var o24 = reader[23];





            DateTime dt;

            //long? nullLong = null;
            //decimal? nullDecimal = null;
            var model = new C12Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? (decimal?) null : decimal.Parse(o5.ToString()),
                Traidtidentificador = i,
                Tradattransferencia = DateTime.TryParse(o7.ToString(), out dt) ? dt.Date : (DateTime?) null,
                Traidtonline = o8.ToString() == "" ? (long?) null : long.Parse(o8.ToString()),
                Travalprincipal = o9.ToString() == "" ? 0 : decimal.Parse(o9.ToString()),
                Travalsaldoconta = o10.ToString() == "" ? 0 : decimal.Parse(o10.ToString()),
                Tradatregistro = DateTime.TryParse(o11.ToString(), out dt) ? dt.Date : (DateTime?) null,
                Traidtonlinecanc = o12.ToString() == "" ? (long?) null : long.Parse(o12.ToString()),
                Traidttiptrans = o13.ToString() == "" ? (long?) null : long.Parse(o13.ToString()),
                Traidtsituacao = o14.ToString() == "" ? (long?) null : long.Parse(o14.ToString()),
                Traidtsitconta =
                    o15.ToString() == ""
                        ? (long?) null
                        : long.Parse(o15.ToString().Substring(0, Math.Min(1, o15.ToString().Length))),
                Tranumcontrato = o16.ToString(),
                Tranumversao = o17.ToString() == "" ? (long?) null : long.Parse(o17.ToString()),
                Ctridtcontrolelei = o18.ToString() == "" ? (long?) null : long.Parse(o18.ToString()),
                Ctridtcontrole = o19.ToString() == "" ? (long?) null : long.Parse(o19.ToString()),
                Traidtevento = o20.ToString() == "" ? (long?) null : long.Parse(o20.ToString()),
                Tranumparcela = o21.ToString() == "" ? (long?) null : long.Parse(o21.ToString()),
                Traidtsitanterior = o22.ToString() == "" ? (long?) null : long.Parse(o22.ToString()),
                Tradesusuario = o23.ToString(),
                Tradatprocessamento = DateTime.TryParse(o24.ToString(), out dt) ? dt.Date : (DateTime?) null
            };
            //o6.ToString() == "" ? nullLong : long.Parse(o6.ToString());





            #endregion
            return model;
        }
        private static List<OracleParameter> GetParameters(List<C12Model> models)
        {
            var result = new List<OracleParameter>();
            try
            {
                #region Campos
                result.Add(new OracleParameter("inHDRDATHOR ", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrdathor).ToArray()
                });
                result.Add(new OracleParameter("inHDRCODUSU ", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrcodusu).ToArray()
                });
                result.Add(new OracleParameter("inHDRCODETC", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrcodetc).ToArray()
                });
                result.Add(new OracleParameter("inHDRCODPGR ", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrcodpgr).ToArray()
                });
                result.Add(new OracleParameter("inHDRCODVER ", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Hdrcodver).ToArray()
                });
                result.Add(new OracleParameter("inTRAIDTIDENTIFICADOR", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Traidtidentificador).ToArray()
                });
                result.Add(new OracleParameter("inTRADATTRANSFERENCIA", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Tradattransferencia).ToArray()
                });
                result.Add(new OracleParameter("inTRAIDTONLINE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Traidtonline).ToArray()
                });
                result.Add(new OracleParameter("inTRAVALPRINCIPAL", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Travalprincipal).ToArray()
                });
                result.Add(new OracleParameter("inTRAVALSALDOCONTA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Travalsaldoconta).ToArray()
                });
                result.Add(new OracleParameter("inTRADATREGISTRO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Tradatregistro).ToArray()
                });
                result.Add(new OracleParameter("inTRAIDTONLINECANC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Traidtonlinecanc).ToArray()
                });
                result.Add(new OracleParameter("inTRAIDTTIPTRANS", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Traidttiptrans).ToArray()
                });
                result.Add(new OracleParameter("inTRAIDTSITUACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Traidtsituacao).ToArray()
                });
                result.Add(new OracleParameter("inTRAIDTSITCONTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Traidtsitconta).ToArray()
                });
                result.Add(new OracleParameter("inTRANUMCONTRATO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Tranumcontrato).ToArray()
                });
                result.Add(new OracleParameter("inTRANUMVERSAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Tranumversao).ToArray()
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
                result.Add(new OracleParameter("inTRAIDTEVENTO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Traidtevento).ToArray()
                });
                result.Add(new OracleParameter("inTRANUMPARCELA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Tranumparcela).ToArray()
                });
                result.Add(new OracleParameter("inTRAIDTSITANTERIOR", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Traidtsitanterior).ToArray()
                });
                result.Add(new OracleParameter("inTRADESUSUARIO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Tradesusuario).ToArray()
                });
                result.Add(new OracleParameter("inTRADATPROCESSAMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Tradatprocessamento).ToArray()
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
