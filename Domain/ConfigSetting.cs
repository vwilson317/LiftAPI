using System;

namespace Domain
{
    public class PreferenceSetting : Entity
    {
        public virtual char WeightUnits { get; set; }
        public virtual DayOfWeek WorkoutStartOfWeek { get; set; }
        //FK   
        public virtual int UserId { get; set; }
    }
}