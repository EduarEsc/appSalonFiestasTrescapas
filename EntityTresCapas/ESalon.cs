using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.EntityTresCapas
{

    public class ESalon
    {
        public int IdSalon { get; set; }
        public string NombreSalon { get; set; }
        public string Contraseña { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdTipoSalon { get; set; }
        public bool EsActivo { get; set; }
    }
}
