using System;

namespace Algos
{
    public static class FrogJmp
    {
        public static int solution(int X, int Y, int D)
        {
            if (X == Y) return 0;
            if (D >= Y - X) return 1;
            double d = (double)Y - X;
            var res = d / D;
            return (int)Math.Ceiling(res);
        }
    }
}
