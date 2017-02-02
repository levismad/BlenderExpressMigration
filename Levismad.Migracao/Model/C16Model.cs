using System;
using Levismad.Utils;
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{
    public class C16Model : IModel
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
        [Validar("LIBIDTLIBERACREDORIG", 10)]
        public long? Libidtliberacredorig { get; set; }
        [Validar("CTRIDTCONTROLE", 10)]
        public long? Ctridtcontrole { get; set; }
        [Validar("CTRIDTCONTROLELEI", 10)]
        public long? Ctridtcontrolelei { get; set; }
        public DateTime? Libdatprocessamento { get; set; }
        [Validar("LIBCODCENTROCUSTO", 10)]
        public string Libcodcentrocusto { get; set; }
        [Validar("LIBCODCLIENTE", 20)]
        public string Libcodcliente { get; set; }
        [Validar("LIBNOMCLIENTE", 80)]
        public string Libnomcliente { get; set; }
        [Validar("LIBTIPINSCRICAOCLIENTE", 1)]
        public long? Libtipinscricaocliente { get; set; }
        [Validar("LIBCPFCNPJCLIENTE", 20)]
        public string Libcpfcnpjcliente { get; set; }
        public DateTime? Libdatgeracao { get; set; }
        [Validar("LIBHORGERACAO", 20)]
        public string Libhorgeracao { get; set; }
        public DateTime? Libdthpagamento { get; set; }
        [Validar("LIBCODEMPRESA", 10)]
        public string Libcodempresa { get; set; }
        [Validar("LIBCNJEMPRESA", 20)]
        public string Libcnjempresa { get; set; }
        [Validar("LIBNOMEMPRESA", 80)]
        public string Libnomempresa { get; set; }
        [Validar("LIBTIPINSCRICAOEMPRESA", 1)]
        public long? Libtipinscricaoempresa { get; set; }
        [Validar("LIBENDENDERECOEMPRESA", 200)]
        public string Libendenderecoempresa { get; set; }
        [Validar("LIBNUMENDERECOEMPRESA", 9)]
        public long? Libnumenderecoempresa { get; set; }
        [Validar("LIBDESCOMPLEMEMPRESA", 200)]
        public string Libdescomplemempresa { get; set; }
        [Validar("LIBDESBAIRROEMPRESA", 200)]
        public string Libdesbairroempresa { get; set; }
        [Validar("LIBDESCIDADEEMPRESA", 200)]
        public string Libdescidadeempresa { get; set; }
        [Validar("LIBCEPEMPRESA", 8)]
        public long? Libcepempresa { get; set; }
        [Validar("LIBESTEMPRESA", 3)]
        public string Libestempresa { get; set; }
        [Validar("LIBCODBANCOCREDITO", 10)]
        public string Libcodbancocredito { get; set; }
        [Validar("LIBNOMBANCOCREDITO", 40)]
        public string Libnombancocredito { get; set; }
        [Validar("LIBNUMAGENCIACREDITO", 10)]
        public long? Libnumagenciacredito { get; set; }
        [Validar("LIBNUMDVAGENCIACREDIT", 5)]
        public string Libnumdvagenciacredit { get; set; }
        [Validar("LIBNUMCONTACREDITO", 10)]
        public long? Libnumcontacredito { get; set; }
        [Validar("LIBNUMDVCONTACREDIT", 5)]
        public string Libnumdvcontacredit { get; set; }
        [Validar("LIBTIPCONTACREDITO", 1)]
        public long? Libtipcontacredito { get; set; }
        [Validar("LIBCODBANCODEBITO", 10)]
        public string Libcodbancodebito { get; set; }
        [Validar("LIBNOMBANCODEBITO", 40)]
        public string Libnombancodebito { get; set; }
        [Validar("LIBNUMAGENCIADEBITO", 10)]
        public long? Libnumagenciadebito { get; set; }
        [Validar("LIBNUMDVAGENCIADEBITO", 5)]
        public string Libnumdvagenciadebito { get; set; }
        [Validar("LIBNUMCONTADEBITO", 10)]
        public long? Libnumcontadebito { get; set; }
        [Validar("LIBNUMDVCONTADEBITO", 5)]
        public string Libnumdvcontadebito { get; set; }
        [Validar("LIBTIPCONTADEBITO", 1)]
        public long? Libtipcontadebito { get; set; }
        [Validar("LIBTIPPAGAMENTO", 2)]
        public long? Libtippagamento { get; set; }
        [Validar("LIBVALPAGAMENTO", 21)]
        public decimal? Libvalpagamento { get; set; }
        [Validar("LIBNOMARQUIVO", 100)]
        public string Libnomarquivo { get; set; }
        [Validar("LIBNUMNOSSONUMERO", 15)]
        public string Libnumnossonumero { get; set; }
        [Validar("LIBNUMSEUNUMERO", 15)]
        public string Libnumseunumero { get; set; }
        [Validar("LIBNUMREMESSA", 8)]
        public string Libnumremessa { get; set; }
        [Validar("LIBTIPTRANSFERENCIA", 2)]
        public long? Libtiptransferencia { get; set; }
        [Validar("LIBOBSUSOEMPRESA", 100)]
        public string Libobsusoempresa { get; set; }
        [Validar("LIBNUMPROPOSTA", 20)]
        public string Libnumproposta { get; set; }
        public DateTime? Libdthinicioproposta { get; set; }
        public DateTime? Libdthvencproposta { get; set; }
        [Validar("LIBVALPROPOSTA", 21)]
        public decimal? Libvalproposta { get; set; }
        [Validar("LIBSTASTATUSERRO", 1)]
        public long? Libstastatuserro { get; set; }
        [Validar("LIBSISORIGINFORMACAO", 1)]
        public long? Libsisoriginformacao { get; set; }
        [Validar("LIBIDCPROREFIN", 1)]
        public long? Libidcprorefin { get; set; }

    }
}
