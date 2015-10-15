﻿using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIModels;
using LiftAPI.Util;
using RepositoryService;

namespace LiftAPI.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private MockData mockData = new MockData();
        private IUserRepositoryService _service;

        public UsersController(IUserRepositoryService service)
        {
            _service = service;
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
            return Request.CreateResponse(HttpStatusCode.OK, mockData.User);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage CreateUser([FromBody] UserModel user)
        {
            user.Id = 1;
            return Request.CreateResponse(HttpStatusCode.Created, user);
        }

        [HttpPut]
        [Route("{id:int}")]
        public HttpResponseMessage UpdateUser([FromBody] UserModel user)
        {
            return Request.CreateResponse(HttpStatusCode.OK, user);
        }
    }
}
