﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LiftAPI.Models;
using LiftAPI.Util;

namespace LiftAPI.Controllers
{
    public class WorkoutsController : ApiController
    {
        private MockData mockData = new MockData();

        [HttpGet]
        [Route("api/users/{id:int}/workouts")]
        public HttpResponseMessage GetUserWorkout(int id)
        {
            var workouts = mockData.Workouts;
            return Request.CreateResponse(HttpStatusCode.OK, workouts);
        }

        [HttpPost]
        [Route("api/users/{id:int}/workouts")]
        public HttpResponseMessage CreateWorkout([FromBody] WorkoutRoutineModel workout)
        {
            //Simulates creating a new workout
            mockData.KillerWorkout = workout;

            return Request.CreateResponse(HttpStatusCode.Created, mockData.KillerWorkout);
        }

        [HttpPut]
        [Route("api/users/{id:int}/workouts/{workoutId:int}")]
        public HttpResponseMessage UpdateWorkout([FromBody] WorkoutRoutineModel workout)
        {
            //Simulates updating a workout
            var workouts = mockData.Workouts;
            var matchingWorkout = workouts.First(x => x.Id == workout.Id);

            if(matchingWorkout != null)
            matchingWorkout = workout;

            return Request.CreateResponse(HttpStatusCode.OK, matchingWorkout);
        }
    }
}
