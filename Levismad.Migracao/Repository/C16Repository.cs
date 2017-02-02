using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C16Repository : BaseRepository<C16Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C16";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C16";
        public C16Repository() : base(SqlOrigem, SqlDestino,57, GetModels, GetParameters)
        {
        }


        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C16");
        }     

        private static C16Model GetModels(List<object> reader, int i)
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
            var o53 = reader[52];
            var o54 = reader[53];
            var o55 = reader[54];
            var o56 = reader[55];
            var o57 = reader[56];







            DateTime dt;

            //long? nullLong = null;
            //decimal? nullDecimal = null;
            var model = new C16Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? (long?) null : long.Parse(o5.ToString()),
                Libidtliberacredorig = i,
                Ctridtcontrole = o7.ToString() == "" ? (long?) null : long.Parse(o7.ToString()),
                Ctridtcontrolelei = o8.ToString() == "" ? (long?) null : long.Parse(o8.ToString()),
                Libdatprocessamento = DateTime.TryParse(o9.ToString(), out dt) ? dt.Date : (DateTime?) null,
                Libcodcentrocusto = o10.ToString(),
                Libcodcliente = o11.ToString(),
                Libnomcliente = o12.ToString(),
                Libtipinscricaocliente = o13.ToString() == "" ? (long?) null : long.Parse(o13.ToString()),
                Libcpfcnpjcliente = o14.ToString(),
                Libdatgeracao = DateTime.TryParse(o15.ToString(), out dt) ? dt.Date : (DateTime?) null,
                Libhorgeracao = o16.ToString(),
                Libdthpagamento = DateTime.TryParse(o17.ToString(), out dt) ? dt.Date : (DateTime?) null,
                Libcodempresa = o18.ToString(),
                Libcnjempresa = o19.ToString(),
                Libnomempresa = o20.ToString(),
                Libtipinscricaoempresa = o21.ToString() == "" ? (long?) null : long.Parse(o21.ToString()),
                Libendenderecoempresa = o22.ToString(),
                Libnumenderecoempresa = o23.ToString() == "" ? (long?) null : long.Parse(o23.ToString()),
                Libdescomplemempresa = o24.ToString(),
                Libdesbairroempresa = o25.ToString(),
                Libdescidadeempresa = o26.ToString(),
                Libcepempresa = o27.ToString() == "" ? (long?) null : long.Parse(o27.ToString()),
                Libestempresa = o28.ToString(),
                Libcodbancocredito = o29.ToString(),
                Libnombancocredito = o30.ToString(),
                Libnumagenciacredito = o31.ToString() == "" ? (long?) null : long.Parse(o31.ToString()),
                Libnumdvagenciacredit = o32.ToString()
            };
            //o6.ToString() == "" ? (long?) null : long.Parse(o6.ToString());
            if (o33.ToString().Length > 10)
            {
                var remove = o33.ToString().Length - 10;
                model.Libnumcontacredito = o33.ToString() == "" ? (long?) null : long.Parse(o33.ToString().Substring(remove));
            }
            else
            {
                model.Libnumcontacredito = o33.ToString() == "" ? (long?) null : long.Parse(o33.ToString());
            }
            model.Libnumdvcontacredit = o34.ToString();
            model.Libtipcontacredito = o35.ToString() == "" ? (long?) null : long.Parse(o35.ToString());
            model.Libcodbancodebito = o36.ToString();
            model.Libnombancodebito = o37.ToString();
            model.Libnumagenciadebito = o38.ToString() == "" ? (long?) null : long.Parse(o38.ToString());
            model.Libnumdvagenciadebito = o39.ToString();
            model.Libnumcontadebito = o40.ToString() == "" ? (long?) null : long.Parse(o40.ToString());
            model.Libnumdvcontadebito = o41.ToString();
            model.Libtipcontadebito = o42.ToString() == "" ? (long?) null : long.Parse(o42.ToString());
            model.Libtippagamento = o43.ToString() == "" ? (long?) null : long.Parse(o43.ToString());
            model.Libvalpagamento = o44.ToString() == "" ? (decimal?) null : decimal.Parse(o44.ToString());
            model.Libnomarquivo = o45.ToString();
            model.Libnumnossonumero = o46.ToString();
            model.Libnumseunumero = o47.ToString();
            model.Libnumremessa = o48.ToString();
            model.Libtiptransferencia = o49.ToString() == "" ? (long?) null : long.Parse(o49.ToString());
            model.Libobsusoempresa = o50.ToString();
            model.Libnumproposta = o51.ToString();
            model.Libdthinicioproposta = DateTime.TryParse(o52.ToString(), out dt) ? dt.Date : (DateTime?)null;
            model.Libdthvencproposta = DateTime.TryParse(o53.ToString(), out dt) ? dt.Date : (DateTime?)null;
            model.Libvalproposta = o54.ToString() == "" ? (decimal?) null : decimal.Parse(o54.ToString());
            model.Libstastatuserro = o55.ToString() == "" ? (long?) null : long.Parse(o55.ToString());
            model.Libsisoriginformacao = o56.ToString() == "" ? (long?) null : long.Parse(o56.ToString());
            model.Libidcprorefin = o57.ToString() == "" ? (long?) null : long.Parse(o57.ToString());




            return model;

            
            #endregion
        }
        private static List<OracleParameter> GetParameters(List<C16Model> models)
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
                result.Add(new OracleParameter("inLIBIDTLIBERACREDORIG", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libidtliberacredorig).ToArray()
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
                result.Add(new OracleParameter("inLIBDATPROCESSAMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libdatprocessamento).ToArray()
                });
                result.Add(new OracleParameter("inLIBCODCENTROCUSTO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libcodcentrocusto).ToArray()
                });
                result.Add(new OracleParameter("inLIBCODCLIENTE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libcodcliente).ToArray()
                });
                result.Add(new OracleParameter("inLIBNOMCLIENTE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnomcliente).ToArray()
                });
                result.Add(new OracleParameter("inLIBTIPINSCRICAOCLIENTE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libtipinscricaocliente).ToArray()
                });
                result.Add(new OracleParameter("inLIBCPFCNPJCLIENTE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libcpfcnpjcliente).ToArray()
                });
                result.Add(new OracleParameter("inLIBDATGERACAO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libdatgeracao).ToArray()
                });
                result.Add(new OracleParameter("inLIBHORGERACAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libhorgeracao).ToArray()
                });
                result.Add(new OracleParameter("inLIBDTHPAGAMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libdthpagamento).ToArray()
                });
                result.Add(new OracleParameter("inLIBCODEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libcodempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBCNJEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libcnjempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBNOMEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnomempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBTIPINSCRICAOEMPRESA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libtipinscricaoempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBENDENDERECOEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libendenderecoempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMENDERECOEMPRESA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumenderecoempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBDESCOMPLEMEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libdescomplemempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBDESBAIRROEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libdesbairroempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBDESCIDADEEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libdescidadeempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBCEPEMPRESA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libcepempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBESTEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libestempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBCODBANCOCREDITO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libcodbancocredito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNOMBANCOCREDITO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnombancocredito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMAGENCIACREDITO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumagenciacredito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMDVAGENCIACREDIT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumdvagenciacredit).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMCONTACREDITO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumcontacredito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMDVCONTACREDIT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumdvcontacredit).ToArray()
                });
                result.Add(new OracleParameter("inLIBTIPCONTACREDITO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libtipcontacredito).ToArray()
                });
                result.Add(new OracleParameter("inLIBCODBANCODEBITO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libcodbancodebito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNOMBANCODEBITO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnombancodebito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMAGENCIADEBITO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumagenciadebito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMDVAGENCIADEBITO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumdvagenciadebito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMCONTADEBITO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumcontadebito).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMDVCONTADEBITO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumdvcontadebito).ToArray()
                });
                result.Add(new OracleParameter("inLIBTIPCONTADEBITO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libtipcontadebito).ToArray()
                });
                result.Add(new OracleParameter("inLIBTIPPAGAMENTO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libtippagamento).ToArray()
                });
                result.Add(new OracleParameter("inLIBVALPAGAMENTO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libvalpagamento).ToArray()
                });
                result.Add(new OracleParameter("inLIBNOMARQUIVO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnomarquivo).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMNOSSONUMERO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumnossonumero).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMSEUNUMERO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumseunumero).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMREMESSA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumremessa).ToArray()
                });
                result.Add(new OracleParameter("inLIBTIPTRANSFERENCIA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libtiptransferencia).ToArray()
                });
                result.Add(new OracleParameter("inLIBOBSUSOEMPRESA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libobsusoempresa).ToArray()
                });
                result.Add(new OracleParameter("inLIBNUMPROPOSTA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libnumproposta).ToArray()
                });
                result.Add(new OracleParameter("inLIBDTHINICIOPROPOSTA", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libdthinicioproposta).ToArray()
                });
                result.Add(new OracleParameter("inLIBDTHVENCPROPOSTA", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libdthvencproposta).ToArray()
                });
                result.Add(new OracleParameter("inLIBVALPROPOSTA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libvalproposta).ToArray()
                });
                result.Add(new OracleParameter("inLIBSTASTATUSERRO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libstastatuserro).ToArray()
                });
                result.Add(new OracleParameter("inLIBSISORIGINFORMACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libsisoriginformacao).ToArray()
                });
                result.Add(new OracleParameter("inLIBIDCPROREFIN", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Libidcprorefin).ToArray()
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