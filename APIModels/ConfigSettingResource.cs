using System;

namespace Resources
{
    public class ConfigSettingResource : ResourceBase
    {
        public char WeightUnits { get; set; }
        public DayOfWeek WorkoutStartOfWeek { get; set; }
        //FK
        public int UserId { get; set; }
    }
}