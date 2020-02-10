using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Coderbyte.Problems
{
    public static class FirstReverse
    {
        public static string Solve(string str)
        {
            return string.Join("", str.Reverse());
        }
    }
}
