using System;
using static DigitalSignatureLib.MathAlgorithms;

namespace DigitalSignatureLib
{
    public class ElGamal
    {
        public static int GetPublicKey(int p, int g, int x)
        {
            int y = PowerMod(g, x, p);
            return y;
        }

        public static (int, int) GetDigitalSignature(int p, int g, int x, int k, int m)
        {
            int a = PowerMod(g, k, p);
            int b = PowerMod(GetPublicKey(p, g, x), k, p) * m % p;
            
            return (a, b);
        }

        public static int CheckDigitalSignature(int a, int b, int p, int x)
        {
            int m = b * PowerMod(a, p - 1 - x, p) % p;
            return m;
        }
    }
}