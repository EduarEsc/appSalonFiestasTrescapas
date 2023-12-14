using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.EntityTresCapas
{
    public class ERespuesta
    {
        public string Mensaje { get; set; }

        public DataTable Tabla { get; set; }
    }

    public class ERespuestaUsuarioSalon
    {
        public string Mensaje { get; set; }
        public List<EUsuarioSalon> listUsuarioSalon { get; set; }
        public EUsuarioSalon UsuarioSalon { get; set; }
        public int Codigo { get; set; }
        public List<ECatalogosSalon> listSalon { get; set; }
        public List<ECatalogosTipoUsuario> ListCargo { get; set; }
    }
}
