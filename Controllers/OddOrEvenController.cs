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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddorevenServices;

            public OddOrEvenController(OddOrEvenServices oddorevenServices)
            {
                _oddorevenServices = oddorevenServices;
            }
            [HttpGet]
            [Route("OddOrEvenServices/{num}")]
            public string OddOrEvenServices(int num)
            {
                return _oddorevenServices.
                OddOrEven(num);
            }
    }
}