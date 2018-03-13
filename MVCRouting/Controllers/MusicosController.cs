using MVCRouting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouting.Controllers
{
    public class MusicosController : Controller
    {
        ModeloMusico modelo;

        public MusicosController()
        {
            modelo = new ModeloMusico();
        }

        // GET: Index
        public ActionResult Index()
        {
            List<MUSICOS> lista = modelo.GetMusicos();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Eliminar(int idmusico)
        {
            MUSICOS musico = modelo.BuscarMusico(idmusico);
            return View(musico);
        }


        [Route("Musicos/Elimina")]
        [HttpPost]
        public ActionResult EliminarMusicos(int id)
        {
            modelo.EliminarMusico(id);
            return RedirectToAction("Index");
        }

    }
}
