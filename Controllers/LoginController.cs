using SGCS_Bumer_Solutions.Models.Base_de_Datos;
using SGCS_Bumer_Solutions.Models.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static SGCS_Bumer_Solutions.Filtros.AdminFilters;

namespace SGCS_Bumer_Solutions.Controllers
{
    public class LoginController : Controller
    {
        private USUARIO usuario = new USUARIO();

        [NoLogin]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Validar(string Codigo, string Contraseña)
        {
            var rm = usuario.ValidarLogin(Codigo, Contraseña);

            if (rm.response)
            {
                rm.href = Url.Content("/Default/Index");
            }
            else if (rm.response)
            {
                rm.href = Url.Content("/Login/Index");
            }
            return Json(rm);
        }


        public ActionResult Logout()
        {
            SessionHelper.DestroyUserSession();
            return Redirect("~/Login");
        }

    }
}