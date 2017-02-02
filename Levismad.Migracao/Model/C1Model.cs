using System;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

	public class C1Model : IModel
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
		public long Cliidtcliente { get; set; }
		public string Clicodextcliente { get; set; }
		public string Clicodextpessoa { get; set; }
		public string Clicodextempresa { get; set; }
		public string Clicodextramoativ { get; set; }
		public string Clicodextsetornat { get; set; }
		public string Clicodextporte { get; set; }
		public string Clicodextfuncionario { get; set; }
		public string Clicodextclassific { get; set; }
		public string Clicodextcapitalsoc { get; set; }
		public long Clitippessoa { get; set; }
		public string Clinomcliente { get; set; }
		public string Clinomabvcliente { get; set; }
		public DateTime? Clidatnascimento { get; set; }
		public string Clinumrg { get; set; }
		public DateTime? Clidatemissaorg { get; set; }
		public string Clidesorgaoexpedidor { get; set; }
		public string Clidesufrg { get; set; }
		public string Clinompai { get; set; }
		public DateTime? Clidatnascpai { get; set; }
		public string Clinommae { get; set; }
		public DateTime? Clidatnascmae { get; set; }
		public string Clinuminscestadual { get; set; }
		public long Clinumcpfcnpj { get; set; }
		public long Clinumbasecpfcnpj { get; set; }
		public long Clinumdvcpfcnpj { get; set; }
		public long Clinumfilialcnpj { get; set; }
		public DateTime? Clidatconstempresa { get; set; }
		public long? Clitipcontroleacio { get; set; }
		public long? Clitipempresa { get; set; }
		public long? Cliidtsexo { get; set; }
		public string Clidesnaturalidade { get; set; }
		public long? Cliidtestcivil { get; set; }
		public string Clinomconjuge { get; set; }
		public DateTime? Clidatnascconjuge { get; set; }
		public string Clicodcnae { get; set; }
		public long Clitipnivelrisco { get; set; }
		public decimal Clivalrendamensal { get; set; }
		public long Cliidtcobraioflib { get; set; }
		public long Cliidtcobraiofadiclib { get; set; }
		public DateTime? Clidatinilimiteglobal { get; set; }
		public DateTime? Clidatfimlimiteglobal { get; set; }
		public decimal Clivallimiteglobal { get; set; }
		public long Cliindindeterminado { get; set; }
		public long Clisitcliente { get; set; }
		public long Ctridtctrleitura { get; set; }
		public long Ctridtctrgravacao { get; set; }
		public string Clicodconglomeradoeco { get; set; }
		public long Cliidccadastrpositivo { get; set; }
		public string Clinumrne { get; set; }
		public long Cliidcautorizacao { get; set; }

	}


}
