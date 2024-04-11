using Microsoft.VisualBasic.ApplicationServices;
using SharinganSolutions.BussinesTresCapas;
using SharinganSolutions.EntityTresCapas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appSalonFiestasTrescapas.Controllers
{
    public class LoginSalonController : Controller
    {
        public ActionResult LoginSalonHome()
        {
            return View();
        }
        public ActionResult LoginSalon()
        {
            ERespuestaSalonList obj = new BSalon().getSalon();
            obj.listTipoSalon = new BCatalogoSalon().getCatalogoTipoSalon();
            obj.listTipoUsuario = new BCatalogoSalon().getCatalogoTipoUsuario();
            obj.listCapacidad = new BCatalogoSalonDet().getCatalogoSalonDetCapacidad();
            return View(obj);
        }

        [HttpGet]
        public ActionResult getSalonDetalle(int Id)
        {

            ESalon obj = new BSalon().getSalonDetalle(Id); // vas por salon 
            ESalonDetalle obj1 = new BSalonDetalle().getSalonDetalle1(Id); // vas por detalle 
            ESalon res = new ESalon();
            res.NombreSalon = obj.NombreSalon;
            res.Contraseña = obj.Contraseña;
            res.IdTipoUsuario = obj.IdTipoUsuario;
            res.IdTipoSalon = obj.IdTipoSalon;
            res.EsActivo = obj.EsActivo;
            res.Correo = obj1.Correo;
            res.Telefono = obj1.Telefono;
            res.Calle = obj1.Calle;
            res.Colonia = obj1.Colonia;
            res.Delegacion = obj1.Delegacion;
            res.CPostal = obj1.CPostal;
            res.Referencias = obj1.Referencias;
            res.EntreCalles = obj1.EntreCalles;
            res.IdCapacidad = obj1.IdCapacidad;
            res.Capacidad = obj1.Capacidad;
            res.IdSalon = obj1.IdSalon;
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult postSalon(ESalon Salon)
        {
            ERespuestaSalonList obj  = new ERespuestaSalonList();
            obj = new BSalon().postSalon(Salon.NombreSalon, Salon.Contraseña, Salon.IdTipoUsuario, Salon.IdTipoSalon, Salon.EsActivo);


            new BSalonDetalle().postSalonDetalle(Salon.Correo, Salon.Telefono, Salon.Calle, Salon.Colonia,
                                                 Salon.Delegacion, Salon.CPostal, Salon.Referencias,
                                                 Salon.EntreCalles, obj.Codigo, Salon.Capacidad);


            return RedirectToAction("LoginSalon");
        }

        public ActionResult putSalon(ESalon salon)
        {
            new BSalon().putSalon(salon.IdSalon, salon.NombreSalon, salon.Contraseña, salon.IdTipoUsuario, salon.IdTipoSalon, salon.EsActivo);
            new BSalonDetalle().putSalonDetalle(salon.Correo, salon.Telefono, salon.Calle, salon.Colonia, salon.Delegacion, salon.CPostal, salon.Referencias, salon.EntreCalles, salon.IdSalon, salon.Capacidad);


            return RedirectToAction("LoginSalon");
        }
      
    }
}