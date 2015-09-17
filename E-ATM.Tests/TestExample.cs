using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace E_ATM.Tests
{
    [TestFixture]
    public class TestExample
    {
        int x, y;

        [SetUp]
        public void Init()
        {
            x = 1;
            y = 2;
        }

        [Test]
        public void AddTwoNumbers()
        {
            Assert.AreEqual(3, x+y);
        }
    }
}
