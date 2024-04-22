using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad1
{
    public class S_PEDIDO
    {
        public int IdPedio { get; set; }
        public U_USUARIOS oUser { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public List<S_DT_PEDIDO> oDetalle_Venta { get; set; }
        public string FechaRegistro { get; set; }
    }
}
