using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExemploCORS.Models;
using Microsoft.AspNetCore.Cors;

namespace ExemploCORS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet()]
        [EnableCors("AllowSpecificOrigin")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet()]
        [DisableCors()]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
