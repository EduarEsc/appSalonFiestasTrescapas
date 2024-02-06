using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.DataTresCapas
{
    public class DCatalogosSalonDet : DAbstracta
    {
        public DataTable getCatalogoTipoSalon()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion))
            {

                con.Open();
                using (SqlCommand com = new SqlCommand("CatalogosSalonDet_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 1 });
                    com.ExecuteNonQuery();
                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
            return dt;
        }
        public DataTable getCatalogoCapacidadSalon()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using(SqlCommand com = new SqlCommand("CatalogosSalonDet_sp", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@Accion", SqlDbType.Int) { Value = 2 });
                    com.ExecuteNonQuery();
                    using (SqlDataAdapter da = new SqlDataAdapter(com))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
            return dt;
        }
    }
}
