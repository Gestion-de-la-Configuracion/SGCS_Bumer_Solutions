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
    public class UsuarioController : Controller
    {
        USUARIO usuario = new USUARIO();
        TIPO_USUARIO tipo_usuario = new TIPO_USUARIO();

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            ViewBag.Tipo = tipo_usuario.Listar();
            return View(usuario.ListarTodo());
        }

        public ActionResult Guardar(USUARIO usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Guardar();
                return Redirect("~/Usuario/Usuario");
            }
            else
            {
                return View("~/Usuario/Usuario");
            }
        }
    }
}