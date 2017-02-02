using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

    public class C7Model : IModel
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
        [Validar("ENDIDTENDERECO", 10)]
        public decimal? Endidtendereco { get; set; }
        [Validar("ENDCODEXTENDERECO", 10)]
        public string Endcodextendereco { get; set; }
        [Validar("ENDCODEXTPESSOA", 10)]
        public string Endcodextpessoa { get; set; }
        [Validar("ENDTIPENDERECO", 2)]
        public decimal? Endtipendereco { get; set; }
        [Validar("ENDTIPLOGRADOURO", 3)]
        public decimal? Endtiplogradouro { get; set; }
        [Validar("ENDDESLOGRADOURO", 200)]
        public string Enddeslogradouro { get; set; }
        [Validar("ENDNUMENDERECO", 10)]
        public decimal? Endnumendereco { get; set; }
        [Validar("ENDDESCOMPLEMENTO", 200)]
        public string Enddescomplemento { get; set; }
        [Validar("ENDDESBAIRRO", 200)]
        public string Enddesbairro { get; set; }
        [Validar("ENDCEPENDERECO", 8)]
        public decimal? Endcependereco { get; set; }
        [Validar("ENDNOMMUNICIPIO", 200)]
        public string Endnommunicipio { get; set; }
        [Validar("ENDCODEXTMUNICIPIO", 10)]
        public string Endcodextmunicipio { get; set; }
        [Validar("ENDNOMSIGLAUF", 3)]
        public string Endnomsiglauf { get; set; }
        [Validar("ENDNOMUF", 80)]
        public string Endnomuf { get; set; }
        [Validar("ENDCODEXTUF", 10)]
        public string Endcodextuf { get; set; }
        [Validar("ENDNOMPAIS", 80)]
        public string Endnompais { get; set; }
        [Validar("ENDCODEXTPAIS", 10)]
        public string Endcodextpais { get; set; }
        [Validar("CTRIDTCTRLEITURA", 10)]
        public decimal? Ctridtctrleitura { get; set; }
        [Validar("CTRIDTCTRGRAVACAO", 10)]
        public decimal? Ctridtctrgravacao { get; set; }
        [Validar("ENDIDTPERFIL", 3)]
        public decimal? Endidtperfil { get; set; }
        [Validar("ENDIDCPRINCIPAL", 1)]
        public decimal? Endidcprincipal { get; set; }
        [Validar("ENDTIPPESSOA", 1)]
        public decimal? Endtippessoa { get; set; }
        [Validar("ENDIDTENVIOCORRESPOND", 1)]
        public decimal? Endidtenviocorrespond { get; set; }
        [Validar("ENDTIPRESIDENCIA", 1)]
        public decimal? Endtipresidencia { get; set; }
    }
}
