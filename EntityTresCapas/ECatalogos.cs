using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.EntityTresCapas
{
    public class ECatalogosTipoUsuario
    {
        public int IdTipoUsuario { get; set; }
        public string Descripcion { get; set; }
    }
    public class ECatalogosSalon
    {
        public int IdSalon { get; set; }
        public string NombreSalon { get; set; }
    }
}
