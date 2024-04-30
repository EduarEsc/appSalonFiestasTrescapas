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

    public class BSalonDetalle
    {
        public ERespuestaSalonDetList getSalonDetalle(int IdDetalle)
        {
            ERespuestaSalonDet obj = new DSalonDetalle().getSalonDetalle(IdDetalle);
            ERespuestaSalonDetList objr = new ERespuestaSalonDetList();
            List<ESalonDetalle> list = new List<ESalonDetalle>();
            foreach (DataRow q in obj.Tabla.Rows)
            {
                ESalonDetalle d = new ESalonDetalle();
                d.IdDetalleSalon = Convert.ToInt32(q["fiIdDetalleSalon"]);
                d.Correo = Convert.ToString(q["fcCorreo"]);
                d.Telefono = Convert.ToString(q["fcTelefono"]);
                d.Calle = Convert.ToString(q["fcCalle"]);
                d.Colonia = Convert.ToString(q["fcColonia"]);
                d.Delegacion = Convert.ToString(q["fcDelegacion"]);
                d.CPostal = Convert.ToString(q["fcCPostal"]);
                d.Referencias = Convert.ToString(q["fcReferencia"]);
                d.EntreCalles = Convert.ToString(q["fcEntreCalles"]);
                d.IdSalon = Convert.ToInt32(q["fiIdSalon"]);
                d.IdCapacidad = Convert.ToInt32(q["fiIdCapacidad"]);
                d.Capacidad = Convert.ToInt32(q["fiCapacidad"]);
                list.Add(d);
            }
            objr.listcDetalleSalones = list;
            string[] array = obj.Mensaje.Split(',');
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }

        public ESalonDetalle getSalonDetalle1(int fiIdSalon)
        {
            ERespuestaSalonDet obj = new DSalonDetalle().getSalonDetalle1(fiIdSalon);
            ESalonDetalle d = new ESalonDetalle();
            foreach (DataRow q in obj.Tabla.Rows)
            {
                d.IdDetalleSalon = Convert.ToInt32(q["fiIdDetalleSalon"]);
                d.Correo = Convert.ToString(q["fcCorreo"]);
                d.Telefono = Convert.ToString(q["fcTelefono"]);
                d.Calle = Convert.ToString(q["fcCalle"]);
                d.Colonia = Convert.ToString(q["fcColonia"]);
                d.Delegacion = Convert.ToString(q["fcDelegacion"]);
                d.CPostal = Convert.ToString(q["fcCPostal"]);
                d.Referencias = Convert.ToString(q["fcReferencia"]);
                d.EntreCalles = Convert.ToString(q["fcEntreCalles"]);
                d.IdSalon = Convert.ToInt32(q["fiIdSalon"]);
                d.IdCapacidad = Convert.ToInt32(q["fiIdCapacidad"]);
                d.Capacidad = Convert.ToInt32(q["fiCapacidad"]);
            }
            return d;
        }

        public ERespuestaSalonDetList postSalonDetalle(string fcCorreo, string fcTelefono,
                                                       string fcCalle, string fcColonia, 
                                                       string fcDelegacion, string fcCPostal, 
                                                       string fcReferencias, string fcEntreCalles, 
                                                       int fiIdSalon, int fiIdCapacidad
                                                      )
        {
            string res = new DSalonDetalle().postSalonDetalle(fcCorreo, fcTelefono, fcCalle, fcColonia,
                                                              fcDelegacion, fcCPostal, fcReferencias,
                                                              fcEntreCalles, fiIdSalon, fiIdCapacidad);

            ERespuestaSalonDetList objr = new ERespuestaSalonDetList();
            string[] array = res.Split(',');
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }
        public ERespuestaSalonDetList putSalonDetalle(int fiIdDetalleSalon, string fcCorreo, string fcTelefono, string fcCalle, 
                                                      string fcColonia, string fcDelegacion, 
                                                      string fcCPostal, string fcReferencias, 
                                                      string fcEntreCalles,int fiIdSalon,
                                                      int fiIdCapacidad)
        {

            string[] array = new DSalonDetalle().putSalonDetalle(fiIdDetalleSalon, fcCorreo, fcTelefono, fcCalle, fcColonia,
                                                                 fcDelegacion, fcCPostal, fcReferencias,
                                                                 fcEntreCalles, fiIdSalon, fiIdCapacidad).Split(',');
            ERespuestaSalonDetList objr = new ERespuestaSalonDetList();
            objr.Mensaje = array[1].Trim();
            objr.Codigo = Convert.ToInt32(array[0].Trim());
            return objr;
        }

    }
}
 