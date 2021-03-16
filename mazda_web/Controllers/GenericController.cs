using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace mazda_web.Controllers
{
    public class GenericController : SurfaceController
    {
        // GET: Generic
        private const string Partial_Views_Path = "~/Views/Partials/Generic/";
        public ActionResult Generic()
        {
            return PartialView(string.Format("{0}Generic.cshtml", Partial_Views_Path));
        }
    }
}