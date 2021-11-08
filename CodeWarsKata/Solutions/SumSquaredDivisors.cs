using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CodeWarsKata.Solutions
{
  public  class SumSquaredDivisors
    {
        public static string listSquared(long m, long n)
        {
            var builder = new StringBuilder();
            builder.Append("[");
            string comma = "";
            // your code
            for(long i = m; i <= n; i++)
            {

                var sumSqure = FindDivisors(i);
                if (IsSquare(sumSqure))
                {
                    builder.Append(comma);
                    builder.Append($"[{i}, {sumSqure}]");
                    comma = ", ";
                }
            }
            builder.Append("]");
            return builder.ToString();
        }

        private static bool IsSquare(double n)
        {
            return Math.Ceiling((double)Math.Sqrt(n)) == Math.Floor((double)Math.Sqrt(n));
        }

        private static double FindDivisors(long num)
        {
            var divisors = new List<long>();

            for (long i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    if (num / i == i)
                    {
                        divisors.Add(i);
                    }
                    else
                    {
                        divisors.Add(i);
                        divisors.Add(num/i);
                    }
                }
            }

            return divisors.Select(x => Math.Pow(x,2)).Sum();
           
        }
    }
}
