using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using RabbitMQ.Client;
using Repository;
using RepositoryService.Common;
using Resources;

namespace LiftAPI.Controllers
{
    public class BaseController<TRepositoryService, TResource> 
        : ApiController
        where TResource : ResourceBase
        where TRepositoryService : IRepositoryService<TResource>
    {
        public IRepositoryService<TResource> Service { get; set; }
        public BaseController(TRepositoryService repositoryService)
        {
            Service = repositoryService;
        }

        public HttpResponseMessage Get(int id)
        {
            PutMessageOnQueue();
            var data = Service.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        public HttpResponseMessage Get()        {            PutMessageOnQueue();            var data = Service.GetAll();            return Request.CreateResponse(HttpStatusCode.OK, data);        }

        private void PutMessageOnQueue()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "52.5.31.215",
                UserName = "liftapi",
                Password = "1qaz!QAZ"
            };
            using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare("api", "fanout");
                    channel.QueueDeclare(queue: "api",
                        durable: true,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    string message = "Hello World!";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                        routingKey: "api",
                        basicProperties: null,
                        body: body);
                }
        }
    }
}