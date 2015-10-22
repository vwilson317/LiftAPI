using System;

namespace Domain
{
    public class Log : Entity
    {
        public virtual DateTime CompletedDate { get; set; }
        public virtual int Weight { get; set; }
        public virtual int Reps { get; set; }
        public virtual int Sets { get; set; }


        //Use object instead of ids
        //If app runs slowly then convert nested models to ids
        public virtual Exercise Exercise { get; set; }
        public virtual int UserId { get; set; }
    }
}