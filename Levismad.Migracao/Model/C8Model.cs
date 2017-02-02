using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{
    public class C8Model : IModel
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
        [Validar("OCUIDTOCUPACAO", 10)]
        public long? Ocuidtocupacao { get; set; }
        [Validar("OCUCODOCUPACAOEXT", 10)]
        public string Ocucodocupacaoext { get; set; }
        [Validar("OCUDESOCUPACAO", 100)]
        public string Ocudesocupacao { get; set; }
        [Validar("CTRIDTCONTROLE", 10)]
        public long? Ctridtcontrole { get; set; }
        [Validar("CTRIDTCONTROLELEI", 10)]
        public long? Ctridtcontrolelei { get; set; }

    }
}
