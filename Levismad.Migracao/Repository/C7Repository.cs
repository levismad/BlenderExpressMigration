using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C7Repository : BaseRepository<C7Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C7";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C7";

        public C7Repository() : base(SqlOrigem, SqlDestino, 29, GetModels, GetParameters)
        {
        }

        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C7");
        }
    

        private static C7Model GetModels(List<object> reader, int i)
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
            var o25 = reader[24];
            var o26 = reader[25];
            var o27 = reader[26];
            var o28 = reader[27];
            var o29 = reader[28];
            
            
            //decimal? nullDecimal = null;
            decimal decimalAux;

            var model = new C7Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? (decimal?) null : decimal.Parse(o5.ToString()),
                Endidtendereco = i,
                Endcodextendereco = o7.ToString(),
                Endcodextpessoa = o8.ToString(),
                Endtipendereco = o9.ToString() == "" ? (decimal?) null : decimal.Parse(o9.ToString()),
                Endtiplogradouro = o10.ToString() == "" ? (decimal?) null : decimal.Parse(o10.ToString()),
                Enddeslogradouro = o11.ToString(),
                Endnumendereco =
                    o12.ToString() == "" || !decimal.TryParse(o12.ToString(), out decimalAux)
                        ? (decimal?) null
                        : decimal.Parse(o12.ToString()),
                Enddescomplemento = o13.ToString(),
                Enddesbairro = o14.ToString(),
                Endcependereco = o15.ToString() == "" ? (decimal?) null : decimal.Parse(o15.ToString()),
                Endnommunicipio = o16.ToString(),
                Endcodextmunicipio = o17.ToString(),
                Endnomsiglauf = o18.ToString(),
                Endnomuf = o19.ToString(),
                Endcodextuf = o20.ToString(),
                Endnompais = o21.ToString(),
                Endcodextpais = o22.ToString(),
                Ctridtctrleitura =
                    o23.ToString() == "" || decimal.Parse(o23.ToString()) == 0
                        ? (decimal?) null
                        : decimal.Parse(o23.ToString()),
                Ctridtctrgravacao =
                    o24.ToString() == "" || decimal.Parse(o24.ToString()) == 0
                        ? (decimal?) null
                        : decimal.Parse(o24.ToString()),
                Endidtperfil =
                    o25.ToString() == "" || decimal.Parse(o25.ToString()) == 0
                        ? (decimal?) null
                        : decimal.Parse(o25.ToString()),
                Endidcprincipal = o26.ToString() == "" ? (decimal?) null : decimal.Parse(o26.ToString()),
                Endtippessoa = o27.ToString() == "" ? (decimal?) null : decimal.Parse(o27.ToString()),
                Endidtenviocorrespond = o28.ToString() == "" ? (decimal?) null : decimal.Parse(o28.ToString()),
                Endtipresidencia =
                    o29.ToString() == "" || decimal.Parse(o29.ToString()) == 0
                        ? (decimal?) null
                        : decimal.Parse(o29.ToString())
            };
            //o6.ToString() == "" ? nullDecimal : decimal.Parse(o6.ToString());

            #endregion
            return model;
        }
        private static List<OracleParameter> GetParameters(List<C7Model> models)
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
                result.Add(new OracleParameter("inENDIDTENDERECO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endidtendereco).ToArray()
                });
                result.Add(new OracleParameter("inENDCODEXTENDERECO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endcodextendereco).ToArray()
                });
                result.Add(new OracleParameter("inENDCODEXTPESSOA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endcodextpessoa).ToArray()
                });
                result.Add(new OracleParameter("inENDTIPENDERECO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endtipendereco).ToArray()
                });
                result.Add(new OracleParameter("inENDTIPLOGRADOURO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endtiplogradouro).ToArray()
                });
                result.Add(new OracleParameter("inENDDESLOGRADOURO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Enddeslogradouro).ToArray()
                });
                result.Add(new OracleParameter("inENDNUMENDERECO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endnumendereco).ToArray()
                });
                result.Add(new OracleParameter("inENDDESCOMPLEMENTO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Enddescomplemento).ToArray()
                });
                result.Add(new OracleParameter("inENDDESBAIRRO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Enddesbairro).ToArray()
                });
                result.Add(new OracleParameter("inENDCEPENDERECO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endcependereco).ToArray()
                });
                result.Add(new OracleParameter("inENDNOMMUNICIPIO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endnommunicipio).ToArray()
                });
                result.Add(new OracleParameter("inENDCODEXTMUNICIPIO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endcodextmunicipio).ToArray()
                });
                result.Add(new OracleParameter("inENDNOMSIGLAUF", OracleDbType.Char)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endnomsiglauf).ToArray()
                });
                result.Add(new OracleParameter("inENDNOMUF", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endnomuf).ToArray()
                });
                result.Add(new OracleParameter("inENDCODEXTUF", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endcodextuf).ToArray()
                });
                result.Add(new OracleParameter("inENDNOMPAIS", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endnompais).ToArray()
                });
                result.Add(new OracleParameter("inENDCODEXTPAIS", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endcodextpais).ToArray()
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
                result.Add(new OracleParameter("inENDIDTPERFIL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endidtperfil).ToArray()
                });
                result.Add(new OracleParameter("inENDIDCPRINCIPAL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endidcprincipal).ToArray()
                });
                result.Add(new OracleParameter("inENDTIPPESSOA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endtippessoa).ToArray()
                });
                result.Add(new OracleParameter("inENDIDTENVIOCORRESPOND", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endidtenviocorrespond).ToArray()
                });
                result.Add(new OracleParameter("inENDTIPRESIDENCIA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Endtipresidencia).ToArray()
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
