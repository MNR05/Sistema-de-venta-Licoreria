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
    public class CD_PERMISO
    {
        public List<U_PERMISO> Listar(int idusuario)
        {
            List<U_PERMISO> lista = new List<U_PERMISO>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.PRE_R_ROL,p.PER_NOMBREMENU FROM PERMISO p");
                    query.AppendLine("inner join ROL r on r.R_ROL = p.PRE_R_ROL");
                    query.AppendLine("inner join USUARIOS u on u.U_ROL = r.R_ROL");
                    query.AppendLine("where u.U_IDUSUARIO=@idusuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idusuario",idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new U_PERMISO()
                            {
                                obRol = new U_ROL() {
                                    IdRol = Convert.ToInt32(dr["PRE_R_ROL"])
                                },
                                nombreMenu = dr["PER_NOMBREMENU"].ToString(),
                                

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<U_PERMISO>();
                }


            }
            return lista;
        }
    }
}
