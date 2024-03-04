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
        public int IdDetalleSalon { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Delegacion { get; set; }
        public string CPostal { get; set; }
        public string Referencias { get; set; }
        public string EntreCalles { get; set; }
        public int Capacidad { get; set; }
    }
}
