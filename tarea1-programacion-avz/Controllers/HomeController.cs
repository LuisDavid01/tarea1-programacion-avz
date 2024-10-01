using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tarea1_programacion_avz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.mensaje = "prueba mvc";
            string[] playlist = new string[5] {
                "hola",
                "adios",
                "3",
                "4",
                "5"
            };
            ViewBag.playlist = playlist;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}