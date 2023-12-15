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
    public class BCatalogoSalonDet
    {

        public List<ECatalogoSalonDetTipSalon> getCatalogoSalonDetTipSalon()
        {
            DataTable obj = new DCatalogosSalon().getCatalogoTipoSalon();
            List<ECatalogoSalonDetTipSalon> list = new List<ECatalogoSalonDetTipSalon>();
            foreach (DataRow q in obj.Rows)
            {
                ECatalogoSalonDetTipSalon t = new ECatalogoSalonDetTipSalon();
                t.IdTipoSalon = Convert.ToInt32(q["fiIdTipoSalon"]);
                t.Descripcion = Convert.ToString(q["fcDescripcion"]);
                list.Add(t);
            }
            return list;
        }
        public List<ECatalogoSalonDetCapacidad> getCatalogoSalonDetCapacidad()
        {
            DataTable obj = new DCatalogosSalon().getCatalogoTipoUsuario();
            List<ECatalogoSalonDetCapacidad> list = new List<ECatalogoSalonDetCapacidad>();
            foreach (DataRow q in obj.Rows)
            {
                ECatalogoSalonDetCapacidad s = new ECatalogoSalonDetCapacidad();
                s.IdCapacidad = Convert.ToInt32(q["fiIdCapacidad"]);
                s.Capacidad = Convert.ToInt32(q["fiCapacidad"]);
                list.Add(s);
            }
            return list;
        }
    }
}
