using SharinganSolutions.BussinesTresCapas;
using SharinganSolutions.EntityTresCapas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appSalonFiestasTrescapas.Controllers
{
    public class LoginSalonDetalleController : Controller
    {
        public ActionResult LoginSalonDetalleHome()
        {
            return View();
        }
        public ActionResult LoginSalonDetalle()
        {
            ERespuestaSalonDetList obj = new BSalonDetalle().getSalonDetalle(1);
            obj.listTipoSalon = new BCatalogoSalonDet().getCatalogoSalonDetTipSalon();
            obj.listCapacidad = new BCatalogoSalonDet().getCatalogoSalonDetCapacidad();
            return View(obj);
        }

        public ActionResult getSalonDetalle1()
        {

            new BSalon().getSalonDetalle(1);

            return View("LoginSalonDetalle");
        }

        [HttpPost]
        public ActionResult postSalonDetalle(ESalonDetalle DSalon)
        {
            new BSalonDetalle().postSalonDetalle(DSalon.Correo, DSalon.Telefono, DSalon.Calle, DSalon.Colonia,
                                                 DSalon.Delegacion, DSalon.CPostal, DSalon.Referencias,
                                                 DSalon.EntreCalles, DSalon.IdSalon, DSalon.Capacidad);


            return RedirectToAction("LoginSalonDetalle");
        }

        public ActionResult putSalonDetalle()

        {
            new BSalonDetalle().putSalonDetalle("uue", "63485957", "uue", "63485957", 
                                                "uue", "63485957", "uue", "63485957", 1, 3);


            return View("LoginSalon");
        }

    }
}
 