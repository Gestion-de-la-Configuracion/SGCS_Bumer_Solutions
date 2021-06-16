using SGCS_Bumer_Solutions.Models.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGCS_Bumer_Solutions.Controllers
{
    public class EtapaController : Controller
    {
        ETAPA etapa = new ETAPA();
        METODOLOGIA metodologia = new METODOLOGIA();

        // GET: Etapa
        public ActionResult Index()
        {
            ViewBag.Metodologia = metodologia.ListarTodo();
            return View(etapa.ListarTodo());
        }

        public ActionResult Guardar(ETAPA etapa)
        {
            if (ModelState.IsValid)
            {
                etapa.Guardar();
                return Redirect("~/Etapa/Index");
            }
            else
            {
                return View("~/Etapa/Index");
            }
        }
    }
}