using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;

namespace mazda_web.Controllers
{
    public class ElementsController : SurfaceController
    {
        // GET: Elements
        private const string Partial_Views_Path = "~/Views/Partials/Elements/";
        public ActionResult Elements()
        {
            return PartialView(string.Format("{0}Elements.cshtml", Partial_Views_Path));
        }
    }
}