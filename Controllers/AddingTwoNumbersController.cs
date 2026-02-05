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
    public class AddingTwoNumbersController : ControllerBase
    {
        
        private readonly AddingTwoNumbersServices _addingTwoNumbersServices;

        public AddingTwoNumbersController(AddingTwoNumbersServices addingTwoNumbersServices)
        {
            _addingTwoNumbersServices = addingTwoNumbersServices;
        }

        [HttpGet]
        [Route("AddingTwoNumbers/{num1}/{num2}")]
        public int AddingTwoNumbers(int num1, int num2)
        {
            return _addingTwoNumbersServices.AddingTwoNumbers(num1, num2);
        }
    }
}