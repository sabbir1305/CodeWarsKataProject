using CodeWarsKata.Solutions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKataTest
{
    class ArgeTests
    {
        private static void ExpectedPolulationCheck(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Test_NbYear_Population()
        {
            Console.WriteLine("Testing NbYear");
            ExpectedPolulationCheck(Arge.NbYear(1500, 5, 100, 5000), 15);
            ExpectedPolulationCheck(Arge.NbYear(1500000, 2.5, 10000, 2000000), 10);
            ExpectedPolulationCheck(Arge.NbYear(1500000, 0.25, 1000, 2000000), 94);
        }
    }
}
