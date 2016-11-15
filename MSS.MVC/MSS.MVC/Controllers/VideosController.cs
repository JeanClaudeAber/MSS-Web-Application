using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSS.MVC.Controllers
{
    public class VideosController : Controller
    {
        // GET: Videos
        public ActionResult AllVideos()
        {
            return View();
        }
    }
}