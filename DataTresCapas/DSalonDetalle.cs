using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.DataTresCapas
{
    public class DSalonDetalle : DAbstracta
    {
        public DataTable getSalonDetalle(int Accion)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand("DetalleSalon_sp", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = Accion });
                    cm.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    string men = cm.Parameters["@Mesnaje"].Value.ToString();
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        da.Fill(dt);
                    }
                }
                cn.Close();
            }
            return dt;
        }
        public DataTable getSalonDetalle1(int Accion, int fiIdDetalleSalon)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand("DetalleSalon_sp", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = Accion });
                    cm.Parameters.Add(new SqlParameter("@fiIdDetalleSalon", SqlDbType.Int) { Value = fiIdDetalleSalon });
                    cm.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
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
        public void postSalonDetalle(
                                      int Accion, string fcCorreo, string fcTelefono,
                                      string fcCalle, string fcColonia, string fcDelegacion,
                                      string fcCPostal, string fcReferencias,
                                      string fcEntreCalles, int fiIdSalon, int fiIdCapacidad
                                    )
        {
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand("DetalleSalon_sp", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = Accion });
                    cm.Parameters.Add(new SqlParameter("@fcCorreo", SqlDbType.NVarChar, 200) { Value = fcCorreo });
                    cm.Parameters.Add(new SqlParameter("@fcTelefono", SqlDbType.NVarChar, 200) { Value = fcTelefono });
                    cm.Parameters.Add(new SqlParameter("@fcCalle", SqlDbType.NVarChar, 200) { Value = fcCalle });
                    cm.Parameters.Add(new SqlParameter("@fcColonia", SqlDbType.NVarChar, 200) { Value = fcColonia });
                    cm.Parameters.Add(new SqlParameter("@fcDelegacion", SqlDbType.NVarChar, 200) { Value = fcDelegacion });
                    cm.Parameters.Add(new SqlParameter("@fcCPostal", SqlDbType.NVarChar, 200) { Value = fcCPostal });
                    cm.Parameters.Add(new SqlParameter("@fcReferencias", SqlDbType.NVarChar, 200) { Value = fcReferencias });
                    cm.Parameters.Add(new SqlParameter("@fcEntreCalles", SqlDbType.NVarChar, 200) { Value = fcEntreCalles });
                    cm.Parameters.Add(new SqlParameter("@fiIdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    cm.Parameters.Add(new SqlParameter("@fiIdCapacidad", SqlDbType.Int) { Value = fiIdCapacidad });
                    cm.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                }
                cn.Close();
            }
        }
        public void putSalonDetalle()
        {

        }
    }
}
