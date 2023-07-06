using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DXWebApplication1.Models;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewData["AutoFilterRowVisible"] = true;
            return View(DataRepository.GetData());
        }
        public ActionResult GridViewPartial(bool visible) {
            return GridViewCorePartial(visible);
        }
        public ActionResult GridViewCustomActionPartial(bool visible) {
            return GridViewCorePartial(visible);
        }
        private ActionResult GridViewCorePartial(bool visible) {
            ViewData["AutoFilterRowVisible"] = visible;
            return PartialView("GridViewPartial", DataRepository.GetData());
        }
    }
}