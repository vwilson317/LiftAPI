using System;

namespace Domain
{
    public class ConfigSetting : DomainBase
    {
        public char WeightUnits { get; set; }
        public DayOfWeek WorkoutStartOfWeek { get; set; }
        //FK
        public int UserId { get; set; }
    }
}