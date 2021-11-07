using CodeWarsKata.Solutions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKataTest
{
  public  class SumBigNumberTest
    {
        [Test]
        public static void Test_Add_Two_String()
        {

            //Assert.AreEqual("10000", SumBigNumbers.Add("9999", "1"));
            Assert.AreEqual("110", SumBigNumbers.Add("11", "99"));

        }
    }
}
