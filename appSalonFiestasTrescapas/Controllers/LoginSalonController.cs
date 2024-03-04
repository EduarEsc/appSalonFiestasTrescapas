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

        public ActionResult getSalonDetalle()
        {

            new BSalon().getSalonDetalle(1);

            return View("LoginSalon");
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

        public ActionResult putSalon()

        {
            new BSalon().putSalon(1, "Juan", "hui", 1, 1, true);


            return View("LoginSalon");
        }
      
    }
}