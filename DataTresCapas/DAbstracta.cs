using SharinganSolutions.DataTresCapas.AES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.DataTresCapas
{
    public abstract class DAbstracta
    {
        private string conexion;

        public string Conexion
        {
            get { return conexion = desencriptar(); }


            set { conexion = value; }
        }

        public string desencriptar()
        {
            //return new Encryptar().DecryptTextWithAES(ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString , "qwerty1234Aldo4567luis23456eduar");
            return new Encryptar().DecryptTextWithAES(ConfigurationManager.ConnectionStrings["CadenaEduar"].ConnectionString, "qwerty1234Aldo4567luis23456eduar");
        }

    }
}
