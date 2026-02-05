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
    public class ReverseItNumbersController : ControllerBase
    {
         private readonly ReverseItNumbersServices _reverseitNumbersServices;

            public ReverseItNumbersController(ReverseItNumbersServices reverseitNumbersServices)
            {
                _reverseitNumbersServices = reverseitNumbersServices;
            }
            [HttpGet]
            [Route("ReverseItNumbersServices/{numbers}")]
            public string ReverseItNumbersServices(int numbers)
            {

                return _reverseitNumbersServices.
                ReverseItNumbers(numbers);


            }
    }
}