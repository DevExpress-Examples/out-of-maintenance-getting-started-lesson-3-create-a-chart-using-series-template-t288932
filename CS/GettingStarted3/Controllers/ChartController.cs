using GettingStarted3.Models;
using System.Web.Mvc;

namespace GettingStarted3.Controllers {
    public class ChartController : Controller {
        public ActionResult Index() {
            return View(new GdpProvider(Server.MapPath("~/App_Data/GDPofG7.xml")).GetGdps());
        }
    }
}