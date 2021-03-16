using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace mazda_web.Controllers
{
    public class HomeController : SurfaceController
    {
        // GET: Home
        private const string Partial_Views_Path = "~/Views/Partials/Home/";
        public ActionResult Home()
        {
            return PartialView(string.Format("{0}Home.cshtml",Partial_Views_Path));
        }
    }
}