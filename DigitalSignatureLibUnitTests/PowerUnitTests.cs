using NUnit.Framework;
using static DigitalSignatureLib.MathAlgorithms;

namespace DigitalSignatureLibUnitTests
{
    public class PowerUnitTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 8)]
        [TestCase(3, 5, 243)]
        [TestCase(42, 0, 1)]
        public void PowerIntTest(int x, int n, int expected)
        {
            int actual = Power(x, n);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 3, 11, 2)]
        [TestCase(7, 13, 11, 2)]
        [TestCase(7, 3, 2, 1)]
        public void PowerModTest(int x, int n, int m, int expected)
        {
            int actual = PowerMod(x, n, m);
            
            Assert.AreEqual(expected, actual);
        }
    }
}