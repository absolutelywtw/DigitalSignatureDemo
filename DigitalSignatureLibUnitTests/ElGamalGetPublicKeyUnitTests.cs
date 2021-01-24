using NUnit.Framework;
using static DigitalSignatureLib.ElGamal;

namespace DigitalSignatureLibUnitTests
{
    public class ElGamalGetPublicKeyUnitTests
    {
        [TestCase(11, 7, 3, 2)]
        [TestCase(11, 7, 12, 5)]
        [TestCase(11, 7, 13, 2)]
        [TestCase(17, 3, 3, 10)]
        [TestCase(17, 3, 5, 5)]
        public void ElGamalPublicKeyUnitTest1(int P, int A, int X, int expected)
        {
            int actual = GetPublicKey(P, A, X);
            
            Assert.AreEqual(expected, actual);
        }
    }
}