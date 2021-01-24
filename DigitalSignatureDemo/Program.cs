using System;
using static System.Console;
using static DigitalSignatureLib.ElGamal;

namespace DigitalSignatureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Showcase of ElGamal encryption");
            Write("Input p: ");
            int p = Convert.ToInt32(ReadLine());
            Write("Input g: ");
            int g = Convert.ToInt32(ReadLine());

            WriteLine("Getting public key");
            Write("Input x: ");
            int x = Convert.ToInt32(ReadLine());
            WriteLine($"y = {GetPublicKey(p, g, x)}");

            WriteLine("Encryption demo");
            Write("Input m: ");
            int m = Convert.ToInt32(ReadLine());
            Write("Input k: ");
            int k = Convert.ToInt32(ReadLine());
            (int, int) digitalSignature = GetDigitalSignature(p, g, x, k, m);
            WriteLine($"CipherText: {digitalSignature}");
            WriteLine("Decryption demo");
            WriteLine($"Expected: {m}");
            WriteLine($"Actual: {CheckDigitalSignature(digitalSignature.Item1, digitalSignature.Item2, p, x)}");
        }
    }
}
