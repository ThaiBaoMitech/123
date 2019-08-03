using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LangugeFeatures.Models;

namespace LangugeFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }
        public ActionResult AutoProperty()
        {
            Product myproduct = new Product();

            myproduct.Name = "Kayak5465456465";

            string productName = myproduct.Name;

            return View("Resual",(object)String.Format("ProductName: {0}",productName));
        }
    }
}