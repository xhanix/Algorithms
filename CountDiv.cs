using System;

namespace Algos
{
    public static class CountDiv
    {
        public static int solution(int A, int B, int K)
        {
            // 1, 2, 3, 4, 5, (6, 7, 8, 9, 10, 11)
            // 11/2 = 5.5; 6/2 = 3; 5 - 3 = 2; 2 + 1 = 3; 

            // 1, 2, 3, 4, 5, (6, 7, 8, 9, 10, 11, 12)
            // 12/2 = 6; 6/2 = 3; 6 - 3 = 3; 3 + 1 = 4; 

            //1, 2, 3, 4, 5, 6, 7, 8, (9, 10, 11, 12, 13, 14, 15, 16, 17)
            // 4
            if (A == B)
            {
                return A % K == 0 ? 1 : 0;
            }
            if (K > B) return 0;
            var all = B / K;
            var firstPart = A / K;
            var divs = all - firstPart;
            if (A % K == 0) divs++;
            return (int)Math.Min(int.MaxValue, divs);
        }
    }
}
