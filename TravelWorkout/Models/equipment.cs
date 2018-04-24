using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TravelWorkout.Models
{
    public class Equipment
    {
        public int ID { get; set; }
        public int WorkoutID { get; set; }
        public string EquipmentName1 { get; set; }
        public string EquipmentName2 { get; set; }
        public string EquipmentName3 { get; set; }
        public string EquipmentName4 { get; set; }

        public IList<Workouts> Workout { get; set; }
    }
}
