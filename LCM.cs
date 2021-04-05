namespace Algos
{
    public static class LCM
    {
        public static int Lcm(int a, int b)
        {
            return a * (b / GCD.Steins(a, b));
        }
    }
}
