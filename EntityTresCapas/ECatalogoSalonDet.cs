using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.EntityTresCapas
{
    public class ECatalogoSalonDetTipSalon
    {
        public int IdTipoSalon { get; set; }
        public string Descripcion { get; set; }
    }

    public class ECatalogoSalonDetCapacidad
    {
        public int IdCapacidad { get; set; }
        public int Capacidad { get; set; }
    }
}
