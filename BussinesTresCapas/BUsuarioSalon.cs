using SharinganSolutions.DataTresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.BussinesTresCapas
{
    public class BUsuarioSalon
    {

        public void getUsuarioSalon(int idSalon)
        {
            DataTable dt = new DUsuarioSalon().getUsuarioSalon(idSalon);
        }


        public void getUsuarioSalonDetalle(int idUsuarioSalon)
        {
            DataTable dt = new DUsuarioSalon().getUsuarioSalonDetalle(idUsuarioSalon);
        }


        public void postUsuarioSalon(string fcNombreUsuario, string fcContraseña,
                                      int fiIdSalon, int fiIdTipoUsuario, bool fbEsActivo
                                     )
        {
            new DUsuarioSalon().postUsuarioSalon(fcNombreUsuario, fcContraseña,
                                                   fiIdSalon, fiIdTipoUsuario, fbEsActivo
                                                 );
        }



        public void putUsuarioSalon(int fiIdUsuarioSalon, string fcNombreUsuario, string fcContraseña,
                                     int fiIdSalon, int fiIdTipoUsuario, bool fbEsActivo
                                     )
        {
            new DUsuarioSalon().putUsuarioSalon(fiIdUsuarioSalon, fcNombreUsuario, fcContraseña,
                                                   fiIdSalon, fiIdTipoUsuario, fbEsActivo
                                                 );
        }

    }
}
