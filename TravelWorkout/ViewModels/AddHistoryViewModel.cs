﻿using TravelWorkout.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

 namespace TravelWorkout.ViewModels
{
    public class AddHistoryViewModel
    {
        [Required]
        [Display(Name = "Workout")]
        public List<SelectListItem> Workouts { get; set; }


    }
}
