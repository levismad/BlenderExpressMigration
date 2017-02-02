using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C1Repository : BaseRepository<C1Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C1";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C1";

		public C1Repository() : base(SqlOrigem, SqlDestino, 56, GetModels, GetParameters)
        {
		}


        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C1");
        }        

        private static C1Model GetModels(List<object> reader, int i)
        {

            #region Campos

            var o1 = reader[0];
            var o2 = reader[1];
            var o3 = reader[2];
            var o4 = reader[3];
            var o5 = reader[4];
            var o6 = reader[5];
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
            var o36 = reader[35];
            var o37 = reader[36];
            var o38 = reader[37];
            var o39 = reader[38];
            var o40 = reader[39];
            var o41 = reader[40];
            var o42 = reader[41];
            var o43 = reader[42];
            var o44 = reader[43];
            var o45 = reader[44];
            var o46 = reader[45];
            var o47 = reader[46];
            var o48 = reader[47];
            var o49 = reader[48];
            var o50 = reader[49];
            var o51 = reader[50];
            var o52 = reader[51];
            var o53 = reader[52];
            var o54 = reader[53];
            var o55 = reader[54];
            var o56 = reader[55];

            DateTime dt;
            //long? noll = null;


            return new C1Model()
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? 0 : long.Parse(o5.ToString()),
                Cliidtcliente = o6.ToString() == "" ? 0 : long.Parse(o6.ToString()),
                Clicodextcliente = o7.ToString(),
                Clicodextpessoa = o8.ToString(),
                Clicodextempresa = o9.ToString(),
                Clicodextramoativ = o10.ToString(),
                Clicodextsetornat = o11.ToString(),
                Clicodextporte = o12.ToString(),
                Clicodextfuncionario = o13.ToString(),
                Clicodextclassific = o14.ToString(),
                Clicodextcapitalsoc = o15.ToString(),
                Clitippessoa = o16.ToString() == "" ? 0 : long.Parse(o16.ToString()),
                Clinomcliente = o17.ToString(),
                Clinomabvcliente = o18.ToString(),
                Clidatnascimento = DateTime.TryParse(o19.ToString(), out dt) ? dt : (DateTime?)null, //o19.ToString() == "" ? DateTime.MinValue : DateTime.Parse(o19.ToString()),
                Clinumrg = o20.ToString(),
                Clidatemissaorg = DateTime.TryParse(o21.ToString(), out dt) ? dt : (DateTime?)null, //o21.ToString() == "" ? DateTime.MinValue : DateTime.Parse(o21.ToString()),
                Clidesorgaoexpedidor = o22.ToString(),
                Clidesufrg = o23.ToString(),
                Clinompai = o24.ToString(),
                Clidatnascpai = DateTime.TryParse(o25.ToString(), out dt) ? dt : (DateTime?)null,//o25.ToString() == "" ? DateTime.MinValue : DateTime.Parse(o25.ToString()),
                Clinommae = o26.ToString(),
                Clidatnascmae = DateTime.TryParse(o27.ToString(), out dt) ? dt : (DateTime?)null,// o27.ToString() == "" ? DateTime.MinValue : DateTime.Parse(o27.ToString()),
                Clinuminscestadual = o28.ToString(),
                Clinumcpfcnpj = o29.ToString() == "" ? 0 : long.Parse(o29.ToString()),
                Clinumbasecpfcnpj = o30.ToString() == "" ? 0 : long.Parse(o30.ToString()),
                Clinumdvcpfcnpj = o31.ToString() == "" ? 0 : long.Parse(o31.ToString()),
                Clinumfilialcnpj = o32.ToString() == "" ? 0 : long.Parse(o32.ToString()),
                Clidatconstempresa = DateTime.TryParse(o33.ToString(), out dt) ? dt : (DateTime?)null,//o33.ToString() == "" ? DateTime.MinValue : DateTime.Parse(o33.ToString()),
                Clitipcontroleacio = o34.ToString() == "" ? (long?) null : long.Parse(o34.ToString()),
                Clitipempresa = o35.ToString() == "" ? (long?) null : long.Parse(o35.ToString()),
                Cliidtsexo = o36.ToString() == "" ? (long?) null : long.Parse(o36.ToString()),
                Clidesnaturalidade = o37.ToString(),
                Cliidtestcivil = o38.ToString() == "" ? (long?) null : long.Parse(o38.ToString()),
                Clinomconjuge = o39.ToString(),
                Clidatnascconjuge = DateTime.TryParse(o40.ToString(), out dt) ? dt : (DateTime?)null,//o40.ToString() == "" ? DateTime.MinValue : DateTime.Parse(o40.ToString()),
                Clicodcnae = o41.ToString(),
                Clitipnivelrisco = o42.ToString() == "" ? 2 : long.Parse(o42.ToString()),
                Clivalrendamensal = o43.ToString() == "" ? 0 : decimal.Parse(o43.ToString()),
                Cliidtcobraioflib = o44.ToString() == "" ? 0 : long.Parse(o44.ToString()),
                Cliidtcobraiofadiclib = o45.ToString() == "" ? 0 : long.Parse(o45.ToString()),
                Clidatinilimiteglobal = DateTime.TryParse(o46.ToString(), out dt) ? dt : (DateTime?)null,//o46.ToString() == "" ? DateTime.MinValue : DateTime.Parse(o46.ToString()),
                Clidatfimlimiteglobal = DateTime.TryParse(o47.ToString(), out dt) ? dt : (DateTime?)null,//o47.ToString() == "" ? DateTime.MinValue : DateTime.Parse(o47.ToString()),
                Clivallimiteglobal = o48.ToString() == "" ? 0 : decimal.Parse(o48.ToString()),
                Cliindindeterminado = o49.ToString() == "" ? 0 : long.Parse(o49.ToString()),
                Clisitcliente = o50.ToString() == "" ? 0 : long.Parse(o50.ToString()),
                Ctridtctrleitura = o51.ToString() == "" ? 0 : long.Parse(o51.ToString()),
                Ctridtctrgravacao = o52.ToString() == "" ? 0 : long.Parse(o52.ToString()),
                Clicodconglomeradoeco = o53.ToString(),
                Cliidccadastrpositivo = o54.ToString() == "" ? 0 : long.Parse(o54.ToString()),
                Clinumrne = o55.ToString(),
                Cliidcautorizacao = o56.ToString() == "" ? 0 : long.Parse(o56.ToString())

            };
            #endregion
        }
        private static List<OracleParameter> GetParameters(List<C1Model> models)
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
                result.Add(new OracleParameter("inCLIIDTCLIENTE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Cliidtcliente).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTCLIENTE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextcliente).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTPESSOA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextpessoa).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextempresa).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTRAMOATIV", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextramoativ).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTSETORNAT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextsetornat).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTPORTE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextporte).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTFUNCIONARIO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextfuncionario).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTCLASSIFIC", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextclassific).ToArray()
                });
                result.Add(new OracleParameter("inCLICODEXTCAPITALSOC", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodextcapitalsoc).ToArray()
                });
                result.Add(new OracleParameter("inCLITIPPESSOA", OracleDbType.Int16)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clitippessoa).ToArray()
                });
                result.Add(new OracleParameter("inCLINOMCLIENTE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinomcliente).ToArray()
                });
                result.Add(new OracleParameter("inCLINOMABVCLIENTE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinomabvcliente).ToArray()
                });
                result.Add(new OracleParameter("inCLIDATNASCIMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidatnascimento).ToArray()
                });
                result.Add(new OracleParameter("inCLINUMRG", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinumrg).ToArray()
                });
                result.Add(new OracleParameter("inCLIDATEMISSAORG", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidatemissaorg).ToArray()
                });
                result.Add(new OracleParameter("inCLIDESORGAOEXPEDIDOR", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidesorgaoexpedidor).ToArray()
                });
                result.Add(new OracleParameter("inCLIDESUFRG", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidesufrg).ToArray()
                });
                result.Add(new OracleParameter("inCLINOMPAI", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinompai).ToArray()
                });
                result.Add(new OracleParameter("inCLIDATNASCPAI", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidatnascpai).ToArray()
                });
                result.Add(new OracleParameter("inCLINOMMAE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinommae).ToArray()
                });
                result.Add(new OracleParameter("inCLIDATNASCMAE", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidatnascmae).ToArray()
                });
                result.Add(new OracleParameter("inCLINUMINSCESTADUAL", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinuminscestadual).ToArray()
                });
                result.Add(new OracleParameter("inCLINUMCPFCNPJ", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinumcpfcnpj).ToArray()
                });
                result.Add(new OracleParameter("inCLINUMBASECPFCNPJ", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinumbasecpfcnpj).ToArray()
                });
                result.Add(new OracleParameter("inCLINUMDVCPFCNPJ", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinumdvcpfcnpj).ToArray()
                });
                result.Add(new OracleParameter("inCLINUMFILIALCNPJ", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinumfilialcnpj).ToArray()
                });
                result.Add(new OracleParameter("inCLIDATCONSTEMPRESA", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidatconstempresa).ToArray()
                });
                result.Add(new OracleParameter("inCLITIPCONTROLEACIO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clitipcontroleacio).ToArray()
                });
                result.Add(new OracleParameter("inCLITIPEMPRESA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clitipempresa).ToArray()
                });
                result.Add(new OracleParameter("inCLIIDTSEXO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Cliidtsexo).ToArray()
                });
                result.Add(new OracleParameter("inCLIDESNATURALIDADE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidesnaturalidade).ToArray()
                });
                result.Add(new OracleParameter("inCLIIDTESTCIVIL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Cliidtestcivil).ToArray()
                });
                result.Add(new OracleParameter("inCLINOMCONJUGE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinomconjuge).ToArray()
                });
                result.Add(new OracleParameter("inCLIDATNASCCONJUGE", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidatnascconjuge).ToArray()
                });
                result.Add(new OracleParameter("inCLICODCNAE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodcnae).ToArray()
                });
                result.Add(new OracleParameter("inCLITIPNIVELRISCO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clitipnivelrisco).ToArray()
                });
                result.Add(new OracleParameter("inCLIVALRENDAMENSAL", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clivalrendamensal).ToArray()
                });
                result.Add(new OracleParameter("inCLIIDTCOBRAIOFLIB", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Cliidtcobraioflib).ToArray()
                });
                result.Add(new OracleParameter("inCLIIDTCOBRAIOFADICLIB", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Cliidtcobraiofadiclib).ToArray()
                });
                result.Add(new OracleParameter("inCLIDATINILIMITEGLOBAL", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidatinilimiteglobal).ToArray()
                });
                result.Add(new OracleParameter("inCLIDATFIMLIMITEGLOBAL", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clidatfimlimiteglobal).ToArray()
                });
                result.Add(new OracleParameter("inCLIVALLIMITEGLOBAL", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clivallimiteglobal).ToArray()
                });
                result.Add(new OracleParameter("inCLIINDINDETERMINADO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Cliindindeterminado).ToArray()
                });
                result.Add(new OracleParameter("inCLISITCLIENTE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clisitcliente).ToArray()
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
                result.Add(new OracleParameter("inCLICODCONGLOMERADOECO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clicodconglomeradoeco).ToArray()
                });
                result.Add(new OracleParameter("inCLIIDCCADASTRPOSITIVO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Cliidccadastrpositivo).ToArray()
                });
                result.Add(new OracleParameter("inCLINUMRNE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Clinumrne).ToArray()
                });
                result.Add(new OracleParameter("inCLIIDCAUTORIZACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Cliidcautorizacao).ToArray()
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
