using NUnit.Framework;
using static DigitalSignatureLib.ElGamal;

namespace DigitalSignatureLibUnitTests
{
    public class GetDigitalSignatureUnitTests
    {
        [TestCase(11, 7, 3, 9, 5, 8, 8)]
        [TestCase(11, 2, 8, 9, 5, 6, 9)]
        public void GetDigitalSignatureUnitTest(int p, int g, int x, int k, int m, int eA, int eB)
        {
            (int, int) expected = (eA, eB);

            (int, int) actual = GetDigitalSignature(p, g, x, k, m);
            
            Assert.AreEqual(expected, actual);
        }
    }
}