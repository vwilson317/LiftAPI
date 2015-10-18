using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIModels;
using LiftAPI.Util;
using RepositoryService;
using RepositoryService.Log;

namespace LiftAPI.Controllers
{
    public class LogsController : ApiController
    {
        MockData mockData = new MockData();
        private ILogRepositoryService _service;

        public LogsController(ILogRepositoryService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("api/users/{id:int}/logs/{exerciseId}")]
        public HttpResponseMessage GetHistoryLogs(int id, int exerciseId)
        {
            var logs = mockData.Logs;
            return Request.CreateResponse(HttpStatusCode.OK, logs);
        }

        [HttpGet]
        [Route("api/users/{id:int}/logs")]
        public HttpResponseMessage GetLogsForUser(int id)
        {
            var logs = mockData.Logs;
            return Request.CreateResponse(HttpStatusCode.OK, logs);
        }

        [HttpPost]
        [Route("api/users/{userId:int}/exercises/{exerciseId:int}/logs")]
        public HttpResponseMessage GetHistoryLogs([FromBody] LogResource log)
        {
            log.Id = 1;
            return Request.CreateResponse(HttpStatusCode.Created, log);
        }

        //Allow the user to update a log record - wont need till app v2+
        [HttpPut]
        [Route("api/logs/{id:int}")]
        public HttpResponseMessage GetHistoryLogs(int id)
        {
            //Repo.UpdateLog(id)
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
