using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC5.Services
{
    public class MadLibServices
    {
        public string MadLib(string noun, string verb, string adjective, string pronoun, string adverb)
        {
            return $"Hello {noun} you don't have a {adverb} do you? Well either way can you help me acquire a specific item similar to a {adjective}? Well now tell me about your {verb}. What kind of {pronoun} breed is he?"; 
        }
    }
}