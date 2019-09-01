using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMath
{
    class Combinatorics
    {
        private static int Factorial(int a)
        {
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }

        private static int PlacementNoRepetition(int m, int n)
        {
           return Factorial(m) / Factorial(m - n);
        }

        private static int PlacementWithRepetition(int m, int n)
        {
            return (int)Math.Pow(m, n);
        }

        private static int Permutations (int n)
        {
            return Factorial(n);
        }

        private static int RepeatCombinations(int m, int n)
        {
            return Factorial(m + n - 1) / (Factorial( m - 1) * Factorial(n))  ;
           
        }

        private static int NoRepeatCombinations(int m,int n)
        {
            return Factorial(m) / (Factorial(n) * Factorial(m - n));
        }



    }
}
