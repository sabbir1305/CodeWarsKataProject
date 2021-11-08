﻿using CodeWarsKata.Solutions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKataTest
{
	[TestFixture]
	public class SumSquaredDivisorsTests
	{

		[Test]
		public void Test01()
		{
			Assert.AreEqual("[[1, 1], [42, 2500], [246, 84100]]", SumSquaredDivisors.listSquared(1, 250));
		}
		[Test]
		public void Test02()
		{
			Assert.AreEqual("[[42, 2500], [246, 84100]]", SumSquaredDivisors.listSquared(42, 250));
		}
		[Test]
		public void Test03()
		{
			Assert.AreEqual("[[287, 84100]]", SumSquaredDivisors.listSquared(250, 500));
		}
	}
}
