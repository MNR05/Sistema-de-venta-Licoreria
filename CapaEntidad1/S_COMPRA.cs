using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad1
{
    public class S_COMPRA
    {
        public int IdCompra { get; set; }
        public U_USUARIOS oUser { get; set; }
        public S_PROVEEDOR oProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<S_DT_COMPRA>  oDetalle_Compra { get; set; }
        public string FechRegistro { get; set; }
    }
}
