using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad1
{
    public class U_USUARIOS
    {
        public int IdUser { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public U_ROL oRol { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }

    }
}
