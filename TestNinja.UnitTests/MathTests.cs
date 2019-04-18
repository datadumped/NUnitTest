using System;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();

            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            var math = new Math();

            var result = math.Max(3, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            var math = new Math();

            var result = math.Max(2, 3);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgument()
        {
            var math = new Math();

            var result = math.Max(3, 3);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
