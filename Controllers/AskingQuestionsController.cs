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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;

        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices)
        {
            _askingQuestionsServices = askingQuestionsServices;
        }

        [HttpGet]
        [Route("AskingQuestions/{name}/{time}")]
        public string AskingQuestions(string name, string time)
        {
            return _askingQuestionsServices.AskingQuestions(name, time);
        }
    }
}