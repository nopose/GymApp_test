using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GymApp.Models;
using Newtonsoft.Json;

namespace GymApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var json = new WebClient().DownloadString("https://wger.de/api/v2/exercise/?limit=100&language=2&status=2");
            Result<Exercise> ob = JsonConvert.DeserializeObject<Result<Exercise>>(json);
            return View(ob);
        }

        public IActionResult Login()
        {
            return View(new User());
        }

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

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
