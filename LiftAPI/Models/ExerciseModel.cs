using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftAPI.Models
{
    public class ExerciseModel : ModelBase
    {
        public MuscleGroupModel MuscleGroupType { get; set; }
    }
}