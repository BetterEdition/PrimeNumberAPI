using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumberAPI.Model
{
    public class PrimeInfo
    {

        public bool IsPrime(long num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;


            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        public long getPrimes(long num1, long num2)
        {
            int primes = 0;
            for (long i = num1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    primes++;
                }
            };
            return primes;
        }
    }
}
