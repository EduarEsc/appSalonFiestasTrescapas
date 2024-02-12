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
            new BSalon().postSalon(Salon.NombreSalon, Salon.Contraseña, Salon.IdTipoUsuario, Salon.IdSalon, Salon.EsActivo);


            return RedirectToAction("LoginSalon");
        }

        public ActionResult putSalon()

        {
            new BSalon().putSalon(1, "Juan", "hui", 1, 1, true);


            return View("LoginSalon");
        }
        public ActionResult AccesoUsuarioSalon()
        {
            //new BUsuarioSalon().AccesoUsuarioSalon(Usuario.IdUsuarioSalon, Usuario.NombreUsuario, Usuario.Contraseña, Usuario.IdSalon, Usuario.IdTipoUsuario, Usuario.EsActivo);


            return View();
        }


        [HttpPost]
        public ActionResult getAccesoUsuarioSalon(EUsuarioSalon Usuario)
        {

            return RedirectToAction("AccesoUsuarioSalon");
        }
        }
}