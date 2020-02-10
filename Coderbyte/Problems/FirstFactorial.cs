using System;
using System.Collections.Generic;
using System.Text;

namespace Coderbyte.Problems
{
    public static class FirstFactorial
    {
        public static int Solve(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }

            int result = 1;
            while (num > 1)
            {
                result *= num;
                num--;
            }
            return result;
        }
    }
}
