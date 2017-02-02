using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C4Repository : BaseRepository<C4Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C4";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C4";
        private static string Filtro { get; set; }

        #region _requisits
        private static readonly Dictionary<string, KeyValuePair<string, bool>> Requisits = new Dictionary
            <string, KeyValuePair<string, bool>>()
        {
            /*
            { "Remover tabela temporária XXX_1", new KeyValuePair<string, bool>("DROP TABLE XXX_1", false)},
            { "Aprimoramento 1", new KeyValuePair<string, bool>("", true) },
            { "Remover tabela temporária XXX_2", new KeyValuePair<string, bool>("DROP TABLE XXX_2", false)},
            { "Aprimoramento 2", new KeyValuePair<string, bool>("", true) },
            { "Remover tabela temporária XXX_3", new KeyValuePair<string, bool>("DROP TABLE XXX_3", false)},
            { "Aprimoramento 3", new KeyValuePair<string, bool>("", true) },
            { "Remover tabela temporária XXX_4", new KeyValuePair<string, bool>("DROP TABLE XXX_4", false)},
            { "Aprimoramento 4", new KeyValuePair<string, bool>("", true) },
            { "Aprimoramento 5", new KeyValuePair<string, bool>("", true) }
            */
        };
        #endregion

        public C4Repository() : base(SqlOrigem, SqlDestino, 57, GetModels, GetParameters, Requisits)
        {
            Filtro = ConfigurationManager.AppSettings["Levismad.ComandoSQLOrigem.C4Filtro"];
        }

        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C4");
        }

        private static C4Model GetModels(List<object> reader, int i)
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

            DateTime dt;

            if (!DateTime.TryParse(o15.ToString(), out dt))
            {
                throw new Exception($"Campo DPGDATPAGAMENTO esta definido como não pode ser nulo. (Valor {o15})");
            }

            var model = new C4Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? 0 : long.Parse(o5.ToString()),
                Dpgidtidentificador = i,
                Ctridtcontrolelei = o7.ToString() == "" ? (long?)null : long.Parse(o7.ToString()),
                Ctridtcontrolegra = o8.ToString() == "" ? (long?)null : long.Parse(o8.ToString()),
                Dpgnumagencia = o9.ToString(),
                Dpgnumcnpj = o10.ToString(),
                Dpgcodbanco = o11.ToString() == "" ? (long?)null : long.Parse(o11.ToString()),
                Dpgnumconta = o12.ToString(),
                Dpgidtcripagparcial = o13.ToString() == "" ? (long?)null : long.Parse(o13.ToString()),
                Dpgdatpagamento = DateTime.Parse(o14.ToString()).Date,
                Dpgdatvencparc = DateTime.TryParse(o15.ToString(), out dt) ? dt.Date : (DateTime?)null,
                Dpgidcformapag = o16.ToString() == "" ? (long?)null : long.Parse(o16.ToString()),
                Dpgidtempresa = o17.ToString() == "" ? 0 : long.Parse(o17.ToString()),
                Dpgtxtmotrejeicao = o18.ToString(),
                Dpgnumcontrato = o19.ToString(),
                Dpgnumparcela = o20.ToString() == "" ? (long?)null : long.Parse(o20.ToString()),
                Dpgtxtobservacao = o21.ToString(),
                Dpgidcorigem = o22.ToString() == "" ? (long?)null : long.Parse(o22.ToString()),
                Dpgsitsituacao = o23.ToString() == "" ? (long?)null : long.Parse(o23.ToString()),
                Dpgidctipliquid = o24.ToString() == "" ? (long?)null : long.Parse(o24.ToString()),
                Dpgvalacresmora = o25.ToString() == "" ? (decimal?)null : decimal.Parse(o25.ToString()),
                Dpgvalacresmulta = o26.ToString() == "" ? (decimal?)null : decimal.Parse(o26.ToString()),
                Dpgvaldescmora = o27.ToString() == "" ? (decimal?)null : decimal.Parse(o27.ToString()),
                Dpgvaldescmulta = o28.ToString() == "" ? (decimal?)null : decimal.Parse(o28.ToString()),
                Dpgvaldiferenca = o29.ToString() == "" ? (decimal?)null : decimal.Parse(o29.ToString()),
                Dpgvalpago = o30.ToString() == "" ? 0 : decimal.Parse(o30.ToString()),
                Dpgvalcorrecpago = o31.ToString() == "" ? (decimal?)null : decimal.Parse(o31.ToString()),
                Dpgvaliofpago = o32.ToString() == "" ? (decimal?)null : decimal.Parse(o32.ToString()),
                Dpgvaljurospago = o33.ToString() == "" ? (decimal?)null : decimal.Parse(o33.ToString()),
                Dpgvalmorapago = o34.ToString() == "" ? (decimal?)null : decimal.Parse(o34.ToString()),
                Dpgvalmultapago = o35.ToString() == "" ? (decimal?)null : decimal.Parse(o35.ToString()),
                Dpgvalprincippago = o36.ToString() == "" ? (decimal?)null : decimal.Parse(o36.ToString()),
                Dpgnumboleto = o37.ToString(),
                Dpgidtorgrecebedor = o38.ToString(),
                Dpgnumnovocontratoext = o39.ToString(),
                Dpgnumvscontratoext = o40.ToString(),
                Dpgcodbancoprest = o41.ToString(),
                Dpgnumagenciaprest = o42.ToString(),
                Dpgnumcontaprest = o43.ToString(),
                Dpgnumdvcontaprest = o44.ToString(),
                Dpgdatestornopgt = DateTime.TryParse(o45.ToString(), out dt) ? dt.Date : (DateTime?)null,
                Dpgidcmodproc = o46.ToString() == "" ? (long?)null : long.Parse(o46.ToString()),
                Dpgdatenviodebito = DateTime.TryParse(o47.ToString(), out dt) ? dt.Date : (DateTime?)null,
                Dpgidtpgtinconsist = o48.ToString() == "" ? (long?)null : long.Parse(o48.ToString()),
                Dpgidtsisorig = o49.ToString() == "" ? (long?)null : long.Parse(o49.ToString()),
                Dpgcodorgaorecebedor = o51.ToString(),
                Dpgcodtipoorgrecebed = o50.ToString(),
                Dpgseqpgtdata = o52.ToString() == "" ? (long?)null : long.Parse(o52.ToString())
            };
            // o6.ToString() == "" ? 0 : long.Parse(o6.ToString());

            #endregion

            return model;
        }

        private static List<OracleParameter> GetParameters(List<C4Model> models)
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
                result.Add(new OracleParameter("inDPGIDTIDENTIFICADOR", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidtidentificador).ToArray()
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
                result.Add(new OracleParameter("inDPGNUMAGENCIA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumagencia).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMCNPJ", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumcnpj).ToArray()
                });
                result.Add(new OracleParameter("inDPGCODBANCO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgcodbanco).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMCONTA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumconta).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDTCRIPAGPARCIAL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidtcripagparcial).ToArray()
                });
                result.Add(new OracleParameter("inDPGDATPAGAMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgdatpagamento).ToArray()
                });
                result.Add(new OracleParameter("inDPGDATVENCPARC", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgdatvencparc).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDCFORMAPAG", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidcformapag).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDTEMPRESA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidtempresa).ToArray()
                });
                result.Add(new OracleParameter("inDPGTXTMOTREJEICAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgtxtmotrejeicao).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMCONTRATO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumcontrato).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMPARCELA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumparcela).ToArray()
                });
                result.Add(new OracleParameter("inDPGTXTOBSERVACAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgtxtobservacao).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDCORIGEM", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidcorigem).ToArray()
                });
                result.Add(new OracleParameter("inDPGSITSITUACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgsitsituacao).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDCTIPLIQUID", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidctipliquid).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALACRESMORA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvalacresmora).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALACRESMULTA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvalacresmulta).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALDESCMORA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvaldescmora).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALDESCMULTA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvaldescmulta).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALDIFERENCA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvaldiferenca).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALPAGO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvalpago).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALCORRECPAGO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvalcorrecpago).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALIOFPAGO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvaliofpago).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALJUROSPAGO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvaljurospago).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALMORAPAGO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvalmorapago).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALMULTAPAGO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvalmultapago).ToArray()
                });
                result.Add(new OracleParameter("inDPGVALPRINCIPPAGO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgvalprincippago).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMBOLETO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumboleto).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDTORGRECEBEDOR", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidtorgrecebedor).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMNOVOCONTRATOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumnovocontratoext).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMVSCONTRATOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumvscontratoext).ToArray()
                });
                result.Add(new OracleParameter("inDPGCODBANCOPREST", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgcodbancoprest).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMAGENCIAPREST", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumagenciaprest).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMCONTAPREST", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumcontaprest).ToArray()
                });
                result.Add(new OracleParameter("inDPGNUMDVCONTAPREST", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgnumdvcontaprest).ToArray()
                });
                result.Add(new OracleParameter("inDPGDATESTORNOPGT", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgdatestornopgt).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDCMODPROC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidcmodproc).ToArray()
                });
                result.Add(new OracleParameter("inDPGDATENVIODEBITO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgdatenviodebito).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDTPGTINCONSIST", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidtpgtinconsist).ToArray()
                });
                result.Add(new OracleParameter("inDPGIDTSISORIG", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgidtsisorig).ToArray()
                });
                result.Add(new OracleParameter("inDPGCODORGAORECEBEDOR", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgcodorgaorecebedor).ToArray()
                });
                result.Add(new OracleParameter("inDPGCODTIPOORGRECEBED", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgcodtipoorgrecebed).ToArray()
                });
                result.Add(new OracleParameter("inDPGSEQPGTDATA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Dpgseqpgtdata).ToArray()
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
