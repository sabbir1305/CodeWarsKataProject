using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKata.Solutions
{
  public   class Arge
    {
        
        //Growth of a Population
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int currentPopulation = p0, currentYear = 0;
            while ( currentPopulation<p)
            {
                currentYear++;
                currentPopulation = PerYearPoplationGrowth(percent, currentPopulation) + aug;
              
            }

            return currentYear;
            // your code
        }

        private static int PerYearPoplationGrowth(double percent, int currentPopulation)
        {
            return currentPopulation + (int)((currentPopulation * percent) / 100);
        }
    }
}
