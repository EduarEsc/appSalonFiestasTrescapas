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
        public DataTable getSalon()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand("Salon_sp", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 1 });
                    cm.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    cm.ExecuteNonQuery();
                    string men = cm.Parameters["@Mensaje"].Value.ToString();
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        da.Fill(dt);
                    }
                }
                cn.Close();
            }
            return dt;
        }
        public DataTable getSalonDetalle(int Accion, int fiIdSalon)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand("Salon_sp", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = Accion });
                    cm.Parameters.Add(new SqlParameter("@fiIdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    cm.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    cm.ExecuteNonQuery();
                    string men = cm.Parameters["@Mensaje"].Value.ToString();
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        da.Fill(dt);
                    }
                }
                cn.Close();
            }
            return dt;
        }
        public void postSalon(
                              int Accion, string fcNombreSalon, string fcContraseña,
                              int fiIdTipoUsuario, int fiIdTipoSalon,
                              bool fbEsActivo
                             )
        {
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand("Salon_sp", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = Accion });
                    cm.Parameters.Add(new SqlParameter("@fcNombreSalon", SqlDbType.NVarChar, 200) { Value = fcNombreSalon });
                    cm.Parameters.Add(new SqlParameter("@fcContraseña", SqlDbType.NVarChar, 200) { Value = fcContraseña });
                    cm.Parameters.Add(new SqlParameter("@fcIdTipoUsuario", SqlDbType.Int) { Value = fiIdTipoUsuario });
                    cm.Parameters.Add(new SqlParameter("@fiIdTipoSalon", SqlDbType.Int) { Value = fiIdTipoSalon });
                    cm.Parameters.Add(new SqlParameter("@fbEsActivo", SqlDbType.Bit) { Value = fbEsActivo });
                    cm.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    cm.ExecuteNonQuery();
                    string men = cm.Parameters["@Mensaje"].Value.ToString();
                }
                cn.Close();
            }
        }
        public void putSalon(
                             int Accion, int fiIdSalon, string fcNombreSalon,
                             string fcContraseña, int fiIdTipoUsuario,
                             int fiIdTipoSalon, bool fbEsActivo
                            )
        {
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand("Salon_sp", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = Accion });
                    cm.Parameters.Add(new SqlParameter("@fiIdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    cm.Parameters.Add(new SqlParameter("@fcNombreSalon", SqlDbType.NVarChar, 200) { Value = fcNombreSalon });
                    cm.Parameters.Add(new SqlParameter("@fcContraseña", SqlDbType.NVarChar, 200) { Value = fcContraseña });
                    cm.Parameters.Add(new SqlParameter("@fiIdTipoUsuarion", SqlDbType.Int) { Value = fiIdTipoUsuario });
                    cm.Parameters.Add(new SqlParameter("@fiIdTipoSalon", SqlDbType.Int) { Value = fiIdTipoSalon });
                    cm.Parameters.Add(new SqlParameter("@EsActivo", SqlDbType.Bit) { Value = fbEsActivo });
                    cm.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    string men = cm.Parameters["@Mensaje"].Value.ToString();
                }
                cn.Close();
            }
        }
        public void putActivo(int Accion, int fiIdSalon, bool EsActivo)
        {
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand("Salon_sp", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = Accion });
                    cm.Parameters.Add(new SqlParameter("@fiIdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    cm.Parameters.Add(new SqlParameter("@EsActivo", SqlDbType.Bit) { Value = EsActivo });
                    cm.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    string men = cm.Parameters["@Mensaje"].Value.ToString();
                }
                cn.Close();
            }
        }
    }
}
