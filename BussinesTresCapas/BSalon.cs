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
    public class BSalon
    {
        public List<ESalon> getSalon()
        {
            List<ESalon> lsSalon = new List<ESalon>();
            DataTable dt = new DataTable();
            DSalon dSalon = new DSalon();
            dt = dSalon.getSalon();
            foreach (DataRow q in dt.Rows)
            {
                ESalon s = new ESalon();
                s.fcNombreSalon = q["fcNombreSalon"].ToString();
                s.fcContraseña = (string)q["fcContraseña"];
                s.fiIdTipoUsuario = Convert.ToInt32(q["fiIdTipoUsuario"]);
                s.fiIdTipoSalon = Convert.ToInt32(q["fiIdTipoSalon"]);
                s.fbEsActivo = (bool)q["fbEsActivo"];
                lsSalon.Add(s);
            }
            return lsSalon;
        }
        public ESalon getSalonDetalle(int Accion, int fiIdSalon)
        {
            DataTable dt = new DataTable();
            DSalon dSalon = new DSalon();
            dt = dSalon.getSalonDetalle(Accion, fiIdSalon);
            ESalon s = new ESalon();
            foreach (DataRow q in dt.Rows)
            {
                s.fcNombreSalon = q["fcNombreSalon"].ToString();
                s.fcContraseña = (string)q["fcContraseña"];
                s.fiIdTipoUsuario = Convert.ToInt32(q["fiTipoUsuario"]);
                s.fiIdTipoSalon = Convert.ToInt32(q["fiTipoUsuario"]);
                s.fbEsActivo = (bool)q["fbEsActivo"];
            }
            return s;
        }
    }
}
