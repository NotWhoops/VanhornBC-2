using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC6.Services
{
    public class GuessItServices
    {
        public string GuessIt(string diff, string guess)
        {
            Random random = new Random();
            int NumberOfGuesses = 0;

            switch (diff)
            {
                case "Easy":
                   return Easy();
                case "Medium":
                   return Medium();
                case "Hard":
                   return Hard();
                default:
                  return "Invalid difficulty";
            }

            string Easy()
            {
                int randomNumber = random.Next(1, 11);
                bool isNum2 = int.TryParse(guess, out int num1);

                if (isNum2)
                {
                    NumberOfGuesses++;
                    if (num1 < randomNumber)
                    {
                        return ($"{num1} is to low");
                    }
                    else if (num1 > randomNumber)
                    {
                        return ($"{num1} is to high");
                    }

                    else if (num1 == randomNumber)
                    {
                        return ($"{num1} is correct in {NumberOfGuesses} guesses");
                    }
                }
                    return "invalid input";
            }
            string Medium()
            {
                int randomNumber2 = random.Next(1, 51);
                bool isNum2 = int.TryParse(guess, out int num1);

                if (isNum2)
                {
                    NumberOfGuesses++;
                    if (num1 < randomNumber2)
                    {
                        return ($"{num1} is to low");
                    }
                    else if (num1 > randomNumber2)
                    {
                        return ($"{num1} is to high");
                    }

                    else if (num1 == randomNumber2)
                    {
                        return ($"{num1} is correct in {NumberOfGuesses} guesses");
                    }
                }
                return "invalid input";
            }
            string Hard()
            {
                int randomNumber3 = random.Next(1, 101);
                bool isNum2 = int.TryParse(guess, out int num1);

                if (isNum2)
                {
                    NumberOfGuesses++;
                    if (num1 < randomNumber3)
                    {
                        return ($"{num1} is to low");
                    }
                    else if (num1 > randomNumber3)
                    {
                        return ($"{num1} is to high");
                    }

                    else if (num1 == randomNumber3)
                    {
                        return ($"{num1} is correct in {NumberOfGuesses} guesses");
                    }
                }
                return "invalid input";
            }
        }
    }
}