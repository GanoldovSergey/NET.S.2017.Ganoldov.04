using System;
using NUnit.Framework;

namespace Logic.NUnitTests
{
    public class UnitTest1
    {
        [TestCase(4, 2, 0.00001)]
        [TestCase(54, 3, 0.00001)]
        [TestCase(543.887, 6, 0.00001)]
        [TestCase(0.001, 3, 0.00001)]
        public void PositiveTest(double a, int n, double eps)
        {
            Assert.IsTrue(Math.Abs(MathExtensions.Root(a, n, eps) - Math.Pow(a, 1.0 / n)) < eps);
        }

        [TestCase(5, 2, -0.5)]
        [TestCase(3, 0, 0.1)]
        [TestCase(-8, 3, 0.1)]
        public void GetRoot_ThrowsArgumentException(double a, int n, double eps)
        {
            Assert.Throws<ArgumentException>(
                () => MathExtensions.Root(a, n, eps));
        }
    }
}
