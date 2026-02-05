using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBC2.Services
{
    public class AskingQuestionsServices
    {
        public string AskingQuestions(string name, string time)
        {
            return $"Your name is {name} and You woke up at {time}";
        }
    }
}