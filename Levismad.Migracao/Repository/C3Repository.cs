using System;
using System.Collections.Generic;
using System.Linq;
using Levismad.Model;
using Oracle.ManagedDataAccess.Client;

namespace Levismad.Repository
{
    public class C3Repository : BaseRepository<C3Model>
    {
        private const string SqlOrigem = "Levismad.ComandoSQLOrigem.C3";
        private const string SqlDestino = "Levismad.ComandoSQLDestino.C3";


        public C3Repository() : base(SqlOrigem, SqlDestino, 237, GetModels, GetParameters)
        {
        }


        public void EfetuarCarga()
        {
            EfetuarCargaDefault("C3");
        }

        private static C3Model GetModels(List<object> reader, int i)
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
            var o58 = reader[57];
            var o59 = reader[58];
            var o60 = reader[59];
            var o61 = reader[60];
            var o62 = reader[61];
            var o63 = reader[62];
            var o64 = reader[63];
            var o65 = reader[64];
            var o66 = reader[65];
            var o67 = reader[66];
            var o68 = reader[67];
            var o69 = reader[68];
            var o70 = reader[69];
            var o71 = reader[70];
            var o72 = reader[71];
            var o73 = reader[72];
            var o74 = reader[73];
            var o75 = reader[74];
            var o76 = reader[75];
            var o77 = reader[76];
            var o78 = reader[77];
            var o79 = reader[78];
            var o80 = reader[79];
            var o81 = reader[80];
            var o82 = reader[81];
            var o83 = reader[82];
            var o84 = reader[83];
            var o85 = reader[84];
            var o86 = reader[85];
            var o87 = reader[86];
            var o88 = reader[87];
            var o89 = reader[88];
            var o90 = reader[89];
            var o91 = reader[90];
            var o92 = reader[91];
            var o93 = reader[92];
            var o94 = reader[93];
            var o95 = reader[94];
            var o96 = reader[95];
            var o97 = reader[96];
            var o98 = reader[97];
            var o99 = reader[98];
            var o100 = reader[99];
            var o101 = reader[100];
            var o102 = reader[101];
            var o103 = reader[102];
            var o104 = reader[103];
            var o105 = reader[104];
            var o106 = reader[105];
            var o107 = reader[106];
            var o108 = reader[107];
            var o109 = reader[108];
            var o110 = reader[109];
            var o111 = reader[110];
            var o112 = reader[111];
            var o113 = reader[112];
            var o114 = reader[113];
            var o115 = reader[114];
            var o116 = reader[115];
            var o117 = reader[116];
            var o118 = reader[117];
            var o119 = reader[118];
            var o120 = reader[119];
            var o121 = reader[120];
            var o122 = reader[121];
            var o123 = reader[122];
            var o124 = reader[123];
            var o125 = reader[124];
            var o126 = reader[125];
            var o127 = reader[126];
            var o128 = reader[127];
            var o129 = reader[128];
            var o130 = reader[129];
            var o131 = reader[130];
            var o132 = reader[131];
            var o133 = reader[132];
            var o134 = reader[133];
            var o135 = reader[134];
            var o136 = reader[135];
            var o137 = reader[136];
            var o138 = reader[137];
            var o139 = reader[138];
            var o140 = reader[139];
            var o141 = reader[140];
            var o142 = reader[141];
            var o143 = reader[142];
            var o144 = reader[143];
            var o145 = reader[144];
            var o146 = reader[145];
            var o147 = reader[146];
            var o148 = reader[147];
            var o149 = reader[148];
            var o150 = reader[149];
            var o151 = reader[150];
            var o152 = reader[151];
            var o153 = reader[152];
            var o154 = reader[153];
            var o155 = reader[154];
            var o156 = reader[155];
            var o157 = reader[156];
            var o158 = reader[157];
            var o159 = reader[158];
            var o160 = reader[159];
            var o161 = reader[160];
            var o162 = reader[161];
            var o163 = reader[162];
            var o164 = reader[163];
            var o165 = reader[164];
            var o166 = reader[165];
            var o167 = reader[166];
            var o168 = reader[167];
            var o169 = reader[168];
            var o170 = reader[169];
            var o171 = reader[170];
            var o172 = reader[171];
            var o173 = reader[172];
            var o174 = reader[173];
            var o175 = reader[174];
            var o176 = reader[175];
            var o177 = reader[176];
            var o178 = reader[177];
            var o179 = reader[178];
            var o180 = reader[179];
            var o181 = reader[180];
            var o182 = reader[181];
            var o183 = reader[182];
            var o184 = reader[183];
            var o185 = reader[184];
            var o186 = reader[185];
            var o187 = reader[186];
            var o188 = reader[187];
            var o189 = reader[188];
            var o190 = reader[189];
            var o191 = reader[190];
            var o192 = reader[191];
            var o193 = reader[192];
            var o194 = reader[193];
            var o195 = reader[194];
            var o196 = reader[195];
            var o197 = reader[196];
            var o198 = reader[197];
            var o199 = reader[198];
            var o200 = reader[199];
            var o201 = reader[200];
            var o202 = reader[201];
            var o203 = reader[202];
            var o204 = reader[203];
            var o205 = reader[204];
            var o206 = reader[205];
            var o207 = reader[206];
            var o208 = reader[207];
            var o209 = reader[208];
            var o210 = reader[209];
            var o211 = reader[210];
            var o212 = reader[211];
            var o213 = reader[212];
            var o214 = reader[213];
            var o215 = reader[214];
            var o216 = reader[215];
            var o217 = reader[216];
            var o218 = reader[217];
            var o219 = reader[218];
            var o220 = reader[219];
            var o221 = reader[220];
            var o222 = reader[221];
            var o223 = reader[222];
            var o224 = reader[223];
            var o225 = reader[224];
            var o226 = reader[225];
            var o227 = reader[226];
            var o228 = reader[227];
            var o229 = reader[228];
            var o230 = reader[229];
            var o231 = reader[230];
            var o232 = reader[231];
            var o233 = reader[232];
            var o234 = reader[233];
            var o235 = reader[234];
            var o236 = reader[235];
            var o237 = reader[236];


