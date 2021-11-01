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
  public  class ParenthesesTest
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Parentheses.ValidParentheses(")(((("));
        }

        [Test]
        public void SampleTest3()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses("(())((()())())"));
        }

        [Test]
        public void SampleTest4()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses("(a+b)*c+(d)+(a)"));
        }
    }
}
