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
    public class BUsuarioSalon
    {

        public ERespuestaUsuarioSalon getUsuarioSalon(int idSalon)
        {
            ERespuesta obj = new DUsuarioSalon().getUsuarioSalon(idSalon);
            ERespuestaUsuarioSalon objr = new ERespuestaUsuarioSalon();
            List<EUsuarioSalon> list = new List<EUsuarioSalon>();
            foreach (DataRow q in obj.Tabla.Rows)
            {
                EUsuarioSalon s = new EUsuarioSalon();
                s.IdUsuarioSalon = Convert.ToInt32(q["fiIdUsuarioSalon"]);
                s.NombreUsuario = Convert.ToString(q["fcNombreUsuario"]);
                s.Contraseña = Convert.ToString(q["fcContraseña"]);
                s.IdSalon = Convert.ToInt32(q["fiIdSalon"]);
                s.NombreSalon = Convert.ToString(q["fcNombreSalon"]);
                s.IdTipoUsuario = Convert.ToInt32(q["fiIdTipoUsuario"]);
                s.Descripcion = Convert.ToString(q["fcDescripcion"]);
                s.EsActivo = Convert.ToBoolean(q["fbEsActivo"]);
                list.Add(s);
            }
            objr.listUsuarioSalon = list;
            string[] array = obj.Mensaje.Split(',');
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }


        public ERespuestaUsuarioSalon getUsuarioSalonDetalle(int idUsuarioSalon)
        {
            ERespuesta obj = new DUsuarioSalon().getUsuarioSalonDetalle(idUsuarioSalon);
            ERespuestaUsuarioSalon objr = new ERespuestaUsuarioSalon();
            EUsuarioSalon s = new EUsuarioSalon();
            foreach (DataRow q in obj.Tabla.Rows)
            {
                s.IdUsuarioSalon = Convert.ToInt32(q["fiIdUsuarioSalon"]);
                s.NombreUsuario = Convert.ToString(q["fcNombreUsuario"]);
                s.Contraseña = Convert.ToString(q["fcContraseña"]);
                s.IdSalon = Convert.ToInt32(q["fiIdSalon"]);
                s.NombreSalon = Convert.ToString(q["fcNombreSalon"]);
                s.IdTipoUsuario = Convert.ToInt32(q["fiIdTipoUsuario"]);
                s.Descripcion = Convert.ToString(q["fcDescripcion"]);
                s.EsActivo = Convert.ToBoolean(q["fbEsActivo"]);
            }
            objr.UsuarioSalon = s;
            string[] array = obj.Mensaje.Split(',');
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }


        public ERespuestaUsuarioSalon postUsuarioSalon(string fcNombreUsuario, string fcContraseña,
                                      int fiIdSalon, int fiIdTipoUsuario, bool fbEsActivo
                                     )
        {
            string res = new DUsuarioSalon().postUsuarioSalon(fcNombreUsuario, fcContraseña,
                                                   fiIdSalon, fiIdTipoUsuario, fbEsActivo
                                                 );

            ERespuestaUsuarioSalon objr = new ERespuestaUsuarioSalon();
            string[] array = res.Split(',');
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }



        public ERespuestaUsuarioSalon putUsuarioSalon(int fiIdUsuarioSalon, string fcNombreUsuario, string fcContraseña,
                                     int fiIdSalon, int fiIdTipoUsuario, bool fbEsActivo
                                     )
        {
             
            string[] array = new DUsuarioSalon().putUsuarioSalon(fiIdUsuarioSalon, fcNombreUsuario, fcContraseña,
                                                   fiIdSalon, fiIdTipoUsuario, fbEsActivo
                                                 ).Split(',');
            ERespuestaUsuarioSalon objr = new ERespuestaUsuarioSalon();
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }


        public ERespuestaUsuarioSalon AccesoUsuarioSalon(int fiIdUsuarioSalon, string fcNombreUsuario, string fcContraseña,
                                     int fiIdSalon, int fiIdTipoUsuario, bool fbEsActivo
                                     )
        {

            string[] array = new DUsuarioSalon().AccesoUsuarioSalon(fiIdUsuarioSalon, fcNombreUsuario, fcContraseña,
                                                   fiIdSalon, fiIdTipoUsuario, fbEsActivo
                                                 ).Split(',');
            ERespuestaUsuarioSalon objr = new ERespuestaUsuarioSalon();
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }
    }
}
