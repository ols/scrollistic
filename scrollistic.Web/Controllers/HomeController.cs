using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DevTrends.MvcDonutCaching;

namespace searchtactics.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Car> _list = new List<Car>();

        public HomeController()
        {
            for (var i = 0; i < 500; i++)
            {
                _list.Add(new Car
                {
                    Id = i.ToString(),
                    Name = "Kajottsi" + i
                });
            }
        }

        [DonutOutputCache(CacheProfile = "Short")]
        public ActionResult Index()
        {
            var model = new MyModel
            {
                List = _list
                    .Take(128)
                    .ToList()
            };
            return View(model);
        }

        public JsonResult Search(string input, int page, int skip, int take)
        {
            int _take = take > 0 ? take : 128;
            int _skip = page*take;

            List<Car> result = _list
                .Skip(_skip)
                .Take(_take)
                .ToList();

            var jsonResults = new
            {
                TotalResults = _list.Count,
                Cars = result
            };

            return Json(jsonResults, JsonRequestBehavior.AllowGet);
        }
    }

    public class MyModel
    {
        public List<Car> List { get; set; }
    }

    public class Car
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}