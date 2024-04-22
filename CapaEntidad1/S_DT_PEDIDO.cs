using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad1
{
    public class S_DT_PEDIDO
    {
        public int idDetalleVenta { get; set; }
        public P_PRODUCTO oProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
