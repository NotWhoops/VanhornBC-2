using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBMC6.Services;

namespace VanhornBMC6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

            public GuessItController(GuessItServices guessItServices)
            {
                _guessItServices = guessItServices;
            }
            [HttpGet]
            [Route("GuessItServicesEasy/{guess}")]
            public string GuessItServicesEasy(string guess)
            {
                return _guessItServices.GuessIt("Easy", guess);
            }
            [HttpGet]
            [Route("GuessItServicesMedium/{guess}")]
            public string GuessItServicesMedium(string guess)
            {
                return _guessItServices.GuessIt("Medium", guess);
            }
            [HttpGet]
            [Route("GuessItServicesHard/{guess}")]
            public string GuessItServicesHard(string guess)
            {
                return _guessItServices.GuessIt("Hard", guess);
            }
    }
}