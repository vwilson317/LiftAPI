using System;

namespace Domain
{
    public class Log : DomainBase
    {
        public DateTime CompletedDate { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }


        //Use object instead of ids
        //If app runs slowly then convert nested models to ids
        public Exercise Exercise { get; set; }

        public int UserId { get; set; }
    }
}