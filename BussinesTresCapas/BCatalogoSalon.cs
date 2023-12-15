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

    public class BCatalogoSalon
    {
        public List<ECatalogoTipoSalon> getCatalogoTipoSalon()
        {
            DataTable obj = new DCatalogosSalon().getCatalogoTipoSalon();
            List<ECatalogoTipoSalon> list = new List<ECatalogoTipoSalon>();
            foreach (DataRow q in obj.Rows)
            {
                ECatalogoTipoSalon t = new ECatalogoTipoSalon();
                t.IdTipoSalon = Convert.ToInt32(q["fiIdTipoSalon"]);
                t.Descripcion = Convert.ToString(q["fcDescripcion"]);
                list.Add(t);
            }
            return list;
        }
        public List<ECatalogoTipoUsuario> getCatalogoTipoUsuario()
        {
            DataTable obj = new DCatalogosSalon().getCatalogoTipoUsuario();
            List<ECatalogoTipoUsuario> list = new List<ECatalogoTipoUsuario>();
            foreach (DataRow q in obj.Rows)
            {
                ECatalogoTipoUsuario s = new ECatalogoTipoUsuario();
                s.IdTipoUsuario = Convert.ToInt32(q["fiIdTipoUsuario"]);
                s.Descripcion = Convert.ToString(q["fcDescripcion"]);
                list.Add(s);
            }
            return list;
        }
    }
}
