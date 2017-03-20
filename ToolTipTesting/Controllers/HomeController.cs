using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolTipTesting.Models;

namespace ToolTipTesting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var person = new Person { Id = 2, FirstName = "Brian", LastName = "Cox" };
     
            return View(person);
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