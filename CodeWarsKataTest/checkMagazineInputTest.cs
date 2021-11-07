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
    class checkMagazineInputTest
    {
        [Test]
        public void SampleTest3()
        {

            var magazine = "two times three is not four".Split(' ').ToList();
            var note = "two times two is four".Split(' ').ToList();
            Assert.AreEqual("No", CheckMagazine.checkMagazineInput(magazine,note));
        }

    }
}
