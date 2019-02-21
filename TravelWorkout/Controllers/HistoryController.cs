using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TravelWorkout.Data;
using TravelWorkout.Models;
using TravelWorkout.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelWorkout.Controllers
{
    public class HistoryController : Controller
    {
        private readonly WorkoutDbContext context;
        private readonly List<SelectListItem> Name;

        public HistoryController(WorkoutDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<History> History = context.History.ToList();

            return View(History);
        }

        public IActionResult Add()
        {
            AddHistoryViewModel addHistoryViewModel = new AddHistoryViewModel();
            return View(addHistoryViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddHistoryViewModel addHistoryViewModel)
        {
            if (ModelState.IsValid)
            {

                Workout newWorkouts = new Workout
                {
                    Workouts = AddHistoryViewModel.Workouts
                };


                Workout newWorkout = null;
                context.Workout.Add(newWorkout);
                context.SaveChanges();
              

                return Redirect("/History");
            }

            return View(addHistoryViewModel);

        }
    }

}







