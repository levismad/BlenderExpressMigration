using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

    public class C9Model : IModel
    {
        public ValidatorResult Validar()
        {
            return this.ValidarTamanhos();
        }
        [Validar("HDRDATHOR", 25)]
        public string Hdrdathor { get; set; }
        [Validar("HDRCODUSU", 30)]
        public string Hdrcodusu { get; set; }
        [Validar("HDRCODETC", 15)]
        public string Hdrcodetc { get; set; }
        [Validar("HDRCODPGR", 20)]
        public string Hdrcodpgr { get; set; }
        [Validar("HDRCODVER", 5)]
        public long? Hdrcodver { get; set; }
        [Validar("ADPIDTCLIENTEORGAO", 10)]
        public long? Adpidtclienteorgao { get; set; }
        [Validar("CTRIDTCONTROLE", 10)]
        public long? Ctridtcontrole { get; set; }
        [Validar("CTRIDTCONTROLELEI", 10)]
        public long? Ctridtcontrolelei { get; set; }
        [Validar("ADPCODPESSOAPROFISEXT", 10)]
        public string Adpcodpessoaprofisext { get; set; }
        [Validar("ADPCODCLIENTEEXT", 10)]
        public string Adpcodclienteext { get; set; }
        [Validar("ADPCODORGAOEXT", 10)]
        public string Adpcodorgaoext { get; set; }
        [Validar("ADPCODSUBORGAOEXT", 10)]
        public string Adpcodsuborgaoext { get; set; }
        [Validar("ADPCODPROFISSAOEXT", 10)]
        public string Adpcodprofissaoext { get; set; }
        [Validar("ADPCODOCUPACAOEXT", 10)]
        public string Adpcodocupacaoext { get; set; }
        [Validar("ADPCODMATRICULA", 15)]
        public string Adpcodmatricula { get; set; }
        [Validar("ADPVALRENDABRUTA", 21)]
        public decimal? Adpvalrendabruta { get; set; }
        [Validar("ADPVALRENDALIQUIDA", 21)]
        public decimal? Adpvalrendaliquida { get; set; }
        [Validar("ADPIDCATIVO", 1)]
        public long? Adpidcativo { get; set; }
    }
}
