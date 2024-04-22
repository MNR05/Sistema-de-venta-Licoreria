using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos1;
using CapaEntidad1;
namespace CapaNegocio1
{
    public class CN_Rol
    {
        private CD_ROL objCDrol = new CD_ROL();

        public List<U_ROL> Listar()
        {
            return objCDrol.Listar();
        }
    }
}
