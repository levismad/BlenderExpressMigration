using System;
using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{

    public class C6Model : IModel
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
        [Validar("NOBIDTNEGOUTROBANCO", 10)]
        public decimal? Nobidtnegoutrobanco { get; set; }
        [Validar("NOBCODEXTERNO", 10)]
        public string Nobcodexterno { get; set; }
        [Validar("NOBCODEXTPESSOA", 10)]
        public string Nobcodextpessoa { get; set; }
        [Validar("NOBCODEXTAGENCIAEXT", 10)]
        public string Nobcodextagenciaext { get; set; }
        [Validar("NOBCODEXTBANCO", 10)]
        public string Nobcodextbanco { get; set; }
        [Validar("NOBNUMNEGOCIO", 20)]
        public string Nobnumnegocio { get; set; }
        [Validar("NOBNUMDVNEGOCIO", 5)]
        public string Nobnumdvnegocio { get; set; }
        [Validar("NOBVALVALORLIMITE", 15)]
        public long? Nobvalvalorlimite { get; set; }
        [Validar("NOBVALSALDODEVEDOR", 15)]
        public long? Nobvalsaldodevedor { get; set; }
        [Validar("NOBDATINICIOOPERACAO", 20)]
        public DateTime? Nobdatiniciooperacao { get; set; }
        [Validar("NOBDATFIMOPERACAO", 20)]
        public DateTime? Nobdatfimoperacao { get; set; }
        [Validar("NOBTINEGOCIO", 1)]
        public decimal? Nobtinegocio { get; set; }
        [Validar("NOBIDTSITUACAO", 1)]
        public decimal? Nobidtsituacao { get; set; }
        [Validar("CTRIDTCTRLEITURA", 10)]
        public decimal? Ctridtctrleitura { get; set; }
        [Validar("CTRIDTCTRGRAVACAO", 10)]
        public decimal? Ctridtctrgravacao { get; set; }

    }
}
