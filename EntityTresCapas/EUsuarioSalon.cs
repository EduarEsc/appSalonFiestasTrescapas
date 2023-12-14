using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.EntityTresCapas
{
    public class EUsuarioSalon
    {
        public int IdUsuarioSalon { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int IdSalon { get; set; }
        public int IdTipoUsuario { get; set; }
        public bool EsActivo { get; set; }
        public string NombreSalon { get; set; }
        public string Descripcion { get; set; }
    }
}
