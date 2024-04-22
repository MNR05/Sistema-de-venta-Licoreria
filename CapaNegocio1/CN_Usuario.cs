using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos1;
using CapaEntidad1;
namespace CapaNegocio1
{
    public class CN_Usuario
    {
        private CD_Usuario objCDuser = new CD_Usuario();

        public List<U_USUARIOS> Listar()
        {
            return objCDuser.Listar();
        }
        public int Registrar(U_USUARIOS obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Llene el campo documento";
            }
            if (obj.Nombre == "")
            {
                Mensaje += "Llene el campo nombre";
            }
            if (obj.Apellido == "")
            {
                Mensaje += "Llene el campo apellido";
            }
            if (obj.Clave == "")
            {
                Mensaje += "Llene el campo constraseña";

            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
               return objCDuser.Registrar(obj, out Mensaje);
            }
           
        }
        public bool Editar(U_USUARIOS obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Llene el campo documento";
            }
            if (obj.Nombre == "")
            {
                Mensaje += "Llene el campo nombre";
            }
            if (obj.Apellido == "")
            {
                Mensaje += "Llene el campo apellido";
            }
            if (obj.Clave == "")
            {
                Mensaje += "Llene el campo constraseña";

            }
            if(Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objCDuser.Editar(obj, out Mensaje);
            }
           
        }
        public bool Eliminar(U_USUARIOS obj, out string Mensaje)
        {
            return objCDuser.Eliminar(obj, out Mensaje);
        }
    }
}
