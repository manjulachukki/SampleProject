using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SampleProjectForGit;

namespace SampleTestProject
{
    [TestFixture]
    internal class AddNumbers
    {
        [TestCase(5, 7, 12)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 3, 1)]
        public void AddTest(int num1, int num2, int expected)
        {
            int actual = Program.Add(num1, num2);
            Assert.AreEqual(expected, actual);
        }
    }
}
