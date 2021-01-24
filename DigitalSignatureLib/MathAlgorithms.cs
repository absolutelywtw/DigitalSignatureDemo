namespace DigitalSignatureLib
{
    public class MathAlgorithms
    {
        public static int Power(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                return Power(x, n / 2) * Power(x, n / 2);
            }

            return x * Power(x, n - 1);
        }

        public static int PowerMod(int x, int n, int m)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                return PowerMod(x, n / 2, m) % m * PowerMod(x, n / 2, m) % m;
            }

            return (x % m) * PowerMod(x, n - 1, m) % m;
        }

        public static int BetterGcd(int a, int b, ref int x, ref int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int x1 = -1;
            int y1 = -1;
            int d = BetterGcd(b % a, a, ref x1, ref y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }
    }
}