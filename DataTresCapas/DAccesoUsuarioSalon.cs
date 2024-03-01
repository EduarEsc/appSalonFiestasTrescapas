using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SharinganSolutions.DataTresCapas
{
    public class DAccesoUsuarioSalon : DAbstracta
    {
        public string PostAccesoUsuarioSalon(int fiIdUsuarioSalon, string fcContraseña)
        {
            string res = string.Empty;

            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("SP_ValidarUsuario", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new SqlParameter("@fiIdUsuarioSalon", SqlDbType.Int) { Value = (fiIdUsuarioSalon) });
                    com.Parameters.Add(new SqlParameter("@fcContraseña", SqlDbType.NVarChar, 255) { Value = fcContraseña });
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




