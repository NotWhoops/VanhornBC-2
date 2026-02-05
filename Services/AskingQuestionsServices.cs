using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBC2.Services
{
    public class AskingQuestionsServices
    {
        public string AskingQuestions(string answer1, string answer2)
        {
            return $"Your name is {answer1} and You woke up at {answer2}";
        }
    }
}