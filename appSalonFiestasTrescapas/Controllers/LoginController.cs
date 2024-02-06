using SharinganSolutions.BussinesTresCapas;
using SharinganSolutions.EntityTresCapas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appSalonFiestasTrescapas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult LoginUsuarioSalon()
        {
            ERespuestaUsuarioSalon obj =  new BUsuarioSalon().getUsuarioSalon(1);
            obj.ListCargo = new BCatalogos().getCatalogoTipoUsuario();
            obj.listSalon = new BCatalogos().getCatalogoSalon();
            return View(obj);
        }

        public ActionResult getUsuarioSalonDetalle()
        {

            new BUsuarioSalon().getUsuarioSalonDetalle(1);

            return View("LoginUsuarioSalon");
        }

        [HttpPost]
        public ActionResult postUsuarioSalon(EUsuarioSalon Usuario)
        {
            new BUsuarioSalon().postUsuarioSalon(Usuario.NombreUsuario, Usuario.Contraseña,Usuario.IdSalon,Usuario.IdTipoUsuario , Usuario.EsActivo );


            return RedirectToAction("LoginUsuarioSalon");
        }

        public ActionResult putUsuarioSalon()

        {
            new BUsuarioSalon().putUsuarioSalon(36, "Gabriela", "QWAe$%", 2, 1, true);


            return View("LoginUsuarioSalon");
        }

    }
}