using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppA.Controllers
{
    public class HomeController : Controller
    {
        private EF context = new EF();

        public ActionResult Index()
        {
            context.Accounts.Add(new Account()
            {
                Name = "Test",
                DateCreated = DateTimeOffset.Now
            });

            context.SaveChanges();
            
            return View();
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