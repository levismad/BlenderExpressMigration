using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

    public class C5Model : IModel
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
        public decimal? Hdrcodver { get; set; }
        [Validar("CONIDTCONTATO", 10)]
        public decimal? Conidtcontato { get; set; }
        [Validar("CONCODEXTCONTATO", 10)]
        public string Concodextcontato { get; set; }
        [Validar("CONCODEXTPESSOA", 10)]
        public string Concodextpessoa { get; set; }
        [Validar("CONNOMCONTATO", 80)]
        public string Connomcontato { get; set; }
        [Validar("CONNUMDDDTELEFONE", 3)]
        public decimal? Connumdddtelefone { get; set; }
        [Validar("CONNUMTELEFONE", 10)]
        public decimal? Connumtelefone { get; set; }
        [Validar("CONNUMRAMAL", 4)]
        public decimal? Connumramal { get; set; }
        [Validar("CONNUMDDDFAX", 3)]
        public decimal? Connumdddfax { get; set; }
        [Validar("CONNUMFAX", 10)]
        public decimal? Connumfax { get; set; }
        [Validar("CONDESEMAIL", 80)]
        public string Condesemail { get; set; }
        [Validar("CTRIDTCTRLEITURA", 10)]
        public decimal? Ctridtctrleitura { get; set; }
        [Validar("CTRIDTCTRGRAVACAO", 10)]
        public decimal? Ctridtctrgravacao { get; set; }
        [Validar("CONIDTPERFIL", 3)]
        public decimal? Conidtperfil { get; set; }
        [Validar("CONTIPTELCONTATO", 1)]
        public decimal? Contiptelcontato { get; set; }
        [Validar("CONIDTTELPRINCIPAL", 1)]
        public decimal? Conidttelprincipal { get; set; }
        [Validar("CONIDTMARKETINGSMS", 1)]
        public decimal? Conidtmarketingsms { get; set; }
        [Validar("CONIDTMARKETINGEMAIL", 1)]
        public decimal? Conidtmarketingemail { get; set; }
        [Validar("CONDESAFINIDADE", 100)]
        public string Condesafinidade { get; set; }


    }
}
