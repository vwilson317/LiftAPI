using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIModels;
using LiftAPI.Util;
using RepositoryService;

namespace LiftAPI.Controllers
{
    [RoutePrefix("api/exercises")]
    public class ExercisesController : ApiController
    {
        MockData mockData = new MockData();
        private IExerciseRepositoryService _repositoryService;

        public ExercisesController(IExerciseRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetExercises()
        {
            var exercises = mockData.Exercises;
            return Request.CreateResponse(HttpStatusCode.OK, exercises);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage CreateExercise([FromBody] ExerciseResource exercise)
        {
            mockData.Exercises.Add(exercise);
            return Request.CreateResponse(HttpStatusCode.Created, exercise);
        }

        [HttpPut]
        [Route("{id:int}")]
        public HttpResponseMessage UpdateExercise([FromBody] ExerciseResource exercise)
        {
            return Request.CreateResponse(HttpStatusCode.OK, exercise);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public HttpResponseMessage Delete(int id)
        {
            //Reposority.Delete(id)
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
