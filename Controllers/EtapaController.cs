using SGCS_Bumer_Solutions.Models.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static SGCS_Bumer_Solutions.Filtros.AdminFilters;

namespace SGCS_Bumer_Solutions.Controllers
{
    [Autenticado]
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

        public ActionResult EditEta(int id = 0)
        {
            ViewBag.Metodologia = metodologia.ListarTodo();
            return View(id == 0 ? new ETAPA() : etapa.ObtenerEtapa(id));
        }

        public ActionResult Eliminar(int id)
        {
            etapa.ID_ETAPA = id;
            etapa.Eliminar();
            return Redirect("~/Etapa/Index");
        }

        public ActionResult Habilitar(int id)
        {
            etapa.ID_ETAPA = id;
            etapa.Habilitar();
            return Redirect("~/Etapa/Index");
        }
    }
}