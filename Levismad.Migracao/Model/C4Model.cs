using System;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

	public class C4Model : IModel
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
        public long Dpgidtidentificador { get; set; }
        public long? Ctridtcontrolelei { get; set; }
        public long? Ctridtcontrolegra { get; set; }
        public string Dpgnumagencia { get; set; }
        public string Dpgnumcnpj { get; set; }
        public long? Dpgcodbanco { get; set; }
        public string Dpgnumconta { get; set; }
        public long? Dpgidtcripagparcial { get; set; }
        public DateTime Dpgdatpagamento { get; set; }
        public DateTime? Dpgdatvencparc { get; set; }
        public long? Dpgidcformapag { get; set; }
        public long Dpgidtempresa { get; set; }
        public string Dpgtxtmotrejeicao { get; set; }
        public string Dpgnumcontrato { get; set; }
        public long? Dpgnumparcela { get; set; }
        public string Dpgtxtobservacao { get; set; }
        public long? Dpgidcorigem { get; set; }
        public long? Dpgsitsituacao { get; set; }
        public long? Dpgidctipliquid { get; set; }
        public decimal? Dpgvalacresmora { get; set; }
        public decimal? Dpgvalacresmulta { get; set; }
        public decimal? Dpgvaldescmora { get; set; }
        public decimal? Dpgvaldescmulta { get; set; }
        public decimal? Dpgvaldiferenca { get; set; }
        public decimal Dpgvalpago { get; set; }
        public decimal? Dpgvalcorrecpago { get; set; }
        public decimal? Dpgvaliofpago { get; set; }
        public decimal? Dpgvaljurospago { get; set; }
        public decimal? Dpgvalmorapago { get; set; }
        public decimal? Dpgvalmultapago { get; set; }
        public decimal? Dpgvalprincippago { get; set; }
        public string Dpgnumboleto { get; set; }
        public string Dpgidtorgrecebedor { get; set; }
        public string Dpgnumnovocontratoext { get; set; }
        public string Dpgnumvscontratoext { get; set; }
        public string Dpgcodbancoprest { get; set; }
        public string Dpgnumagenciaprest { get; set; }
        public string Dpgnumcontaprest { get; set; }
        public string Dpgnumdvcontaprest { get; set; }
        public DateTime? Dpgdatestornopgt { get; set; }
        public long? Dpgidcmodproc { get; set; }
        public DateTime? Dpgdatenviodebito { get; set; }
        public long? Dpgidtpgtinconsist { get; set; }
        public long? Dpgidtsisorig { get; set; }
        public string Dpgcodorgaorecebedor { get; set; }
        public string Dpgcodtipoorgrecebed { get; set; }
        public long? Dpgseqpgtdata { get; set; }

    }


}
