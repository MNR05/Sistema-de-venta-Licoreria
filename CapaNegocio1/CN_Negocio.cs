using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos1;
using CapaEntidad1;
namespace CapaNegocio1
{
    public class CN_Negocio
    {
        private CD_negocio objNeg = new CD_negocio();

        public Negocio ObtenerDatos()
        {
            return objNeg.obtenerDatos();
        }
        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre\n";
            }
            if (obj.RUC == "")
            {
                Mensaje += "Es necesario el RUC\n";
            }
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la direccion\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objNeg.GuardarDatos(obj, out Mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objNeg.ObtenerLogo(out obtenido);
        }
        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objNeg.ActualizarLogo(imagen, out mensaje);
        }
    }
}
