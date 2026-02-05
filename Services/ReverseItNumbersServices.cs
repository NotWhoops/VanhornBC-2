using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC5.Services
{
    public class ReverseItNumbersServices
    {
        public string ReverseItNumbers(int numbers)
        {
            int num = numbers;
            int reversed = 0;
            while (numbers != 0)
            {
                int digit = numbers % 10;
                reversed = reversed * 10 + digit;
                numbers /= 10;
            }

            return $"Your first number was {num} and this is the number reversed {reversed}";
        }
    }
}