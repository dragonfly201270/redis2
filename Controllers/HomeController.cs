using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Caching.Redis;


namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            HttpContext.Session.SetString("Test", "Ben Rulesouhfgrhngflrgweigioerhhguhntgj!");
            return View(true);


        }

        public IActionResult About()
        {

            ViewBag.Message = HttpContext.Session.GetString("Test");

            return View();

        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
