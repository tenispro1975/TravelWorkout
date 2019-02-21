using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWorkout.Models
{
    public class WorkoutEquipment
    {
        public int ID { get; set; }
        public int WorkoutID { get; set; }
        public Workout Workout { get; set; }
    }
}
