using SharinganSolutions.DataTresCapas;
using SharinganSolutions.EntityTresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.BussinesTresCapas
{
    public class BCatalogos
    {
        public List<ECatalogosTipoUsuario> getCatalogoTipoUsuario()
        {
            DataTable obj = new DCatalogos().getCatalogoTipoUsuario();
            List<ECatalogosTipoUsuario> list = new List<ECatalogosTipoUsuario>();
            foreach (DataRow q in obj.Rows)
            {
                ECatalogosTipoUsuario s = new ECatalogosTipoUsuario();
                s.IdTipoUsuario = Convert.ToInt32(q["fiIdTipoUsuario"]);
                s.Descripcion = Convert.ToString(q["fcDescripcion"]);
                list.Add(s);
            }
        
            return list;
        }
        public List<ECatalogosSalon> getCatalogoSalon()
        {
            DataTable obj = new DCatalogos().getCatalogoSalon();
            List<ECatalogosSalon> list = new List<ECatalogosSalon>();
            foreach (DataRow q in obj.Rows)
            {
                ECatalogosSalon s = new ECatalogosSalon();
                s.IdSalon = Convert.ToInt32(q["fiIdSalon"]);
                s.NombreSalon = Convert.ToString(q["fcNombreSalon"]);
                list.Add(s);
            }

            return list;
        }
    }
}
