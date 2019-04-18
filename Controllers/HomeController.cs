using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new SalesEntities();
            db.Partners.Where(x => x.Address1 == "123 Main St")
                .Select(x => x.PartnerName);
            return View(db);
        }

        public ActionResult Add()
        {
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
