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
    public class DSalonDetalle : DAbstracta
    {
        public ERespuestaSalonDet getSalonDetalle()
        {
            ERespuestaSalonDet obj = new ERespuestaSalonDet();
            string resMens = string.Empty;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("DetalleSalon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 1 });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    resMens = com.Parameters["@Mesnaje"].Value.ToString();
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
        public ERespuestaSalonDet getSalonDetalle1(int fiIdDetalleSalon)
        {
            ERespuestaSalonDet obj = new ERespuestaSalonDet();
            string resMen = string.Empty;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("DetalleSalon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 2 });
                    com.Parameters.Add(new SqlParameter("@fiIdDetalleSalon", SqlDbType.Int) { Value = fiIdDetalleSalon });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    resMen = com.Parameters["@Mensaje"].Value.ToString();
                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
            obj.Tabla = dt;
            obj.Mensaje = resMen;
            return obj;
        }
        public string postSalonDetalle(string fcCorreo, string fcTelefono,
                                       string fcCalle, string fcColonia, string fcDelegacion,
                                       string fcCPostal, string fcReferencias,
                                       string fcEntreCalles, int fiIdSalon, int fiIdCapacidad
                                      )
        {
            string resMen = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("DetalleSalon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 3 });
                    com.Parameters.Add(new SqlParameter("@fcCorreo", SqlDbType.NVarChar, 200) { Value = fcCorreo });
                    com.Parameters.Add(new SqlParameter("@fcTelefono", SqlDbType.NVarChar, 200) { Value = fcTelefono });
                    com.Parameters.Add(new SqlParameter("@fcCalle", SqlDbType.NVarChar, 200) { Value = fcCalle });
                    com.Parameters.Add(new SqlParameter("@fcColonia", SqlDbType.NVarChar, 200) { Value = fcColonia });
                    com.Parameters.Add(new SqlParameter("@fcDelegacion", SqlDbType.NVarChar, 200) { Value = fcDelegacion });
                    com.Parameters.Add(new SqlParameter("@fcCPostal", SqlDbType.NVarChar, 200) { Value = fcCPostal });
                    com.Parameters.Add(new SqlParameter("@fcReferencias", SqlDbType.NVarChar, 200) { Value = fcReferencias });
                    com.Parameters.Add(new SqlParameter("@fcEntreCalles", SqlDbType.NVarChar, 200) { Value = fcEntreCalles });
                    com.Parameters.Add(new SqlParameter("@fiIdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    com.Parameters.Add(new SqlParameter("@fiIdCapacidad", SqlDbType.Int) { Value = fiIdCapacidad });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    resMen = com.Parameters["@Mensaje"].Value.ToString();
                }
                con.Close();
            }
            return resMen;
        }
        public string putSalonDetalle(string fcCorreo, string fcTelefono,
                                      string fcCalle, string fcColonia, string fcDelegacion,
                                      string fcCPostal, string fcReferencias,
                                      string fcEntreCalles, int fiIdSalon, int fiIdCapacidad
                                     )
        {
            string resMen = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("DetalleSalon_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 4 });
                    com.Parameters.Add(new SqlParameter("@fcCorreo", SqlDbType.NVarChar, 200) { Value = fcCorreo });
                    com.Parameters.Add(new SqlParameter("@fcTelefono", SqlDbType.NVarChar, 200) { Value = fcTelefono });
                    com.Parameters.Add(new SqlParameter("@fcCalle", SqlDbType.NVarChar, 200) { Value = fcCalle });
                    com.Parameters.Add(new SqlParameter("@fcColonia", SqlDbType.NVarChar, 200) { Value = fcColonia });
                    com.Parameters.Add(new SqlParameter("@fcDelegacion", SqlDbType.NVarChar, 200) { Value = fcDelegacion });
                    com.Parameters.Add(new SqlParameter("@fcCPostal", SqlDbType.NVarChar, 200) { Value = fcCPostal });
                    com.Parameters.Add(new SqlParameter("@fcReferencias", SqlDbType.NVarChar, 200) { Value = fcReferencias });
                    com.Parameters.Add(new SqlParameter("@fcEntreCalles", SqlDbType.NVarChar, 200) { Value = fcEntreCalles });
                    com.Parameters.Add(new SqlParameter("@fiIdSalon", SqlDbType.Int) { Value = fiIdSalon });
                    com.Parameters.Add(new SqlParameter("@fiIdCapacidad", SqlDbType.Int) { Value = fiIdCapacidad });
                    com.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    resMen = com.Parameters["@Mensaje"].Value.ToString();
                }
                con.Close();
            }
            return resMen;
        }
    }
}
