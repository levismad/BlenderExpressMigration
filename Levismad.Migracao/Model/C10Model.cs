using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

    public class C10Model : IModel
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
        public long Hdrcodver { get; set; }
        [Validar("ORGIDTORGAO", 10)]
        public long Orgidtorgao { get; set; }
        [Validar("CTRIDTCONTROLELEI", 10)]
        public long? Ctridtcontrolelei { get; set; }
        [Validar("CTRIDTCONTROLE", 10)]
        public long? Ctridtcontrole { get; set; }
        [Validar("ORGCODORGAOEXT", 10)]
        public string Orgcodorgaoext { get; set; }
        [Validar("ORGDESORGAOEXT", 80)]
        public string Orgdesorgaoext { get; set; }
        [Validar("ORGCODPRODUTOEXT", 10)]
        public string Orgcodprodutoext { get; set; }
    }
}
