using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWorkout.Models
{
    public class History
    {
       public int ID { get; set; }
       public string Name { get; set; }

       public List<WorkoutEquipment> workoutequipments = new List<WorkoutEquipment>();
    }
}
