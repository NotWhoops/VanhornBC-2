using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC5.Services
{
    public class ReverseItAlphanumericServices
    {
        public string ReverseItAlphanumberic(string words, int numbers)
        {
            int num = numbers;
            int reversed = 0;
            while (numbers != 0)
            {
                int digit = numbers % 10;
                reversed = reversed * 10 + digit;
                numbers /= 10;
            }
            string reversedWord = "";

            for (int i = words!.Length - 1; i >= 0; i--)
            {
                reversedWord += words[i];
            }

            return $"You entered {words} and {num} reversed is {reversedWord} and {reversed}";
        } 
    }
}