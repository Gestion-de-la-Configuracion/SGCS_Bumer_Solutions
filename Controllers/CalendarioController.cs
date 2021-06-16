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
    public class CalendarioController : Controller
    {
        PROYECTO proyecto = new PROYECTO();

        // GET: Calendario
        public ActionResult Index()
        {
            return View(proyecto.ListarTodo());
        }
    }
}