using SharinganSolutions.BussinesTresCapas;
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
        public ActionResult LoginUsuarioSalon()
        {
            new BUsuarioSalon().getUsuarioSalon(1);

            return View("LoginUsuarioSalon");
        }

        public ActionResult getUsuarioSalonDetalle()
        {
            new BUsuarioSalon().getUsuarioSalonDetalle(1);

            return View("LoginUsuarioSalon");
        }


        public ActionResult postUsuarioSalon()

        {
            new BUsuarioSalon().postUsuarioSalon("Gabriela", "QWAe$%", 2, 1, true);


            return View("LoginUsuarioSalon");
        }

        public ActionResult putUsuarioSalon()

        {
            new BUsuarioSalon().putUsuarioSalon(36, "Gabriela", "QWAe$%", 2, 1, true);


            return View("LoginUsuarioSalon");
        }



    }
}