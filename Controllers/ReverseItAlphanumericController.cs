using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBMC5.Services;

namespace VanhornBMC5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseItAlphanumericController : ControllerBase
    {
        private readonly ReverseItAlphanumericServices _reverseitAlphanumericServices;

            public ReverseItAlphanumericController(ReverseItAlphanumericServices reverseitAlphanumericServices)
            {
                _reverseitAlphanumericServices = reverseitAlphanumericServices;
            }
            [HttpGet]
            [Route("ReverseItAlphanumericServices/{words}/{numbers}")]
            public string ReverseItAlphanumericServices(string words, int numbers)
            {
                return _reverseitAlphanumericServices.
                ReverseItAlphanumberic(words, numbers);
            }
    }
}