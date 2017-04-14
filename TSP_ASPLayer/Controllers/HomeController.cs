using System.Linq;
using System.Web.Mvc;
using TSP_ASPLayer.WcfService;

namespace TSP_ASPLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly FestivalClient _db = new FestivalClient();

        public ActionResult Index()
        {
            var data = _db.GetAllFestivals().ToList().OrderByDescending(f=>f.DateAndTime);
            return View(data);
        }

        public ActionResult AddFestival()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult AddFestival(Festival festival)
        {

            return View();
        }


        public ActionResult EditFestival()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}