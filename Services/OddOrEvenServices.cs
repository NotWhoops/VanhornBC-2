using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC5.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(int num)
        {
            if (num % 2 == 0)
            {
                return $"You entered {num} it was a even number";
            }
            else
            {
                return $"You entered {num} it was a odd number";
            }
        }
    }
}