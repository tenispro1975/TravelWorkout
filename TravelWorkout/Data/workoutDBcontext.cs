using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelWorkout.Models;

namespace TravelWorkout.Data
{
    public class WorkoutDbContext : DbContext
    {
        public DbSet<Workouts> Workout { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<WorkoutEquipment> WorkoutEquipment { get; set; }
        public DbSet<History> History { get; set; }

        public WorkoutDbContext(DbContextOptions<WorkoutDbContext> options)

            : base(options)
        { }
    }
}
