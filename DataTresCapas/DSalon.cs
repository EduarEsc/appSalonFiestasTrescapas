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
    public class DSalon : DAbstracta
    {
        public ERespuestaSalon getSalon()
        {
            ERespuestaSalon obj = new ERespuestaSalon();
            string resMens = string.Empty;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open(); 
                using (SqlCommand com = new SqlCommand("Salon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 1 });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    com.ExecuteNonQuery();
                    resMens = com.Parameters["@Mensaje"].Value.ToString();

                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
            obj.Tabla = dt;
            obj.Mensaje = resMens;
            return obj;
        }
        public ERespuestaSalon getSalonDetalle(int fiIdSalon)
        {
            ERespuestaSalon obj = new ERespuestaSalon();
            string resMens = string.Empty;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Salon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 2 });
                    com.Parameters.Add(new SqlParameter("@fiIdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    com.ExecuteNonQuery();
                    resMens = com.Parameters["@Mensaje"].Value.ToString();
                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
            obj.Tabla = dt;
            obj.Mensaje = resMens;
            return obj;
        }
        public string postSalon(string fcNombreSalon, string fcContraseña,
                                int fiIdTipoUsuario, int fiIdTipoSalon,
                                bool fbEsActivo
                               )
        {
            string resMens = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Salon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 3 });
                    com.Parameters.Add(new SqlParameter("@fcNombreSalon", SqlDbType.NVarChar, 200) { Value = fcNombreSalon });
                    com.Parameters.Add(new SqlParameter("@fcContraseña", SqlDbType.NVarChar, 200) { Value = fcContraseña });
                    com.Parameters.Add(new SqlParameter("@fiIdTipoUsuario", SqlDbType.Int) { Value = fiIdTipoUsuario });
                    com.Parameters.Add(new SqlParameter("@fiIdTipoSalon", SqlDbType.Int) { Value = fiIdTipoSalon });
                    com.Parameters.Add(new SqlParameter("@fbEsActivo", SqlDbType.Bit) { Value = fbEsActivo });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    com.ExecuteNonQuery();
                    resMens = com.Parameters["@Mensaje"].Value.ToString();
                }
                con.Close();
            }
            return resMens;
        }
        public string putSalon(int fiIdSalon, string fcNombreSalon,
                               string fcContraseña, int fiIdTipoUsuario,
                               int fiIdTipoSalon, bool fbEsActivo
                              )
        {  
            string resMens = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Salon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 4 });
                    com.Parameters.Add(new SqlParameter("@fiIdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    com.Parameters.Add(new SqlParameter("@fcNombreSalon", SqlDbType.NVarChar, 200) { Value = fcNombreSalon });
                    com.Parameters.Add(new SqlParameter("@fcContraseña", SqlDbType.NVarChar, 200) { Value = fcContraseña });
                    com.Parameters.Add(new SqlParameter("@fiIdTipoUsuario", SqlDbType.Int) { Value = fiIdTipoUsuario });
                    com.Parameters.Add(new SqlParameter("@fiIdTipoSalon", SqlDbType.Int) { Value = fiIdTipoSalon });
                    com.Parameters.Add(new SqlParameter("@fbEsActivo", SqlDbType.Bit) { Value = fbEsActivo });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    com.ExecuteNonQuery();
                    resMens = com.Parameters["@Mensaje"].Value.ToString();
                }
                con.Close();
            }
            return resMens;
        }
    }
}
