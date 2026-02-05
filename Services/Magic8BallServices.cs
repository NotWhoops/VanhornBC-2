using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace VanhornBMC6.Services
{
    public class Magic8BallServices
    {
        public string Magic8Ball(string question)
        {

        string[] responses ={
        "Probably not, don't ask again",
        "How dare you, thats weird",
        "Um no, you might want to seek therapy",
        "Yes, I always knew you were a nerd",
        "Nah",
        "Yes but also no",
        "System Error, Please try again",
        "You monster, how dare you suggest that",
        "I don't contain the parameters to help you",
        "Please read the bible bro"
        };

            Random rand = new Random();

            if (string.IsNullOrWhiteSpace(question))
            {
                return "You need to ask something!";
            }

            if (!question.Trim().EndsWith("?"))
            {
                return "That doesn't look like a question. Add a ? to your sentence";
            }

            int index = rand.Next(responses.Length);
            return $"Magic 8 Ball says: {responses[index]}";
        }
    }
}