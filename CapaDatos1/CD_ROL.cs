using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad1;
namespace CapaDatos1
{
    public class CD_ROL
    {
        public List<U_ROL> Listar()
        {
            List<U_ROL> lista = new List<U_ROL>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT R_ROL,R_DESCRIPCION FROM ROL");
                    

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new U_ROL()
                            {
                                IdRol = Convert.ToInt32(dr["R_ROL"]),
                                Descripcion = dr["R_DESCRIPCION"].ToString(),
                            }) ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<U_ROL>();
                }
            }
            return lista;
        }
    }
}
