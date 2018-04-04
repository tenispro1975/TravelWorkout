using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelWorkout.Models;

namespace TravelWorkout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to Your Travel Workout!! The place you look for workouts when on the go!!";

            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "Here is a listing of your previous workouts.";

            return View();
        }

        public IActionResult Links()
        {
            ViewData["Message"] = "Links to various WOD websites to further assist you.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
