using SharinganSolutions.EntityTresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.DataTresCapas
{
    public class DUsuarioSalon : DAbstracta
    {

        public ERespuesta getUsuarioSalon(int idSalon)
        {
            ERespuesta obj = new ERespuesta();
            DataTable dt = new DataTable();
            string resMensaje = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("UsuarioSalon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 1 });
                    com.Parameters.Add(new SqlParameter("@IdSalon", SqlDbType.Int) { Value = idSalon });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    com.ExecuteNonQuery();
                    resMensaje = com.Parameters["@Mensaje"].Value.ToString();
                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
            }
            obj.Tabla = dt;
            obj.Mensaje = resMensaje;
            return obj;
        }


        public ERespuesta getUsuarioSalonDetalle(int idUsuarioSalon)
        {
            DataTable dt = new DataTable();
            ERespuesta obj = new ERespuesta();
            string resMensaje = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("UsuarioSalon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 2 });
                    com.Parameters.Add(new SqlParameter("@IdUsuarioSalon", SqlDbType.Int) { Value = idUsuarioSalon });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    com.ExecuteNonQuery();
                    resMensaje = com.Parameters["@Mensaje"].Value.ToString();
                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
            }
            obj.Tabla = dt;
            obj.Mensaje = resMensaje;
            return obj;
        }

        public string postUsuarioSalon(string fcNombreUsuario, string fcContraseña,
                                       int fiIdSalon, int fiIdTipoUsuario, bool fbEsActivo
                                      )
        {
            string res = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("UsuarioSalon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 3 });
                    com.Parameters.Add(new SqlParameter("@NombreUsuario", SqlDbType.NVarChar, 255) { Value = fcNombreUsuario });
                    com.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.NVarChar, 255) { Value = fcContraseña });
                    com.Parameters.Add(new SqlParameter("@IdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    com.Parameters.Add(new SqlParameter("@IdTipoUsuario", SqlDbType.Int) { Value = fiIdTipoUsuario });
                    com.Parameters.Add(new SqlParameter("@EsActivo", SqlDbType.Bit) { Value = fbEsActivo });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    com.ExecuteNonQuery();
                    res = com.Parameters["@Mensaje"].Value.ToString();
                }
                con.Close();
            }
            return res;
        }

        public string putUsuarioSalon(int idUsuarioSalon, string fcNombreUsuario, string fcContraseña,
                                      int fiIdSalon, int fiIdTipoUsuario, bool fbEsActivo
                                     )
        {
            string res = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("UsuarioSalon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 4 });
                    com.Parameters.Add(new SqlParameter("@NombreUsuario", SqlDbType.NVarChar, 255) { Value = fcNombreUsuario });
                    com.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.NVarChar, 255) { Value = fcContraseña });
                    com.Parameters.Add(new SqlParameter("@IdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    com.Parameters.Add(new SqlParameter("@IdTipoUsuario", SqlDbType.Int) { Value = fiIdTipoUsuario });
                    com.Parameters.Add(new SqlParameter("@EsActivo", SqlDbType.Bit) { Value = fbEsActivo });
                    com.Parameters.Add(new SqlParameter("@IdUsuarioSalon", SqlDbType.Bit) { Value = idUsuarioSalon });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    com.ExecuteNonQuery();
                    res = com.Parameters["@Mensaje"].Value.ToString();
                }
                con.Close();
            }
            return res;
        }
    }
}
