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
        public ActionResult LoginSalon()
        {
            BSalon bSalon = new BSalon();
            List<ESalon> lsSalon = new List<ESalon>();
            lsSalon = bSalon.getSalon();
            ViewData["Entidades"] = lsSalon;
            return View();
        }
       
    }
}