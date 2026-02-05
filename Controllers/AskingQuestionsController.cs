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
        [Route("AskingQuestions/{answer1}/{answer2}")]
        public string AskingQuestions(string answer1, string answer2)
        {
            return _askingQuestionsServices.AskingQuestions(answer1, answer2);
        }
    }
}