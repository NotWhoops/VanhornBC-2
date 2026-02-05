using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC5.Services
{
    public class MadLibServices
    {
        public string MadLib(string noun, string verb, string adjective, string place, string emotion)
        {
            return $"Yesterday, I saw a {adjective} {noun} trying to {verb} on top of a {adjective} {place}, and it made everyone feel extremely {emotion}."; 
        }
    }
}