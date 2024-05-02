using SharinganSolutions.DataTresCapas;
using SharinganSolutions.EntityTresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.BussinesTresCapas
{

    public class BSalon
    {
        public ERespuestaSalonList getSalon()
        {
            ERespuestaSalon obj = new DSalon().getSalon();
            ERespuestaSalonList objr = new ERespuestaSalonList();
            List<ESalon> list = new List<ESalon>();
            foreach (DataRow q in obj.Tabla.Rows)
            {
                ESalon s = new ESalon(); 
                s.IdSalon = Convert.ToInt32(q["fiIdSalon"]);
                s.NombreSalon = Convert.ToString(q["fcNombreSalon"]);
                s.Contraseña = Convert.ToString(q["fcContraseña"]);
                s.IdTipoUsuario = Convert.ToInt32(q["fiIdTipoUsuario"]);
                s.IdTipoSalon = Convert.ToInt32(q["fiIdTipoSalon"]);
                s.EsActivo = Convert.ToBoolean(q["fbEsActivo"]);
                list.Add(s);
            }
            objr.listSalones = list;
            string[] array = obj.Mensaje.Split(',');
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }
        public ESalon getSalonDetalle(int fiIdSalon)
        {
            ERespuestaSalon obj = new DSalon().getSalonDetalle(fiIdSalon);
            ESalon s = new ESalon();
            foreach (DataRow q in obj.Tabla.Rows)
            {
                
                //s.IdSalon = Convert.ToInt32(q["fiIdSalon"]);
                s.NombreSalon = Convert.ToString(q["fcNombreSalon"]);
                s.Contraseña = Convert.ToString(q["fcContraseña"]);
                s.IdTipoUsuario = Convert.ToInt32(q["fiIdTipoUsuario"]);
                s.IdTipoSalon = Convert.ToInt32(q["fiIdTipoSalon"]);
                s.EsActivo = Convert.ToBoolean(q["fbEsActivo"]);
            } 
            
            return s;
        }
        public ERespuestaSalonList postSalon(string fcNombreSalon, string fcContraseña,
                                             int fiIdTipoUsuario, int fiIdTipoSalon,
                                             bool fbEsActivo
                                            )
        {
            string res = new DSalon().postSalon(fcNombreSalon, fcContraseña,
                                                fiIdTipoUsuario, fiIdTipoSalon, fbEsActivo);

            ERespuestaSalonList objr = new ERespuestaSalonList();
            string[] array = res.Split(',');
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }
        public ERespuestaSalonList putSalon(int fiIdSalon, string fcNombreSalon,
                                            string fcContraseña, int fiIdTipoUsuario,
                                            int fiIdTipoSalon, bool fbEsActivo)
        {
              
            string[] array = new DSalon().putSalon(fiIdSalon, fcNombreSalon, fcContraseña,
                                                   fiIdTipoUsuario, fiIdTipoSalon, fbEsActivo).Split(',');
            ERespuestaSalonList objr = new ERespuestaSalonList();
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }

    }
}
