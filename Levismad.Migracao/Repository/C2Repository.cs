using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C2Repository : BaseRepository<C2Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C2";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C2";

        public C2Repository() : base(SqlOrigem, SqlDestino, 35, GetModels, GetParameters)
        {
        }


        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C2");          
        }

         

        private static C2Model GetModels(List<object> reader, int i) {

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
            var o30 = reader[29];
            var o31 = reader[30];
            var o32 = reader[31];
            var o33 = reader[32];
            var o34 = reader[33];
            var o35 = reader[34];

            DateTime dt;


            return new C2Model()
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? 0 : long.Parse(o5.ToString()),
                Appidtparcela = i, //o6.ToString() == "" ? 0 : long.Parse(o6.ToString()),
                Appidtempresa = o7.ToString() == "" ? 0 : long.Parse(o7.ToString()),
                Appnumproposta = o8.ToString(),
                Appvrsproposta = o9.ToString() == "" ? 0 : long.Parse(o9.ToString()),
                Apppctcetparcela = o10.ToString() == "" ? 0 : decimal.Parse(o10.ToString()),
                Appdatboavencimento = DateTime.TryParse(o11.ToString(), out dt) ? dt : (DateTime?)null,
                Appdatvencimento = DateTime.TryParse(o12.ToString(), out dt) ? dt : (DateTime?)null,
                Appidccomissao = o13.ToString() == "" ? 0 : long.Parse(o13.ToString()),
                Appidccorrecao = o14.ToString() == "" ? 0 : long.Parse(o14.ToString()),
                Appidcjuros = o15.ToString() == "" ? 0 : long.Parse(o15.ToString()),
                Appidcprincipal = o16.ToString() == "" ? 0 : long.Parse(o16.ToString()),
                Appidcliqautomatica = o17.ToString() == "" ? 0 : long.Parse(o17.ToString()),
                Appnumparcela = o18.ToString() == "" ? 0 : long.Parse(o18.ToString()),
                Appvalcomissao = o19.ToString() == "" ? 0 : decimal.Parse(o19.ToString()),
                Appvaliof = o20.ToString() == "" ? 0 : decimal.Parse(o20.ToString()),
                Appvaliofadic = o21.ToString() == "" ? 0 : decimal.Parse(o21.ToString()),
                Appvaliofmax = o22.ToString() == "" ? 0 : decimal.Parse(o22.ToString()),
                Appvalir = o23.ToString() == "" ? 0 : decimal.Parse(o23.ToString()),
                Appvaljuros = o24.ToString() == "" ? 0 : decimal.Parse(o24.ToString()),
                Appvallibor = o25.ToString() == "" ? 0 : decimal.Parse(o25.ToString()),
                Appvalprincipal = o26.ToString() == "" ? 0 : decimal.Parse(o26.ToString()),
                Appvalvencimento = o27.ToString() == "" ? 0 : decimal.Parse(o27.ToString()),
                Ctridtcontrolelei = o28.ToString() == "" ? 0 : long.Parse(o28.ToString()),
                Ctridtcontrolegra = o29.ToString() == "" ? 0 : long.Parse(o29.ToString()),
                Appalqiofmaximo = o30.ToString() == "" || decimal.Parse(o30.ToString()) == 0 ? (decimal?)null : decimal.Parse(o30.ToString()),
                Appidccomposparcela = o31.ToString() == "" || decimal.Parse(o31.ToString()) == 0 ? (long?)null : long.Parse(o31.ToString()),
                Appdatprocessamento = DateTime.TryParse(o32.ToString(), out dt) ? dt : (DateTime?)null,
                Appidttipoproposta = o33.ToString() == "" ? 0 : long.Parse(o33.ToString()),
                Appstastatuserro = o34.ToString() == "" || decimal.Parse(o34.ToString()) == 0 ? (long?)null : long.Parse(o34.ToString()),
                Appsitsituacao = o35.ToString() == "" ? 0 : long.Parse(o35.ToString()),

            };
            #endregion
        }
        private static List<OracleParameter> GetParameters(List<C2Model> models)
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
                result.Add(new OracleParameter("inAPPIDTPARCELA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidtparcela).ToArray()
                });
                result.Add(new OracleParameter("inAPPIDTEMPRESA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidtempresa).ToArray()
                });
                result.Add(new OracleParameter("inAPPNUMPROPOSTA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appnumproposta).ToArray()
                });
                result.Add(new OracleParameter("inAPPVRSPROPOSTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvrsproposta).ToArray()
                });
                result.Add(new OracleParameter("inAPPPCTCETPARCELA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apppctcetparcela).ToArray()
                });
                result.Add(new OracleParameter("inAPPDATBOAVENCIMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appdatboavencimento).ToArray()
                });
                result.Add(new OracleParameter("inAPPDATVENCIMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appdatvencimento).ToArray()
                });
                result.Add(new OracleParameter("inAPPIDCCOMISSAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidccomissao).ToArray()
                });
                result.Add(new OracleParameter("inAPPIDCCORRECAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidccorrecao).ToArray()
                });
                result.Add(new OracleParameter("inAPPIDCJUROS", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidcjuros).ToArray()
                });
                result.Add(new OracleParameter("inAPPIDCPRINCIPAL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidcprincipal).ToArray()
                });
                result.Add(new OracleParameter("inAPPIDCLIQAUTOMATICA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidcliqautomatica).ToArray()
                });
                result.Add(new OracleParameter("inAPPNUMPARCELA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appnumparcela).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALCOMISSAO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvalcomissao).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALIOF", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvaliof).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALIOFADIC", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvaliofadic).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALIOFMAX", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvaliofmax).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALIR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvalir).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALJUROS", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvaljuros).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALLIBOR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvallibor).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALPRINCIPAL", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvalprincipal).ToArray()
                });
                result.Add(new OracleParameter("inAPPVALVENCIMENTO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appvalvencimento).ToArray()
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
                result.Add(new OracleParameter("inAPPALQIOFMAXIMO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appalqiofmaximo).ToArray()
                });
                result.Add(new OracleParameter("inAPPIDCCOMPOSPARCELA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidccomposparcela).ToArray()
                });
                result.Add(new OracleParameter("inAPPDATPROCESSAMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appdatprocessamento).ToArray()
                });
                result.Add(new OracleParameter("inAPPIDTTIPOPROPOSTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appidttipoproposta).ToArray()
                });
                result.Add(new OracleParameter("inAPPSTASTATUSERRO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appstastatuserro).ToArray()
                });
                result.Add(new OracleParameter("inAPPSITSITUACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Appsitsituacao).ToArray()
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
