using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.EntityTresCapas
{
    public class ERespuestaSalonDet
    {
        public string Mensaje { get; set; }
        public DataTable Tabla { get; set; }
    }
    public class ERespuestaSalonDetList
    {
        public string Mensaje { get; set; }
        public List<ESalonDetalle> listDetalleSalones { get; set; }
        public ESalonDetalle DetSalon { get; set; }
        public List<ECatalogoSalonDetTipSalon> listTipoSalon { get; set; }
        public List<ECatalogoSalonDetCapacidad> listCapacidad { get; set; }
        public int Codigo { get; set; }
    }

}
