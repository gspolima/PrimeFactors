using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public List<int> of(int number)
        {
            var primeFactors = new List<int>();
            for (int divisor = 2; number > 1; divisor++)
            {
                for (;number % divisor == 0; number /= divisor)
                {
                    primeFactors.Add(divisor);
                }
            }
            return primeFactors;
        }
    }
}