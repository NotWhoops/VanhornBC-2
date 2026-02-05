using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBC2.Services;

namespace VanhornBC2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldServices _helloWorldServices;

        public HelloWorldController(HelloWorldServices helloWorldServices)
        {
            _helloWorldServices = helloWorldServices;
        }
        [HttpGet]
        [Route("SayHelloWorld")]
        public string SayHelloWorld()
        {
            return _helloWorldServices.SayHelloWorld();
        }
    }
}