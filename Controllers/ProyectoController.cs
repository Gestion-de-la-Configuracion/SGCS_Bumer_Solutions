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

        public ActionResult Guardar(PROYECTO proyecto, string daterange)
        {
            if (!proyecto.DESCRIPCION.Equals("") && !daterange.Equals(""))
            {
                //split de la fecha
                string[] fechas = daterange.Split('-');
                proyecto.FECHA_INICIO = Convert.ToDateTime(fechas[0]);
                proyecto.FECHA_FIN = Convert.ToDateTime(fechas[1]);

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