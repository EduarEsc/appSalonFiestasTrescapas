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

        public ActionResult getUsuarioSalonDetalle(int id)
        {

            ERespuestaUsuarioSalon obj = new BUsuarioSalon().getUsuarioSalonDetalle(id);
            var usuario = obj.UsuarioSalon;
            return Json(usuario, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult postUsuarioSalon(EUsuarioSalon Usuario)
        {
            new BUsuarioSalon().postUsuarioSalon(Usuario.NombreUsuario, Usuario.Contraseña,Usuario.IdSalon,Usuario.IdTipoUsuario , Usuario.EsActivo );


            return RedirectToAction("LoginUsuarioSalon");
        }

        [HttpPost]
        public ActionResult putUsuarioSalon(EUsuarioSalon Usuario)
        {
            new BUsuarioSalon().putUsuarioSalon(Usuario.IdUsuarioSalon, Usuario.NombreUsuario, Usuario.Contraseña, Usuario.IdSalon, Usuario.IdTipoUsuario, Usuario.EsActivo);


            return RedirectToAction("LoginUsuarioSalon");
        }

        public ActionResult AccesoUsuarioSalon()
        {
            //new BUsuarioSalon().AccesoUsuarioSalon(Usuario.IdUsuarioSalon, Usuario.NombreUsuario, Usuario.Contraseña, Usuario.IdSalon, Usuario.IdTipoUsuario, Usuario.EsActivo);


            return View();
        }


        [HttpPost]
        public ActionResult getAccesoUsuarioSalon(int IdUsuarioSalon, string Passwor)
        {
           bool respuesta = new BAccesoUsuarioSalon().Accesousuarios(IdUsuarioSalon, Passwor);

           return Json(respuesta, JsonRequestBehavior.AllowGet);

        }

    }
}