using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LiftAPI.Models;
using LiftAPI.Util;

namespace LiftAPI.Controllers
{
    [RoutePrefix("api/exercises")]
    public class ExercisesController : ApiController
    {
        MockData mockData = new MockData();

        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetExercises()
        {
            var exercises = mockData.Exercises;
            return Request.CreateResponse(HttpStatusCode.OK, exercises);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage CreateExercise([FromBody] ExerciseModel exercise)
        {
            mockData.Exercises.Add(exercise);
            return Request.CreateResponse(HttpStatusCode.Created, exercise);
        }

        [HttpPut]
        [Route("{id:int}")]
        public HttpResponseMessage UpdateExercise([FromBody] ExerciseModel exercise)
        {
            return Request.CreateResponse(HttpStatusCode.OK, exercise);
        }
    }
}
