using System;
using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{
    public class C14Model : IModel
    {
        public ValidatorResult Validar()
        {
            var result = new ValidatorResult();
            return result;
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
        [Validar("AOPIDTOCORRPROPOSTA", 10)]
        public long? Aopidtocorrproposta { get; set; }
        [Validar("AOPIDTEMPRESA", 10)]
        public long? Aopidtempresa { get; set; }
        [Validar("AOPNUMPROPOSTA", 20)]
        public string Aopnumproposta { get; set; }
        [Validar("AOPVRSPROPOSTA", 4)]
        public long? Aopvrsproposta { get; set; }
        [Validar("AOPIDTOCORRENCIA", 40)]
        public string Aopidtocorrencia { get; set; }
        public DateTime? Aopdatocorrencia { get; set; }
        [Validar("AOPDESOCORRENCIA", 300)]
        public string Aopdesocorrencia { get; set; }
        [Validar("AOPNOMUSUARIOGRA", 30)]
        public string Aopnomusuariogra { get; set; }
        [Validar("CTRIDTCONTROLELEI", 10)]
        public long? Ctridtcontrolelei { get; set; }
        [Validar("CTRIDTCONTROLEGRA", 10)]
        public long? Ctridtcontrolegra { get; set; }
        public DateTime? Aopdatprocessamento { get; set; }
        [Validar("AOPSTASTATUSERRO", 1)]
        public long? Aopstastatuserro { get; set; }

    }
}
