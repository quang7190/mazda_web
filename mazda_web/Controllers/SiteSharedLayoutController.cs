using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace mazda_web.Controllers
{
    public class SiteSharedLayoutController : SurfaceController
    {
        // GET: SiteSharedLayout
        private const string Partial_Views_Path = "~/Views/Partials/SharedLayout/";
        public ActionResult RenderHeader()
        {
            return PartialView(string.Format("{0}Header.cshtml", Partial_Views_Path));
        }

        public ActionResult RenderFooter()
        {
            return PartialView(string.Format("{0}Footer.cshtml", Partial_Views_Path));
        }
    }
}