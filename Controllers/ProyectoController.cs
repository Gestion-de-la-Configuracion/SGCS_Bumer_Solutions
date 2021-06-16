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
    public class ProyectoController : Controller
    {
        USUARIO usuario = new USUARIO();
        PROYECTO proyecto = new PROYECTO();
        METODOLOGIA metodologia = new METODOLOGIA();

        // GET: Proyecto
        public ActionResult Index()
        {
            ViewBag.Usuario = usuario.ListarTodo();
            ViewBag.Metodologia = metodologia.ListarTodo();
            return View(proyecto.ListarTodo());
        }

        public ActionResult Guardar(PROYECTO proyecto)
        {
            if (ModelState.IsValid)
            {
                proyecto.Guardar();
                return Redirect("~/Proyecto/Index");
            }
            else
            {
                return View("~/Proyecto/Index");
            }
        }
    }
}