﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWorkout.Data
{
    public class WorkoutDbContext : DbContext
    {
        public DbSet<Workout> Workouts { get; set; }

        public WorkoutDbContext(DbContextOptions<WorkoutDbContext> options)

            : base(options)
        { }
    }
}