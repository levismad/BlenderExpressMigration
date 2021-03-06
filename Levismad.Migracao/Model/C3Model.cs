﻿using System;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

	public class C3Model : IModel
    {
        public ValidatorResult Validar()
        {
            var result = new ValidatorResult();
            return result;
        }
        public string Hdrdathor { get; set; }
		public string Hdrcodusu { get; set; }
		public string Hdrcodetc { get; set; }
		public string Hdrcodpgr { get; set; }
		public long Hdrcodver { get; set; }
		public long Apcidtidentificador { get; set; }
		public long Apccodempresa { get; set; }
		public string Apcnumnumeroproposta { get; set; }
		public string Apcnumnumerosimulacao { get; set; }
		public string Apcnumnumpropsistext { get; set; }
		public long Apcvrsversaoproposta { get; set; }
		public string Apcvrsversaopropext { get; set; }
		public long Apcnomclienteproposta { get; set; }
		public string Apccodagenciaexterna { get; set; }
		public string Apccodlojaexterna { get; set; }
		public long Apcvalnivelrisco { get; set; }
		public long Apcvalnivelriscoatual { get; set; }
		public long Apccodprodcredito { get; set; }
		public DateTime? Apcdatcriacaoprop { get; set; }
		public string Apcdesusuariocriacao { get; set; }
		public DateTime? Apcdatinicioproposta { get; set; }
		public decimal Apcvalsolicitado { get; set; }
		public decimal Apcvalfinanciado { get; set; }
		public decimal Apcvalliquidoliberado { get; set; }
		public decimal Apcvaliof { get; set; }
		public decimal? Apcvalimpostorenda { get; set; }
		public long Apcidcefetuacalcmarc { get; set; }
		public long Apcidcefetuacontabmar { get; set; }
		public long Apcidcutilizcurvamarc { get; set; }
		public decimal? Apcpcttaxalibortjfpe { get; set; }
		public string Apccodindicelibortjfp { get; set; }
		public decimal? Apcpcttaxjurencargcus { get; set; }
		public long? Apcpertaxjurencargcus { get; set; }
		public string Apccodindicecorrencar { get; set; }
		public decimal? Apcpctatuacaoindencar { get; set; }
		public string Apcdesareacobranca { get; set; }
		public string Apcdesareaprovedora { get; set; }
		public string Apcdesarearesponsavel { get; set; }
		public decimal? Apcpctcomissaogerente { get; set; }
		public string Apcdesdomiciobancario { get; set; }
		public decimal? Apcdesreceberdombanc { get; set; }
		public string Apcdescentrocustoext { get; set; }
		public string Apcdesareamesabase { get; set; }
		public string Apcdesareacarteiraneg { get; set; }
		public string Apcdesarearespproduto { get; set; }
		public decimal? Apcpcttaxatransferenc { get; set; }
		public string Apcdesarearespfunding { get; set; }
		public string Apcdesindicesec { get; set; }
		public decimal? Apcpctatuindicesec { get; set; }
		public long? Apcidcindiceatevencim { get; set; }
		public DateTime? Apcdatverificacao { get; set; }
		public decimal? Apcpcttaxacomparanual { get; set; }
		public decimal? Apcpcttaxa360Sdesc { get; set; }
		public decimal? Apcpctcusto360Sdesc { get; set; }
		public decimal? Apcpctcustopcional { get; set; }
		public string Apccndcomparacao { get; set; }
		public long Apcidcsatisfmercado { get; set; }
		public DateTime? Apcdatliberacaorecurs { get; set; }
		public string Apccodformalibrecurso { get; set; }
		public string Apccodcontacorrlibint { get; set; }
		public string Apccodcontacorrlibext { get; set; }
		public string Apccodformarecebrecur { get; set; }
		public string Apccodctacorrrecebint { get; set; }
		public string Apccodctacorrrecebext { get; set; }
		public long Apcidcjurosantecipado { get; set; }
		public decimal? Apcvalcotinicindcoren { get; set; }
		public string Apcpctcobrancajuros { get; set; }
		public decimal Apcpcttaxajuros { get; set; }
		public string Apcpertaxajuros { get; set; }
		public string Apcidtindice { get; set; }
		public decimal? Apcpctatuindice { get; set; }
		public string Apcdessituacao { get; set; }
		public string Apcvalfluxoforparcela { get; set; }
		public DateTime? Apcdatemissfluxform { get; set; }
		public DateTime? Apcdatvenctofluxform { get; set; }
		public long Apcidcfluxocomposto { get; set; }
		public DateTime? Apcdatprimparccarenc { get; set; }
		public long? Apcqtdparcelascarenc { get; set; }
		public decimal? Apcvalvenctopadrao { get; set; }
		public long? Apcqtdparcelasmin { get; set; }
		public long? Apcqrdparcelasmax { get; set; }
		public long? Apcdiaanivervencto { get; set; }
		public string Apcvalformacaoautflux { get; set; }
		public string Apctipcalculojuros { get; set; }
		public string Apcsitfluxoparcela { get; set; }
		public string Apcidcbascaculojuros { get; set; }
		public string Apcidcbascaculocorre { get; set; }
		public string Apcidcformcostparcela { get; set; }
		public string Apcidctipoprice { get; set; }
		public long Apcidcregu30Dias { get; set; }
		public long Apcidcvencdiasuteis { get; set; }
		public long Apcidcmultiplalibera { get; set; }
		public long Apcnumperiodamortiza { get; set; }
		public string Apcundperiodamortiza { get; set; }
		public long? Apcnumperiodcarencia { get; set; }
		public string Apcundperiodcarencia { get; set; }
		public long Apcidcvencpenultdia { get; set; }
		public long Apcidcgeraparcela { get; set; }
		public string Apcidtgerente { get; set; }
		public decimal Apcpctmaxiofacobrar { get; set; }
		public decimal Apcvalmaxiofacobrar { get; set; }
		public long Apcidccobraioflib { get; set; }
		public long Apcidccobraioflibadic { get; set; }
		public long Apcidccobraioflibfin { get; set; }
		public long Apcidccobraiofatraso { get; set; }
		public long Apcidccobraiofatradc { get; set; }
		public long Apcidctipcobiofadic { get; set; }
		public decimal? Apcpctimpostoir { get; set; }
		public decimal? Apcvalimpostoir { get; set; }
		public long Apcidctarifafinan { get; set; }
		public string Apcidtendereco { get; set; }
		public decimal? Apcpcttaxajurosm { get; set; }
		public string Apcpertaxajurosm { get; set; }
		public string Apcidtindicem { get; set; }
		public decimal? Apcpctatuindicem { get; set; }
		public decimal? Apcpcttaxajurosr { get; set; }
		public string Apcpertaxajurosr { get; set; }
		public string Apcidtindidtindicer { get; set; }
		public decimal? Apcpctindcorvencidos { get; set; }
		public decimal? Apcpctpvcpcttaxamulta { get; set; }
		public string Apcidcpvcidcbasecalc { get; set; }
		public long? Apcnumdiascarenmulta { get; set; }
		public long Apcvalgrupoproduto { get; set; }
		public decimal Apcpctcetano { get; set; }
		public decimal Apcpctcetmes { get; set; }
		public long Apcidcemefetivacao { get; set; }
		public string Apcdesbaccodbanco { get; set; }
		public decimal? Apcpctadquirido { get; set; }
		public string Apcnumdocorig { get; set; }
		public long? Apcidccoobriga { get; set; }
		public string Apcnumpropostafianca { get; set; }
		public long? Apcvrspropostafianca { get; set; }
		public long? Apccodemppropfianca { get; set; }
		public long? Apcnumpropostaext { get; set; }
		public string Apcnumcetip { get; set; }
		public long? Apcidccobramutuo { get; set; }
		public long? Apcidccalccomissao { get; set; }
		public string Apccodcredorext { get; set; }
		public DateTime? Apcdatvencimento { get; set; }
		public decimal? Apcvaliniindice { get; set; }
		public string Apccndcobrancajuros { get; set; }
		public decimal? Apcpcttaxajuros1 { get; set; }
		public long? Apcpertaxajuros1 { get; set; }
		public string Apcidtindicefianca { get; set; }
		public decimal? Apcpctatuindice1 { get; set; }
		public string Apcidtcalccomissao { get; set; }
		public string Apcidtmodelocarta { get; set; }
		public DateTime? Apcdatocorrencia { get; set; }
		public string Apcdesnomeocorrencia { get; set; }
		public long? Apcidcobjetofianca { get; set; }
		public string Apcdesocorrencia { get; set; }
		public decimal? Apcpctcomissao { get; set; }
		public string Apcidttipofianca { get; set; }
		public decimal? Apcvalcomissao { get; set; }
		public long? Apcidcvendiautil { get; set; }
		public string Apccodpropostapassivo { get; set; }
		public long? Apcvrspropostapassivo { get; set; }
		public long? Apcdesempproppassivo { get; set; }
		public decimal? Apcpctfatcaptjlppass { get; set; }
		public DateTime? Apcdatemissproppassiv { get; set; }
		public decimal? Apcpctcomssreppassiv { get; set; }
		public decimal? Apcpcttaxinterfinpass { get; set; }
		public decimal? Apcpcttaxaliborpassiv { get; set; }
		public string Apcindindliborpassivo { get; set; }
		public decimal? Apcalqimprendapassivo { get; set; }
		public string Apcpctindimprendapass { get; set; }
		public decimal? Apcalqimprendarepasse { get; set; }
		public long? Apcidccomisantrepasse { get; set; }
		public string Apcindindicerepasse { get; set; }
		public decimal? Apcpctanualliborrepas { get; set; }
		public decimal? Apcpctanualifcrepasse { get; set; }
		public decimal? Apcpctcomisrepasse { get; set; }
		public long? Apcperindliborrepasse { get; set; }
		public string Apccodproprepasseext { get; set; }
		public long? Apcvrsproprepasseext { get; set; }
		public long? Apcdesempproprepassex { get; set; }
		public long? Apcidtpropostamaelast { get; set; }
		public string Apcidcformaequalizatx { get; set; }
		public decimal? Apcpctnotafiscallastr { get; set; }
		public decimal? Apcpcttaxafiancalastr { get; set; }
		public decimal? Apcvalcofinscdci { get; set; }
		public decimal? Apcvalcsslcdci { get; set; }
		public decimal? Apcvaliofcdci { get; set; }
		public decimal? Apcvalircdci { get; set; }
		public decimal? Apcvalnotafiscal { get; set; }
		public decimal? Apcvalpiscdci { get; set; }
		public long Ctridtcontrolelei { get; set; }
		public long Ctridtcontrolegra { get; set; }
		public DateTime? Apcdatprimparcamort { get; set; }
		public long Apcqtdparcelasamort { get; set; }
		public string Apcidctipopessoaiof { get; set; }
		public decimal Apcvaltaxacartorio { get; set; }
		public long Apcdesformacobencarg { get; set; }
		public long? Apcidcdatcotmoedaconv { get; set; }
		public decimal Apcvaltac { get; set; }
		public long? Apccodbancolibextern { get; set; }
		public string Apccodagenclibextern { get; set; }
		public decimal Apcvalflat { get; set; }
		public long Apccodfornecedor { get; set; }
		public decimal Apcvalcontrmoedaestr { get; set; }
		public long? Apccodagenclibinterna { get; set; }
		public string Apcdgvccliberacaoint { get; set; }
		public string Apcdgvccliberacaoext { get; set; }
		public decimal? Apcvalsomatorioiofadc { get; set; }
		public decimal Apcvaltaxaalienacao { get; set; }
		public long Apcidccobrancatac { get; set; }
		public long Apcidctacfinanciada { get; set; }
		public string Apccodtiptitulo { get; set; }
		public string Apcdestiptitulo { get; set; }
		public string Apctipoperacao { get; set; }
		public long? Apcnumgrpsgl { get; set; }
		public DateTime? Apcdatprocessamento { get; set; }
		public decimal? Apcpcttaxajuroscontab { get; set; }
		public decimal? Apcpctatuindicecontab { get; set; }
		public long? Apcpertaxajuroscontab { get; set; }
		public long? Apcidtindicecontab { get; set; }
		public long Apcidccalcmoratorio { get; set; }
		public long Apcidccalcremunerator { get; set; }
		public long Apcidccalccontabeis { get; set; }
		public long Apcidccalccusto { get; set; }
		public decimal? Apcpcttaxajuroscusto { get; set; }
		public decimal? Apcpctatuindicecusto { get; set; }
		public long? Apcpertaxajuroscusto { get; set; }
		public long? Apcidtindicecusto { get; set; }
		public long Apcidcproalterada { get; set; }
		public long Apcidcprorenegociada { get; set; }
		public string Apcnumprorenegociada { get; set; }
		public long? Apcstastatuserro { get; set; }
		public long? Apcidccompradivida { get; set; }
		public string Apccodorgaoext { get; set; }
		public string Apccodsuborgaoext { get; set; }
		public long Apcidtorigemproposta { get; set; }
		public long Apcidcprorefin { get; set; }
		public decimal Apcpcttir { get; set; }
		public decimal? Apcpcttxequiva { get; set; }
		public DateTime? Apcdatacancelamento { get; set; }
        public long Apccodcontratointerno { get; set; }


    }


}
