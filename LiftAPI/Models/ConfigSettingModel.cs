using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftAPI.Models
{
    public class ConfigSettingModel : ModelBase
    {
        public char WeightUnits { get; set; }
        public DayOfWeek WorkoutStartOfWeek { get; set; }
        //FK
        public int UserId { get; set; }
    }
}