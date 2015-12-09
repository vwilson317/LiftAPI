using System.Net;
using System.Net.Http;
using System.Web.Http;
using LiftAPI.Util;
using RepositoryService.User;
using Resources;

namespace LiftAPI.Controllers
{
    [RoutePrefix("v1/users")]
    public class UsersController : BaseController<IUserRepositoryService, UserResource>
    {
        private MockData mockData = new MockData();

        public UsersController(IUserRepositoryService service)
            : base(service)
        {
        }

        [HttpGet]
        [Route("")]
        public new HttpResponseMessage Get()
        {
            return base.Get();
        }
       
        [HttpGet]
        [Route("{name:alpha}")]
        public HttpResponseMessage GetUser(string name)
        {
            return Request.CreateResponse(HttpStatusCode.OK, mockData.User);
        }

        [HttpGet]
        [Route("{id:int}")]
        public HttpResponseMessage GetUser(int id)
        {
            return base.Get(id);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage CreateUser([FromBody] UserResource user)
        {
            user.Id = 1;
            return Request.CreateResponse(HttpStatusCode.Created, user);
        }

        [HttpPut]
        [Route("{id:int}")]
        public HttpResponseMessage UpdateUser([FromBody] UserResource user)
        {
            return Request.CreateResponse(HttpStatusCode.OK, user);
        }
    }
}
