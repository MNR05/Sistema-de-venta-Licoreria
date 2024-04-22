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
    public class CD_Usuario
    {
        public List<U_USUARIOS> Listar()
        {
            List<U_USUARIOS> lista = new List<U_USUARIOS>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select u.U_IDUSUARIO,u.U_DOCUMENTO,u.U_NOMBRE,u.U_APELLIDO, u.U_CORREO, u.U_CLAVE,u.U_ESTADO,r.R_ROL,r.R_DESCRIPCION from USUARIOS u");
                    query.AppendLine("inner join ROL r on r.R_ROL = u.U_ROL"); 

                    
                        //string query = "select U_IDUSUARIO,U_DOCUMENTO,U_NOMBRE,U_APELLIDO, U_CORREO, U_CLAVE,U_ESTADO from USUARIOS";
                    //string query = "select U_IDUSUARIO AS ID,U_DOCUMENTO AS DOCUMENTO,U_NOMBRE AS NOMBRE, U_APELLIDO AS APELLIDO, U_CORREO AS CORREO, U_CLAVE AS CONTRASEÑA,U_ESTADO AS ESTADO from USUARIOS";
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new U_USUARIOS()
                            {
                                IdUser = Convert.ToInt32(dr["U_IDUSUARIO"]),
                                Documento = dr["U_DOCUMENTO"].ToString(),
                                Nombre = dr["U_NOMBRE"].ToString(),
                                Apellido = dr["U_APELLIDO"].ToString(),
                                Correo = dr["U_CORREO"].ToString(),
                                Clave = dr["U_CLAVE"].ToString(),
                                oRol = new U_ROL
                                {
                                    IdRol = Convert.ToInt32(dr["R_ROL"]),
                                    Descripcion = dr["R_DESCRIPCION"].ToString()
                                },
                                Estado = Convert.ToBoolean(dr["U_ESTADO"])


                            }) ;
                        }
                    }
                }
                catch(Exception ex)
                {
                    lista = new List<U_USUARIOS>();
                }
                

            }
            return lista;
        }
    
        public int Registrar(U_USUARIOS obj, out string Mensaje)
        {
            int idusuariogenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("documento", obj.Documento);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("correo", obj.Correo);
                    cmd.Parameters.AddWithValue("clave", obj.Clave);
                    cmd.Parameters.AddWithValue("idrol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);
                    cmd.Parameters.Add("IdUsuarioResultado",SqlDbType.Int).Direction=ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                idusuariogenerado = 0;
                Mensaje = ex.Message;
            }
            return idusuariogenerado;
        }
        //Editar usuario
        public bool Editar(U_USUARIOS obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idusuario", obj.IdUser);
                    cmd.Parameters.AddWithValue("documento", obj.Documento);
                    cmd.Parameters.AddWithValue("nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("correo", obj.Correo);
                    cmd.Parameters.AddWithValue("clave", obj.Clave);
                    cmd.Parameters.AddWithValue("idrol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(U_USUARIOS obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idusuario", obj.IdUser);
                    
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }


    }

}
