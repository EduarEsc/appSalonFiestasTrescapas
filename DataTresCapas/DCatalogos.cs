using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.DataTresCapas
{
    public class DCatalogos: DAbstracta
    {
        public DataTable getCatalogoSalon()
        {
            DataTable dt = new DataTable();
            string resMensaje = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("Catalogos_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 2 });
                    com.ExecuteNonQuery();
                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable getCatalogoTipoUsuario()
        {
            DataTable dt = new DataTable();
            string resMensaje = string.Empty;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("Catalogos_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 1 });
                    com.ExecuteNonQuery();
                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
