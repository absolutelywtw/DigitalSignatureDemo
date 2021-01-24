using NUnit.Framework;
using static DigitalSignatureLib.MathAlgorithms;

namespace DigitalSignatureLibUnitTests
{
    public class BetterGcdUnitTests
    {
        [TestCase(5, 3, -1, 2)]
        public void BetterGcdUnitTest(int a, int b, int eX, int eY)
        {
            (int, int) expected = (eX, eY);
            
            int x = -1;
            int y = -1;
            int d = BetterGcd(a, b, ref x, ref y);
            (int, int) actual = (x, y);
            
            Assert.AreEqual(expected, actual);
        }
    }
}