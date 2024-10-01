using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tarea1_programacion_avz.Controllers
{
    public class YoutubePlaylistController : Controller
    {
        // GET: YoutubePlaylist
        public ActionResult Index()
        {
            string[] playlist = new string[5] {
                "https://www.youtube.com/watch?v=2JPIFEtMJ6o",
                "https://www.youtube.com/watch?v=TMzs6GvsZXU",
                "https://www.youtube.com/watch?v=YJAKnSvAs8Y",
                "https://www.youtube.com/watch?v=rRin8TdvE1o",
                "https://www.youtube.com/watch?v=oig3Mqg7rzs"
            };
            ViewBag.playlist = playlist;
            return View();
        }
    }
}