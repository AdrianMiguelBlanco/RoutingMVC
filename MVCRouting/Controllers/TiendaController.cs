using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRouting.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar()
        {
            String formato = RouteData.Values["formato"].ToString();
            String idproducto = RouteData.Values["id_producto"].ToString();

            String resultado = String.Empty;
            switch (formato.ToLower())
            {
                case "vinilos":
                    {
                        Debug.Write("------------------>"+idproducto+"<---------------");
                        switch (idproducto.ToLower())
                        {
                            case "rolling stone":
                                {
                                    resultado = "Hay 3 unidades disponibles";
                                    break;
                                }
                            case "scorpions":
                                {
                                    resultado = "Hay 23 unidades disponibles";
                                    break;
                                }
                            default:
                                {
                                    resultado = "El vinilo " + idproducto + " no está en stock";
                                    break;
                                }
                        }
                        break;
                    }
                case "cd":
                    {
                        switch (idproducto.ToLower())
                        {
                            case "queen":
                                {
                                    resultado = "Hay 8 unidades disponibles";
                                    break;
                                }
                            case "system of a down":
                                {
                                    resultado = "Hay 1 unidad disponible";
                                    break;
                                }
                            default:
                                {
                                    resultado = String.Format("El CD " + idproducto + " no está en stock");
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    break;
            }
            return Content("<h2 style='color:blueviolet'>" + resultado + "</h2>");
        }        
    }
}
