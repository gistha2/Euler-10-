using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_10___Summation_of_Primes
{
    class Program
    {

        public static bool isPrime(int number)
        {
            int boundary = Convert.ToInt32(Math.Floor(Math.Sqrt(number)));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            long summation = 0;

            for (int i =1; i<2000000; i++)
            { if (isPrime(i) == true)
                {
                    summation = summation + i;
                    
                }
            }
            Console.WriteLine(summation);
            Console.ReadLine();

        }
    }
}
