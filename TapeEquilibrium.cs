using System;

namespace Algos
{
    public static class TapeEquilibrium
    {
        public static int solution(int[] A)
        {
            // A[0]...A[P-1]    -    A[P]...A[N-1]
            if (A.Length == 2) return Math.Abs(A[0] - A[1]);
            var preSum = new long[A.Length];
            preSum[0] = A[0];
            var diff = int.MaxValue;
            for (int i = 1; i < A.Length; i++)
            {
                preSum[i] = A[i] + preSum[i - 1];
            }
            for (int i = 0; i < A.Length - 1; i++)
            {
                var leftSum = preSum[i];
                var rightSum = preSum[preSum.Length - 1] - leftSum;
                var d = Math.Abs(leftSum - rightSum);
                diff = (int)Math.Min(d, diff);
            }
            return diff;
        }
    }
}
