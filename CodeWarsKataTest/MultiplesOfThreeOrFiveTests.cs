using CodeWarsKata.Solutions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKataTest
{
    [TestFixture]
   public class MultiplesOfThreeOrFiveTests
    {
        [Test]
        public void Test_MultipliersSum_result()
        {
            Assert.AreEqual(23, MultiplesOfThreeOrFive.Solution(10));
        }
    }
}
