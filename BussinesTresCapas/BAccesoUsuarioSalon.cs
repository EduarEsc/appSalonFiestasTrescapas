using SharinganSolutions.DataTresCapas;
using SharinganSolutions.EntityTresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SharinganSolutions.BussinesTresCapas
{
    public class BAccesoUsuarioSalon
    {
        public bool Accesousuarios(int idusuario, string password)
        {

            bool Acceso;
            string Mensaje = new DAccesoUsuarioSalon().PostAccesoUsuarioSalon(idusuario, password);
            if (Mensaje == "Usuario válido")
            {

                Acceso = true;
            }
            else
            {
                Acceso = false;
            }


            return Acceso;
        }
    }
}
