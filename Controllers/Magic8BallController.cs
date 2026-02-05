using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBMC6.Services;

namespace VanhornBMC6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;

            public Magic8BallController(Magic8BallServices magic8BallServices)
            {
                _magic8BallServices = magic8BallServices;
            }
            [HttpGet]
            [Route("Magic8BallServices/{question}")]
            public string Magic8BallServices(string question)
            {
                return _magic8BallServices.
                Magic8Ball(question);
            }
    }
}