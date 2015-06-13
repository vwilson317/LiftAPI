using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftAPI.Models
{
    public class LogModel : ModelBase
    {
        public DateTime CompletedDate { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }


        //Use object instead of ids
        //If app runs slowly then convert nested models to ids
        public ExerciseModel Exercise { get; set; }

        public int UserId { get; set; }
    }
}