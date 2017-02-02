using System;
using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model.TransferenciaAtraso
{
    public class C12Model : IModel
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
        [Validar("TRAIDTIDENTIFICADOR", 10)]
        public long? Traidtidentificador { get; set; }
        public DateTime? Tradattransferencia { get; set; }
        [Validar("TRAIDTONLINE", 1)]
        public long? Traidtonline { get; set; }
        [Validar("TRAVALPRINCIPAL", 21)]
        public decimal? Travalprincipal { get; set; }
        [Validar("TRAVALSALDOCONTA", 21)]
        public decimal? Travalsaldoconta { get; set; }
        public DateTime? Tradatregistro { get; set; }
        [Validar("TRAIDTONLINECANC", 1)]
        public long? Traidtonlinecanc { get; set; }
        [Validar("TRAIDTTIPTRANS", 1)]
        public long? Traidttiptrans { get; set; }
        [Validar("TRAIDTSITUACAO", 1)]
        public long? Traidtsituacao { get; set; }
        [Validar("TRAIDTSITCONTA", 1)]
        public long? Traidtsitconta { get; set; }
        [Validar("TRANUMCONTRATO", 20)]
        public string Tranumcontrato { get; set; }
        [Validar("TRANUMVERSAO", 4)]
        public long? Tranumversao { get; set; }
        [Validar("CTRIDTCONTROLELEI", 1)]
        public long? Ctridtcontrolelei { get; set; }
        [Validar("CTRIDTCONTROLE", 1)]
        public long? Ctridtcontrole { get; set; }
        [Validar("TRAIDTEVENTO", 1)]
        public long? Traidtevento { get; set; }
        [Validar("TRANUMPARCELA", 4)]
        public long? Tranumparcela { get; set; }
        [Validar("TRAIDTSITANTERIOR", 1)]
        public long? Traidtsitanterior { get; set; }
        [Validar("TRADESUSUARIO", 50)]
        public string Tradesusuario { get; set; }
        public DateTime? Tradatprocessamento { get; set; }

    }
}
