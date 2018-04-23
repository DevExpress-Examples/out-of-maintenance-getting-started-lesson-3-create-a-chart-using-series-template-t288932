using System.Linq;
using System.Web.Mvc;

namespace ChartLesson3.Controllers {
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            using (var dbContext = new Models.GspDbContext())
                return View(dbContext.GSPs.ToList());
        }
    }
}