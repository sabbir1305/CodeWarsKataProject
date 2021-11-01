using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKata.Solutions
{
   public  class MultiplesOfThreeOrFive
    {
        public static int Solution(int value)
        {
            // Magic Happens
            int sum = 0;

            if (value <= 0)
                return sum;
            for(int i = 1; i < value; i++)
            {
                if (i % 15 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
                else if(i % 3 == 0)
                {
                    sum += i;
                }
            }

            return sum;

        }
    }
}
