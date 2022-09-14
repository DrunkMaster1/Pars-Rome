using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars_Rome
{
    public static class ParseClass
    {

        private static readonly Dictionary<char, int> romanDigits =
        new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        public static int Decode(string s)
        {
            int result = 0;
            for (int i = s.Length - 1; i > 0; i--)
            { 
            int curr = romanDigits.Get 


            }
            

        }
}
