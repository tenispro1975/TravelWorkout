using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelWorkout.Data;

namespace TravelWorkout.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly WorkoutDbContext context;

        public WorkoutController(WorkoutDbContext dbContext)
        {
            context = dbContext;

        }


            public IActionResult Index()
        {



            return View();
        }
    }
}