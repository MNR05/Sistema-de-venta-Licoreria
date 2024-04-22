using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad1
{
   public class U_PERMISO
    {
        public int idPermiso { get; set; }
        public U_ROL obRol { get; set; }
        public string nombreMenu { get; set; }
        public string FechaRegistro { get; set; }
    }
}
