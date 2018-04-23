using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartLesson3.Controllers {
    public class ChartController : Controller {
        public ActionResult Index() {
            using (var dbContext = new Models.GspDbContext()) {
                return View(dbContext.GSPs.ToList());
            }
        }
    }
}
