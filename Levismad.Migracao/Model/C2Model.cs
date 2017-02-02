using System;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

	public class C2Model : IModel
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
		public long Appidtparcela { get; set; }
		public long  Appidtempresa { get; set; }
		public string Appnumproposta { get; set; }
		public long Appvrsproposta { get; set; }
		public decimal Apppctcetparcela { get; set; }
		public DateTime? Appdatboavencimento { get; set; }
		public DateTime? Appdatvencimento { get; set; }
		public long Appidccomissao { get; set; }
		public long Appidccorrecao { get; set; }
		public long Appidcjuros { get; set; }
		public long Appidcprincipal { get; set; }
		public long Appidcliqautomatica { get; set; }
		public long Appnumparcela { get; set; }
		public decimal Appvalcomissao { get; set; }
		public decimal Appvaliof { get; set; }
		public decimal Appvaliofadic { get; set; }
		public decimal Appvaliofmax { get; set; }
		public decimal Appvalir { get; set; }
		public decimal Appvaljuros { get; set; }
		public decimal Appvallibor { get; set; }
		public decimal Appvalprincipal { get; set; }
		public decimal Appvalvencimento { get; set; }
		public long Ctridtcontrolelei { get; set; }
		public long Ctridtcontrolegra { get; set; }
		public decimal? Appalqiofmaximo { get; set; }
		public long? Appidccomposparcela { get; set; }
		public DateTime? Appdatprocessamento { get; set; }
		public long Appidttipoproposta { get; set; }
		public long? Appstastatuserro { get; set; }
		public long Appsitsituacao { get; set; }


	}


}
