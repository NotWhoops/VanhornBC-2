using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBMC5.Services;

namespace VanhornBMC5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
            private readonly MadLibServices _madLibServices;

            public MadLibController(MadLibServices madLibServices)
            {
                _madLibServices = madLibServices;
            }
            [HttpGet]
            [Route("MadLib/{noun}/{verb}/{adjective}/{adverb}/{pronoun}")]
            public string MadLib(string noun, string verb, string adjective, string pronoun, string adverb)
            {
                return _madLibServices.
                MadLib(noun, verb, adjective, pronoun, adverb);
            }
    }
}