namespace Algos
{
    public static class GCD
    {
        public static int Euclidean(int a, int b)
        {
            while (b > 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        //should run faster (binary Euclidean) for larger sets
        public static int Steins(int u, int v)
        {
            if (u == v) return u;
            if (u == 0) return v;
            if (v == 0) return u;

            if (u % 2 == 0) //u is even
            {
                if (v % 2 == 1) //v is odd
                    return Steins(u / 2, v);
                else //both u and v are even
                    return 2 * Steins(u / 2, v / 2);
            }
            else // u is odd
            {
                if (v % 2 == 0) //v is even
                    return Steins(u, v / 2);

                if (u > v)
                    return Steins((u - v) / 2, v);
                else
                    return Steins((v - u) / 2, u);
            }
        }
    }
}
