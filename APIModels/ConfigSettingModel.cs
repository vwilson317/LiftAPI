using System;

namespace APIModels
{
    public class ConfigSettingModel : ModelBase
    {
        public char WeightUnits { get; set; }
        public DayOfWeek WorkoutStartOfWeek { get; set; }
        //FK
        public int UserId { get; set; }
    }
}