using System;
using System.Linq;
using System.Web.Mvc;
using TSP_ASPLayer.Models;
using TSP_ASPLayer.WcfService;

namespace TSP_ASPLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly FestivalClient _db = new FestivalClient();

        public ActionResult Index()
        {
            var data = _db.GetAllFestivals().ToList().OrderBy(f => f.DateAndTime);
            return View(data);
        }

        [Authorize]
        public ActionResult AddFestival()
        {
            return View();
        }


        [Authorize]
        [HttpPost]
        public ActionResult AddFestival(ProxyFestivalModels festival)
        {
            festival.ProxyLocation.Id = Guid.NewGuid();
            var performerNamesToAdd = festival.ProxyPerformers.Trim().Split(',');

            var artists = new Performer[performerNamesToAdd.Length];
            for (var i = 0; i < performerNamesToAdd.Length; i++)
            {
                artists[i] = new Performer
                {
                    Id = Guid.NewGuid(),
                    Name = performerNamesToAdd[i].Trim(),
                    RequestedPay = "as much as possible"
                };
            }

            var toSubmit = new Festival
            {
                Id = Guid.NewGuid(),
                DateAndTime = festival.ProxyDateAndTime,
                Location = festival.ProxyLocation,
                Performers = artists,
                Name = festival.ProxyName.Trim()
            };

            ModelState.Clear();
            _db.CreateNewFestival(toSubmit);
            return View();
        }

        [Authorize]
        public ActionResult EditFestival()
        {
            return View(_db.GetAllFestivals());
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditFestival(string festivalName)
        {
            return View();
        }
    }
}