using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.EntityTresCapas
{
    public class ERespuestaSalon
    {
        public string Mensaje { get; set; }
        public DataTable Tabla { get; set; }
    }

    public class ERespuestaSalonList
    {
        public string Mensaje { get; set; }
        public List<ESalon> listSalones { get; set; }
        public ESalon Salon { get; set; }
        public List<ECatalogoTipoSalon> listTipoSalon { get; set; }
        public List<ECatalogoTipoUsuario> listTipoUsuario{ get; set; }
        public int Codigo { get; set; }
    }

}
