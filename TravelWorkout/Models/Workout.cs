using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWorkout.Models
{
    public class Workouts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        
        public int EquipmentID { get; set; }
        public Equipment Equipment { get; set; }
    }
}