            DateTime dt;
            var proposta = new C3Model
            {
                Hdrdathor = o1.ToString(),
                Hdrcodusu = o2.ToString(),
                Hdrcodetc = o3.ToString(),
                Hdrcodpgr = o4.ToString(),
                Hdrcodver = o5.ToString() == "" ? 0 : long.Parse(o5.ToString()),
                Apcidtidentificador = i,
                Apccodempresa = o7.ToString() == "" ? 0 : long.Parse(o7.ToString()),
                Apcnumnumeroproposta = o8.ToString(),
                Apcnumnumerosimulacao = o9.ToString(),
                Apcnumnumpropsistext = o10.ToString(),
                Apcvrsversaoproposta = o11.ToString() == "" ? 0 : long.Parse(o11.ToString()),
                Apcvrsversaopropext = o12.ToString(),
                Apcnomclienteproposta = o13.ToString() == "" ? 0 : long.Parse(o13.ToString()),
                Apccodagenciaexterna = o14.ToString(),
                Apccodlojaexterna = o15.ToString(),
                Apcvalnivelrisco = o16.ToString() == "" ? 0 : long.Parse(o16.ToString()),
                Apcvalnivelriscoatual = o17.ToString() == "" ? 0 : long.Parse(o17.ToString()),
                Apccodprodcredito = o18.ToString() == "" ? 0 : long.Parse(o18.ToString()),
                Apcdatcriacaoprop = DateTime.TryParse(o19.ToString(), out dt) ? dt : (DateTime?) null,
                Apcdesusuariocriacao = o20.ToString(),
                Apcdatinicioproposta = DateTime.TryParse(o21.ToString(), out dt) ? dt : (DateTime?) null,
                Apcvalsolicitado = o22.ToString() == "" ? 0 : decimal.Parse(o22.ToString()),
                Apcvalfinanciado = o23.ToString() == "" ? 0 : decimal.Parse(o23.ToString()),
                Apcvalliquidoliberado = o24.ToString() == "" ? 0 : decimal.Parse(o24.ToString()),
                Apcvaliof = o25.ToString() == "" ? 0 : decimal.Parse(o25.ToString()),
                Apcvalimpostorenda = o26.ToString() == "" ? (decimal?) null : decimal.Parse(o26.ToString()),
                Apcidcefetuacalcmarc = o27.ToString() == "" ? 0 : long.Parse(o27.ToString()),
                Apcidcefetuacontabmar = o28.ToString() == "" ? 0 : long.Parse(o28.ToString()),
                Apcidcutilizcurvamarc = o29.ToString() == "" ? 0 : long.Parse(o29.ToString()),
                Apcpcttaxalibortjfpe = o30.ToString() == "" ? (decimal?) null : decimal.Parse(o30.ToString()),
                Apccodindicelibortjfp = o31.ToString(),
                Apcpcttaxjurencargcus = o32.ToString() == "" ? (decimal?) null : decimal.Parse(o32.ToString()),
                Apcpertaxjurencargcus = o33.ToString() == "" ? (long?) null : long.Parse(o33.ToString()),
                Apccodindicecorrencar = o34.ToString(),
                Apcpctatuacaoindencar = o35.ToString() == "" ? (decimal?) null : decimal.Parse(o35.ToString()),
                Apcdesareacobranca = o36.ToString(),
                Apcdesareaprovedora = o37.ToString(),
                Apcdesarearesponsavel = o38.ToString(),
                Apcpctcomissaogerente = o39.ToString() == "" ? (decimal?) null : decimal.Parse(o39.ToString()),
                Apcdesdomiciobancario = o40.ToString(),
                Apcdesreceberdombanc = o41.ToString() == "" ? (decimal?) null : decimal.Parse(o41.ToString()),
                Apcdescentrocustoext = o42.ToString(),
                Apcdesareamesabase = o43.ToString(),
                Apcdesareacarteiraneg = o44.ToString(),
                Apcdesarearespproduto = o45.ToString(),
                Apcpcttaxatransferenc = o46.ToString() == "" ? (decimal?) null : decimal.Parse(o46.ToString()),
                Apcdesarearespfunding = o47.ToString(),
                Apcdesindicesec = o48.ToString(),
                Apcpctatuindicesec = o49.ToString() == "" ? (decimal?) null : decimal.Parse(o49.ToString()),
                Apcidcindiceatevencim = o50.ToString() == "" ? (long?) null : long.Parse(o50.ToString()),
                Apcdatverificacao = DateTime.TryParse(o51.ToString(), out dt) ? dt : (DateTime?) null,
                Apcpcttaxacomparanual = o52.ToString() == "" ? (decimal?) null : decimal.Parse(o52.ToString()),
                Apcpcttaxa360Sdesc = o53.ToString() == "" ? (decimal?) null : decimal.Parse(o53.ToString()),
                Apcpctcusto360Sdesc = o54.ToString() == "" ? (decimal?) null : decimal.Parse(o54.ToString()),
                Apcpctcustopcional = o55.ToString() == "" ? (decimal?) null : decimal.Parse(o55.ToString()),
                Apccndcomparacao = o56.ToString(),
                Apcidcsatisfmercado = o57.ToString() == "" ? 0 : long.Parse(o57.ToString()),
                Apcdatliberacaorecurs = DateTime.TryParse(o58.ToString(), out dt) ? dt : (DateTime?) null,
                Apccodformalibrecurso = o59.ToString(),
                Apccodcontacorrlibint = o60.ToString(),
                Apccodcontacorrlibext = o61.ToString(),
                Apccodformarecebrecur = o62.ToString(),
                Apccodctacorrrecebint = o63.ToString(),
                Apccodctacorrrecebext = o64.ToString(),
                Apcidcjurosantecipado = o65.ToString() == "" ? 0 : long.Parse(o65.ToString()),
                Apcvalcotinicindcoren = o66.ToString() == "" ? (decimal?) null : decimal.Parse(o66.ToString()),
                Apcpctcobrancajuros = o67.ToString(),
                Apcpcttaxajuros = o68.ToString() == "" ? 0 : decimal.Parse(o68.ToString()),
                Apcpertaxajuros = o69.ToString(),
                Apcidtindice = o70.ToString(),
                Apcpctatuindice = o71.ToString() == "" ? (decimal?) null : decimal.Parse(o71.ToString()),
                Apcdessituacao = o72.ToString(),
                Apcvalfluxoforparcela = o73.ToString(),
                Apcdatemissfluxform = DateTime.TryParse(o74.ToString(), out dt) ? dt : (DateTime?) null,
                Apcdatvenctofluxform = DateTime.TryParse(o75.ToString(), out dt) ? dt : (DateTime?) null,
                Apcidcfluxocomposto = o76.ToString() == "" ? 0 : long.Parse(o76.ToString()),
                Apcdatprimparccarenc = DateTime.TryParse(o77.ToString(), out dt) ? dt : (DateTime?) null,
                Apcqtdparcelascarenc = o78.ToString() == "" ? (long?) null : long.Parse(o78.ToString()),
                Apcvalvenctopadrao = o79.ToString() == "" ? (decimal?) null : decimal.Parse(o79.ToString()),
                Apcqtdparcelasmin = o80.ToString() == "" ? (long?) null : long.Parse(o80.ToString()),
                Apcqrdparcelasmax = o81.ToString() == "" ? (long?) null : long.Parse(o81.ToString()),
                Apcdiaanivervencto = o82.ToString() == "" ? (long?) null : long.Parse(o82.ToString()),
                Apcvalformacaoautflux = o83.ToString(),
                Apctipcalculojuros = o84.ToString(),
                Apcsitfluxoparcela = o85.ToString(),
                Apcidcbascaculojuros = o86.ToString(),
                Apcidcbascaculocorre = o87.ToString(),
                Apcidcformcostparcela = o88.ToString(),
                Apcidctipoprice = o89.ToString(),
                Apcidcregu30Dias = o90.ToString() == "" ? 0 : long.Parse(o90.ToString()),
                Apcidcvencdiasuteis = o91.ToString() == "" ? 0 : long.Parse(o91.ToString()),
                Apcidcmultiplalibera = o92.ToString() == "" ? 0 : long.Parse(o92.ToString()),
                Apcnumperiodamortiza = o93.ToString() == "" ? 0 : long.Parse(o93.ToString()),
                Apcundperiodamortiza = o94.ToString(),
                Apcnumperiodcarencia = o95.ToString() == "" ? (long?) null : long.Parse(o95.ToString()),
                Apcundperiodcarencia = o96.ToString(),
                Apcidcvencpenultdia = o97.ToString() == "" ? 0 : long.Parse(o97.ToString()),
                Apcidcgeraparcela = o98.ToString() == "" ? 0 : long.Parse(o98.ToString()),
                Apcidtgerente = o99.ToString(),
                Apcpctmaxiofacobrar = o100.ToString() == "" ? 0 : decimal.Parse(o100.ToString()),
                Apcvalmaxiofacobrar = o101.ToString() == "" ? 0 : decimal.Parse(o101.ToString()),
                Apcidccobraioflib = o102.ToString() == "" ? 0 : long.Parse(o102.ToString()),
                Apcidccobraioflibadic = o103.ToString() == "" ? 0 : long.Parse(o103.ToString()),
                Apcidccobraioflibfin = o104.ToString() == "" ? 0 : long.Parse(o104.ToString()),
                Apcidccobraiofatraso = o105.ToString() == "" ? 0 : long.Parse(o105.ToString()),
                Apcidccobraiofatradc = o106.ToString() == "" ? 0 : long.Parse(o106.ToString()),
                Apcidctipcobiofadic = o107.ToString() == "" ? 0 : long.Parse(o107.ToString()),
                Apcpctimpostoir = o108.ToString() == "" ? (decimal?) null : decimal.Parse(o108.ToString()),
                Apcvalimpostoir = o109.ToString() == "" ? (decimal?) null : decimal.Parse(o109.ToString()),
                Apcidctarifafinan = o110.ToString() == "" ? 0 : long.Parse(o110.ToString()),
                Apcidtendereco = o111.ToString(),
                Apcpcttaxajurosm = o112.ToString() == "" ? (decimal?) null : decimal.Parse(o112.ToString()),
                Apcpertaxajurosm = o113.ToString(),
                Apcidtindicem = o114.ToString(),
                Apcpctatuindicem = o115.ToString() == "" ? (decimal?) null : decimal.Parse(o115.ToString()),
                Apcpcttaxajurosr = o116.ToString() == "" ? (decimal?) null : decimal.Parse(o116.ToString()),
                Apcpertaxajurosr = o117.ToString(),
                Apcidtindidtindicer = o118.ToString(),
                Apcpctindcorvencidos = o119.ToString() == "" ? (decimal?) null : decimal.Parse(o119.ToString()),
                Apcpctpvcpcttaxamulta = o120.ToString() == "" ? (decimal?) null : decimal.Parse(o120.ToString()),
                Apcidcpvcidcbasecalc = o121.ToString(),
                Apcnumdiascarenmulta = o122.ToString() == "" ? (long?) null : long.Parse(o122.ToString()),
                Apcvalgrupoproduto = o123.ToString() == "" ? 0 : long.Parse(o123.ToString()),
                Apcpctcetano = o124.ToString() == "" ? 0 : decimal.Parse(o124.ToString()),
                Apcpctcetmes = o125.ToString() == "" ? 0 : decimal.Parse(o125.ToString()),
                Apcidcemefetivacao = o126.ToString() == "" ? 0 : long.Parse(o126.ToString()),
                Apcdesbaccodbanco = o127.ToString(),
                Apcpctadquirido = o128.ToString() == "" ? (decimal?) null : decimal.Parse(o128.ToString()),
                Apcnumdocorig = o129.ToString(),
                Apcidccoobriga = o130.ToString() == "" ? (long?) null : long.Parse(o130.ToString()),
                Apcnumpropostafianca = o131.ToString(),
                Apcvrspropostafianca = o132.ToString() == "" ? (long?) null : long.Parse(o132.ToString()),
                Apccodemppropfianca = o133.ToString() == "" ? (long?) null : long.Parse(o133.ToString()),
                Apcnumpropostaext = o134.ToString() == "" ? (long?) null : long.Parse(o134.ToString()),
                Apcnumcetip = o135.ToString(),
                Apcidccobramutuo = o136.ToString() == "" ? (long?) null : long.Parse(o136.ToString()),
                Apcidccalccomissao = o137.ToString() == "" ? (long?) null : long.Parse(o137.ToString()),
                Apccodcredorext = o138.ToString(),
                Apcdatvencimento = DateTime.TryParse(o139.ToString(), out dt) ? dt : (DateTime?) null,
                Apcvaliniindice = o140.ToString() == "" ? (decimal?) null : decimal.Parse(o140.ToString()),
                Apccndcobrancajuros = o141.ToString(),
                Apcpcttaxajuros1 = o142.ToString() == "" ? (decimal?) null : decimal.Parse(o142.ToString()),
                Apcpertaxajuros1 = o143.ToString() == "" ? (long?) null : long.Parse(o143.ToString()),
                Apcidtindicefianca = o144.ToString(),
                Apcpctatuindice1 = o145.ToString() == "" ? (decimal?) null : decimal.Parse(o145.ToString()),
                Apcidtcalccomissao = o146.ToString(),
                Apcidtmodelocarta = o147.ToString(),
                Apcdatocorrencia = DateTime.TryParse(o148.ToString(), out dt) ? dt : (DateTime?) null,
                Apcdesnomeocorrencia = o149.ToString(),
                Apcidcobjetofianca = o150.ToString() == "" ? (long?) null : long.Parse(o150.ToString()),
                Apcdesocorrencia = o151.ToString(),
                Apcpctcomissao = o152.ToString() == "" ? (decimal?) null : decimal.Parse(o152.ToString()),
                Apcidttipofianca = o153.ToString(),
                Apcvalcomissao = o154.ToString() == "" ? (decimal?) null : decimal.Parse(o154.ToString()),
                Apcidcvendiautil = o155.ToString() == "" ? (long?) null : long.Parse(o155.ToString()),
                Apccodpropostapassivo = o156.ToString(),
                Apcvrspropostapassivo = o157.ToString() == "" ? (long?) null : long.Parse(o157.ToString()),
                Apcdesempproppassivo = o158.ToString() == "" ? (long?) null : long.Parse(o158.ToString()),
                Apcpctfatcaptjlppass = o159.ToString() == "" ? (decimal?) null : decimal.Parse(o159.ToString()),
                Apcdatemissproppassiv = DateTime.TryParse(o160.ToString(), out dt) ? dt : (DateTime?) null,
                Apcpctcomssreppassiv = o161.ToString() == "" ? (decimal?) null : decimal.Parse(o161.ToString()),
                Apcpcttaxinterfinpass = o162.ToString() == "" ? (decimal?) null : decimal.Parse(o162.ToString()),
                Apcpcttaxaliborpassiv = o163.ToString() == "" ? (decimal?) null : decimal.Parse(o163.ToString()),
                Apcindindliborpassivo = o164.ToString(),
                Apcalqimprendapassivo = o165.ToString() == "" ? (decimal?) null : decimal.Parse(o165.ToString()),
                Apcpctindimprendapass = o166.ToString(),
                Apcalqimprendarepasse = o167.ToString() == "" ? (decimal?) null : decimal.Parse(o167.ToString()),
                Apcidccomisantrepasse = o168.ToString() == "" ? (long?) null : long.Parse(o168.ToString()),
                Apcindindicerepasse = o169.ToString(),
                Apcpctanualliborrepas = o170.ToString() == "" ? (decimal?) null : decimal.Parse(o170.ToString()),
                Apcpctanualifcrepasse = o171.ToString() == "" ? (decimal?) null : decimal.Parse(o171.ToString()),
                Apcpctcomisrepasse = o172.ToString() == "" ? (decimal?) null : decimal.Parse(o172.ToString()),
                Apcperindliborrepasse = o173.ToString() == "" ? (long?) null : long.Parse(o173.ToString()),
                Apccodproprepasseext = o174.ToString(),
                Apcvrsproprepasseext = o175.ToString() == "" ? (long?) null : long.Parse(o175.ToString()),
                Apcdesempproprepassex = o176.ToString() == "" ? (long?) null : long.Parse(o176.ToString()),
                Apcidtpropostamaelast = o177.ToString() == "" ? (long?) null : long.Parse(o177.ToString()),
                Apcidcformaequalizatx = o178.ToString(),
                Apcpctnotafiscallastr = o179.ToString() == "" ? (decimal?) null : decimal.Parse(o179.ToString()),
                Apcpcttaxafiancalastr = o180.ToString() == "" ? (decimal?) null : decimal.Parse(o180.ToString()),
                Apcvalcofinscdci = o181.ToString() == "" ? (decimal?) null : decimal.Parse(o181.ToString()),
                Apcvalcsslcdci = o182.ToString() == "" ? (decimal?) null : decimal.Parse(o182.ToString()),
                Apcvaliofcdci = o183.ToString() == "" ? (decimal?) null : decimal.Parse(o183.ToString()),
                Apcvalircdci = o184.ToString() == "" ? (decimal?) null : decimal.Parse(o184.ToString()),
                Apcvalnotafiscal = o185.ToString() == "" ? (decimal?) null : decimal.Parse(o185.ToString()),
                Apcvalpiscdci = o186.ToString() == "" ? (decimal?) null : decimal.Parse(o186.ToString()),
                Ctridtcontrolelei = o187.ToString() == "" ? 0 : long.Parse(o187.ToString()),
                Ctridtcontrolegra = o188.ToString() == "" ? 0 : long.Parse(o188.ToString()),
                Apcdatprimparcamort = DateTime.TryParse(o189.ToString(), out dt) ? dt : (DateTime?) null,
                Apcqtdparcelasamort = o190.ToString() == "" ? 0 : long.Parse(o190.ToString()),
                Apcidctipopessoaiof = o191.ToString(),
                Apcvaltaxacartorio = o192.ToString() == "" ? 0 : decimal.Parse(o192.ToString()),
                Apcdesformacobencarg = o193.ToString() == "" ? 0 : long.Parse(o193.ToString()),
                Apcidcdatcotmoedaconv = o194.ToString() == "" ? (long?) null : long.Parse(o194.ToString()),
                Apcvaltac = o195.ToString() == "" ? 0 : decimal.Parse(o195.ToString()),
                Apccodbancolibextern = o196.ToString() == "" ? (long?) null : long.Parse(o196.ToString()),
                Apccodagenclibextern = o197.ToString(),
                Apcvalflat = o198.ToString() == "" ? 0 : decimal.Parse(o198.ToString()),
                Apccodfornecedor = o199.ToString() == "" ? 0 : long.Parse(o199.ToString()),
                Apcvalcontrmoedaestr = o200.ToString() == "" ? 0 : decimal.Parse(o200.ToString()),
                Apccodagenclibinterna = o201.ToString() == "" ? (long?) null : long.Parse(o201.ToString()),
                Apcdgvccliberacaoint = o202.ToString(),
                Apcdgvccliberacaoext = o203.ToString(),
                Apcvalsomatorioiofadc = o204.ToString() == "" ? (decimal?) null : decimal.Parse(o204.ToString()),
                Apcvaltaxaalienacao = o205.ToString() == "" ? 0 : decimal.Parse(o205.ToString()),
                Apcidccobrancatac = o206.ToString() == "" ? 0 : long.Parse(o206.ToString()),
                Apcidctacfinanciada = o207.ToString() == "" ? 0 : long.Parse(o207.ToString()),
                Apccodtiptitulo = o208.ToString(),
                Apcdestiptitulo = o209.ToString(),
                Apctipoperacao = o210.ToString(),
                Apcnumgrpsgl = o211.ToString() == "" ? (long?) null : long.Parse(o211.ToString()),
                Apcdatprocessamento = DateTime.TryParse(o212.ToString(), out dt) ? dt : (DateTime?) null,
                Apcpcttaxajuroscontab = o213.ToString() == "" ? (decimal?) null : decimal.Parse(o213.ToString()),
                Apcpctatuindicecontab = o214.ToString() == "" ? (decimal?) null : decimal.Parse(o214.ToString()),
                Apcpertaxajuroscontab = o215.ToString() == "" ? (long?) null : long.Parse(o215.ToString()),
                Apcidtindicecontab = o216.ToString() == "" ? (long?) null : long.Parse(o216.ToString()),
                Apcidccalcmoratorio = o217.ToString() == "" ? 0 : long.Parse(o217.ToString()),
                Apcidccalcremunerator = o218.ToString() == "" ? 0 : long.Parse(o218.ToString()),
                Apcidccalccontabeis = o219.ToString() == "" ? 0 : long.Parse(o219.ToString()),
                Apcidccalccusto = o220.ToString() == "" ? 0 : long.Parse(o220.ToString()),
                Apcpcttaxajuroscusto = o221.ToString() == "" ? (decimal?) null : decimal.Parse(o221.ToString()),
                Apcpctatuindicecusto = o222.ToString() == "" ? (decimal?) null : decimal.Parse(o222.ToString()),
                Apcpertaxajuroscusto = o223.ToString() == "" ? (long?) null : long.Parse(o223.ToString()),
                Apcidtindicecusto = o224.ToString() == "" ? (long?) null : long.Parse(o224.ToString()),
                Apcidcproalterada = o225.ToString() == "" ? 0 : long.Parse(o225.ToString()),
                Apcidcprorenegociada = o226.ToString() == "" ? 0 : long.Parse(o226.ToString()),
                Apcnumprorenegociada = o227.ToString(),
                Apcstastatuserro = o228.ToString() == "" ? (long?) null : long.Parse(o228.ToString()),
                Apcidccompradivida = o229.ToString() == "" ? (long?) null : long.Parse(o229.ToString()),
                Apccodorgaoext = o230.ToString(),
                Apccodsuborgaoext = o231.ToString(),
                Apcidtorigemproposta = o232.ToString() == "" ? 0 : long.Parse(o232.ToString()),
                Apcidcprorefin = o233.ToString() == "" ? 0 : long.Parse(o233.ToString()),
                Apcpcttir = o234.ToString() == "" ? 0 : decimal.Parse(o234.ToString()),
                Apcpcttxequiva = o235.ToString() == "" ? (decimal?) null : decimal.Parse(o235.ToString()),
                Apcdatacancelamento = DateTime.TryParse(o236.ToString(), out dt) ? dt : (DateTime?) null,
                Apccodcontratointerno = o237.ToString() == "" ? 0 : long.Parse(o237.ToString())
            };

