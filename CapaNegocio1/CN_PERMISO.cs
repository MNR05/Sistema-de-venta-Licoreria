using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos1;
using CapaEntidad1;
namespace CapaNegocio1
{
    public class CN_PERMISO
    {
        private CD_PERMISO objCDpermiso = new CD_PERMISO();

        public List<U_PERMISO> Listar(int idusuario)
        {
            return objCDpermiso.Listar(idusuario);
        }
    }
}
