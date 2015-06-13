﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftAPI.Models
{
    public class WorkoutRoutineModel : ModelBase
    {
        public List<ConfiguredExerciseModel> ConfiguredExercises { get; set; }
        //value will determine where the Workout Routine will be displayed in the list
        public int SortOrderRank { get; set; }

        //Defaults to null - used to track if and when a workout has been completed
        //should be used to determine if workout was done in a workout week
        public DateTime? CompletedDate { get; set; }

        public int UserId { get; set; }
    }
}