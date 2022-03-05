using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingControllersAndViews.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greet()
        {
            //passing data from action method to view
            string uname = "David";
            //set value in ViewData
            ViewData["un"] = uname;
            return View();
        }
        public IActionResult Details(string name)
        {
            string un = name;
            ViewData["k"] = name;
            return View();
        }
        public IActionResult GetCities()
        {
            ViewData["cities"] = new string[] { "Hyderabad", "Banglore", "Chennai", "Pune", "Kolkatha" };
            return View();
        }
    }
}