            //o6.ToString() == "" ? 0 : long.Parse(o6.ToString());
            //

            #endregion
            return proposta;
        }
        private static List<OracleParameter> GetParameters(List<C3Model> models)
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
                result.Add(new OracleParameter("inAPCIDTIDENTIFICADOR", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtidentificador).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODEMPRESA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodempresa).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMNUMEROPROPOSTA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumnumeroproposta).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMNUMEROSIMULACAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumnumerosimulacao).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMNUMPROPSISTEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumnumpropsistext).ToArray()
                });
                result.Add(new OracleParameter("inAPCVRSVERSAOPROPOSTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvrsversaoproposta).ToArray()
                });
                result.Add(new OracleParameter("inAPCVRSVERSAOPROPEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvrsversaopropext).ToArray()
                });
                result.Add(new OracleParameter("inAPCNOMCLIENTEPROPOSTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnomclienteproposta).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODAGENCIAEXTERNA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodagenciaexterna).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODLOJAEXTERNA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodlojaexterna).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALNIVELRISCO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalnivelrisco).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALNIVELRISCOATUAL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalnivelriscoatual).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODPRODCREDITO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodprodcredito).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATCRIACAOPROP", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatcriacaoprop).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESUSUARIOCRIACAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesusuariocriacao).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATINICIOPROPOSTA", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatinicioproposta).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALSOLICITADO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalsolicitado).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALFINANCIADO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalfinanciado).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALLIQUIDOLIBERADO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalliquidoliberado).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALIOF", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvaliof).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALIMPOSTORENDA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalimpostorenda).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCEFETUACALCMARC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcefetuacalcmarc).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCEFETUACONTABMAR", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcefetuacontabmar).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCUTILIZCURVAMARC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcutilizcurvamarc).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXALIBORTJFPE", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxalibortjfpe).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODINDICELIBORTJFP", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodindicelibortjfp).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXJURENCARGCUS", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxjurencargcus).ToArray()
                });
                result.Add(new OracleParameter("inAPCPERTAXJURENCARGCUS", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpertaxjurencargcus).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODINDICECORRENCAR", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodindicecorrencar).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTATUACAOINDENCAR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctatuacaoindencar).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESAREACOBRANCA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesareacobranca).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESAREAPROVEDORA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesareaprovedora).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESAREARESPONSAVEL", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesarearesponsavel).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCOMISSAOGERENTE", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcomissaogerente).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESDOMICIOBANCARIO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesdomiciobancario).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESRECEBERDOMBANC", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesreceberdombanc).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESCENTROCUSTOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdescentrocustoext).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESAREAMESABASE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesareamesabase).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESAREACARTEIRANEG", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesareacarteiraneg).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESAREARESPPRODUTO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesarearespproduto).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXATRANSFERENC", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxatransferenc).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESAREARESPFUNDING", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesarearespfunding).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESINDICESEC", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesindicesec).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTATUINDICESEC", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctatuindicesec).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCINDICEATEVENCIM", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcindiceatevencim).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATVERIFICACAO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatverificacao).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXACOMPARANUAL", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxacomparanual).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXA360SDESC", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxa360Sdesc).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCUSTO360SDESC", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcusto360Sdesc).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCUSTOPCIONAL", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcustopcional).ToArray()
                });
                result.Add(new OracleParameter("inAPCCNDCOMPARACAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccndcomparacao).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCSATISFMERCADO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcsatisfmercado).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATLIBERACAORECURS", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatliberacaorecurs).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODFORMALIBRECURSO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodformalibrecurso).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODCONTACORRLIBINT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodcontacorrlibint).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODCONTACORRLIBEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodcontacorrlibext).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODFORMARECEBRECUR", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodformarecebrecur).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODCTACORRRECEBINT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodctacorrrecebint).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODCTACORRRECEBEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodctacorrrecebext).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCJUROSANTECIPADO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcjurosantecipado).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALCOTINICINDCOREN", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalcotinicindcoren).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCOBRANCAJUROS", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcobrancajuros).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXAJUROS", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxajuros).ToArray()
                });
                result.Add(new OracleParameter("inAPCPERTAXAJUROS", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpertaxajuros).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTINDICE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtindice).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTATUINDICE", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctatuindice).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESSITUACAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdessituacao).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALFLUXOFORPARCELA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalfluxoforparcela).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATEMISSFLUXFORM", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatemissfluxform).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATVENCTOFLUXFORM", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatvenctofluxform).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCFLUXOCOMPOSTO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcfluxocomposto).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATPRIMPARCCARENC", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatprimparccarenc).ToArray()
                });
                result.Add(new OracleParameter("inAPCQTDPARCELASCARENC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcqtdparcelascarenc).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALVENCTOPADRAO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalvenctopadrao).ToArray()
                });
                result.Add(new OracleParameter("inAPCQTDPARCELASMIN", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcqtdparcelasmin).ToArray()
                });
                result.Add(new OracleParameter("inAPCQRDPARCELASMAX", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcqrdparcelasmax).ToArray()
                });
                result.Add(new OracleParameter("inAPCDIAANIVERVENCTO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdiaanivervencto).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALFORMACAOAUTFLUX", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalformacaoautflux).ToArray()
                });
                result.Add(new OracleParameter("inAPCTIPCALCULOJUROS", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apctipcalculojuros).ToArray()
                });
                result.Add(new OracleParameter("inAPCSITFLUXOPARCELA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcsitfluxoparcela).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCBASCACULOJUROS", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcbascaculojuros).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCBASCACULOCORRE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcbascaculocorre).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCFORMCOSTPARCELA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcformcostparcela).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCTIPOPRICE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidctipoprice).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCREGU30DIAS", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcregu30Dias).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCVENCDIASUTEIS", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcvencdiasuteis).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCMULTIPLALIBERA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcmultiplalibera).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMPERIODAMORTIZA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumperiodamortiza).ToArray()
                });
                result.Add(new OracleParameter("inAPCUNDPERIODAMORTIZA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcundperiodamortiza).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMPERIODCARENCIA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumperiodcarencia).ToArray()
                });
                result.Add(new OracleParameter("inAPCUNDPERIODCARENCIA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcundperiodcarencia).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCVENCPENULTDIA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcvencpenultdia).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCGERAPARCELA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcgeraparcela).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTGERENTE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtgerente).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTMAXIOFACOBRAR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctmaxiofacobrar).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALMAXIOFACOBRAR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalmaxiofacobrar).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOBRAIOFLIB", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccobraioflib).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOBRAIOFLIBADIC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccobraioflibadic).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOBRAIOFLIBFIN", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccobraioflibfin).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOBRAIOFATRASO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccobraiofatraso).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOBRAIOFATRADC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccobraiofatradc).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCTIPCOBIOFADIC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidctipcobiofadic).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTIMPOSTOIR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctimpostoir).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALIMPOSTOIR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalimpostoir).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCTARIFAFINAN", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidctarifafinan).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTENDERECO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtendereco).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXAJUROSM", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxajurosm).ToArray()
                });
                result.Add(new OracleParameter("inAPCPERTAXAJUROSM", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpertaxajurosm).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTINDICEM", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtindicem).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTATUINDICEM", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctatuindicem).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXAJUROSR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxajurosr).ToArray()
                });
                result.Add(new OracleParameter("inAPCPERTAXAJUROSR", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpertaxajurosr).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTINDIDTINDICER", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtindidtindicer).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTINDCORVENCIDOS", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctindcorvencidos).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTPVCPCTTAXAMULTA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctpvcpcttaxamulta).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCPVCIDCBASECALC", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcpvcidcbasecalc).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMDIASCARENMULTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumdiascarenmulta).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALGRUPOPRODUTO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalgrupoproduto).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCETANO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcetano).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCETMES", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcetmes).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCEMEFETIVACAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcemefetivacao).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESBACCODBANCO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesbaccodbanco).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTADQUIRIDO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctadquirido).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMDOCORIG", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumdocorig).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOOBRIGA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccoobriga).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMPROPOSTAFIANCA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumpropostafianca).ToArray()
                });
                result.Add(new OracleParameter("inAPCVRSPROPOSTAFIANCA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvrspropostafianca).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODEMPPROPFIANCA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodemppropfianca).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMPROPOSTAEXT", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumpropostaext).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMCETIP", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumcetip).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOBRAMUTUO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccobramutuo).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCALCCOMISSAO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccalccomissao).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODCREDOREXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodcredorext).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATVENCIMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatvencimento).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALINIINDICE", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvaliniindice).ToArray()
                });
                result.Add(new OracleParameter("inAPCCNDCOBRANCAJUROS", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccndcobrancajuros).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXAJUROS1", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxajuros1).ToArray()
                });
                result.Add(new OracleParameter("inAPCPERTAXAJUROS1", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpertaxajuros1).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTINDICEFIANCA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtindicefianca).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTATUINDICE1", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctatuindice1).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTCALCCOMISSAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtcalccomissao).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTMODELOCARTA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtmodelocarta).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATOCORRENCIA", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatocorrencia).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESNOMEOCORRENCIA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesnomeocorrencia).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCOBJETOFIANCA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcobjetofianca).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESOCORRENCIA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesocorrencia).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCOMISSAO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcomissao).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTTIPOFIANCA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidttipofianca).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALCOMISSAO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalcomissao).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCVENDIAUTIL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcvendiautil).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODPROPOSTAPASSIVO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodpropostapassivo).ToArray()
                });
                result.Add(new OracleParameter("inAPCVRSPROPOSTAPASSIVO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvrspropostapassivo).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESEMPPROPPASSIVO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesempproppassivo).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTFATCAPTJLPPASS", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctfatcaptjlppass).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATEMISSPROPPASSIV", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatemissproppassiv).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCOMSSREPPASSIV", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcomssreppassiv).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXINTERFINPASS", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxinterfinpass).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXALIBORPASSIV", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxaliborpassiv).ToArray()
                });
                result.Add(new OracleParameter("inAPCINDINDLIBORPASSIVO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcindindliborpassivo).ToArray()
                });
                result.Add(new OracleParameter("inAPCALQIMPRENDAPASSIVO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcalqimprendapassivo).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTINDIMPRENDAPASS", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctindimprendapass).ToArray()
                });
                result.Add(new OracleParameter("inAPCALQIMPRENDAREPASSE", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcalqimprendarepasse).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOMISANTREPASSE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccomisantrepasse).ToArray()
                });
                result.Add(new OracleParameter("inAPCINDINDICEREPASSE", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcindindicerepasse).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTANUALLIBORREPAS", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctanualliborrepas).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTANUALIFCREPASSE", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctanualifcrepasse).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTCOMISREPASSE", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctcomisrepasse).ToArray()
                });
                result.Add(new OracleParameter("inAPCPERINDLIBORREPASSE", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcperindliborrepasse).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODPROPREPASSEEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodproprepasseext).ToArray()
                });
                result.Add(new OracleParameter("inAPCVRSPROPREPASSEEXT", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvrsproprepasseext).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESEMPPROPREPASSEX", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesempproprepassex).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTPROPOSTAMAELAST", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtpropostamaelast).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCFORMAEQUALIZATX", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcformaequalizatx).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTNOTAFISCALLASTR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctnotafiscallastr).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXAFIANCALASTR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxafiancalastr).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALCOFINSCDCI", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalcofinscdci).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALCSSLCDCI", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalcsslcdci).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALIOFCDCI", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvaliofcdci).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALIRCDCI", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalircdci).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALNOTAFISCAL", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalnotafiscal).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALPISCDCI", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalpiscdci).ToArray()
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
                result.Add(new OracleParameter("inAPCDATPRIMPARCAMORT", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatprimparcamort).ToArray()
                });
                result.Add(new OracleParameter("inAPCQTDPARCELASAMORT", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcqtdparcelasamort).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCTIPOPESSOAIOF", OracleDbType.Char)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidctipopessoaiof).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALTAXACARTORIO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvaltaxacartorio).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESFORMACOBENCARG", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdesformacobencarg).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCDATCOTMOEDACONV", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcdatcotmoedaconv).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALTAC", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvaltac).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODBANCOLIBEXTERN", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodbancolibextern).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODAGENCLIBEXTERN", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodagenclibextern).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALFLAT", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalflat).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODFORNECEDOR", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodfornecedor).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALCONTRMOEDAESTR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalcontrmoedaestr).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODAGENCLIBINTERNA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodagenclibinterna).ToArray()
                });
                result.Add(new OracleParameter("inAPCDGVCCLIBERACAOINT", OracleDbType.Char)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdgvccliberacaoint).ToArray()
                });
                result.Add(new OracleParameter("inAPCDGVCCLIBERACAOEXT", OracleDbType.Char)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdgvccliberacaoext).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALSOMATORIOIOFADC", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvalsomatorioiofadc).ToArray()
                });
                result.Add(new OracleParameter("inAPCVALTAXAALIENACAO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcvaltaxaalienacao).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOBRANCATAC", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccobrancatac).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCTACFINANCIADA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidctacfinanciada).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODTIPTITULO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodtiptitulo).ToArray()
                });
                result.Add(new OracleParameter("inAPCDESTIPTITULO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdestiptitulo).ToArray()
                });
                result.Add(new OracleParameter("inAPCTIPOPERACAO", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apctipoperacao).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMGRPSGL", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumgrpsgl).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATPROCESSAMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatprocessamento).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXAJUROSCONTAB", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxajuroscontab).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTATUINDICECONTAB", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctatuindicecontab).ToArray()
                });
                result.Add(new OracleParameter("inAPCPERTAXAJUROSCONTAB", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpertaxajuroscontab).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTINDICECONTAB", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtindicecontab).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCALCMORATORIO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccalcmoratorio).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCALCREMUNERATOR", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccalcremunerator).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCALCCONTABEIS", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccalccontabeis).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCALCCUSTO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccalccusto).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTAXAJUROSCUSTO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttaxajuroscusto).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTATUINDICECUSTO", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpctatuindicecusto).ToArray()
                });
                result.Add(new OracleParameter("inAPCPERTAXAJUROSCUSTO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpertaxajuroscusto).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTINDICECUSTO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtindicecusto).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCPROALTERADA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcproalterada).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCPRORENEGOCIADA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcprorenegociada).ToArray()
                });
                result.Add(new OracleParameter("inAPCNUMPRORENEGOCIADA", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcnumprorenegociada).ToArray()
                });
                result.Add(new OracleParameter("inAPCSTASTATUSERRO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcstastatuserro).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCCOMPRADIVIDA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidccompradivida).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODORGAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodorgaoext).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODSUBORGAOEXT", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodsuborgaoext).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDTORIGEMPROPOSTA", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidtorigemproposta).ToArray()
                });
                result.Add(new OracleParameter("inAPCIDCPROREFIN", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcidcprorefin).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTIR", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttir).ToArray()
                });
                result.Add(new OracleParameter("inAPCPCTTXEQUIVA", OracleDbType.Decimal)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcpcttxequiva).ToArray()
                });
                result.Add(new OracleParameter("inAPCDATACANCELAMENTO", OracleDbType.Date)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apcdatacancelamento).ToArray()
                });
                result.Add(new OracleParameter("inAPCCODCONTRATOINTERNO", OracleDbType.Int64)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Value = models.Select(x => x.Apccodcontratointerno).ToArray()
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
