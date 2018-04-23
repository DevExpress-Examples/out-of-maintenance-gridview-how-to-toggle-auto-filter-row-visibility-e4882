using System;
using System.Web.Mvc;
using E4882.Models;

namespace E4882.Controllers {
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