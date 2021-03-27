using System;

namespace Algos
{
    public static class PermCheck
    {
        public static int solution(int[] A)
        {
            Array.Sort(A);
            if (A[A.Length - 1] != A.Length) return 0;
            long currentSum = (A[A.Length - 1] * (A[A.Length - 1] + 1L)) / 2L;
            long realSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i > 0 && A[i] != A[i - 1] + 1) return 0;
                realSum += A[i];
            }
            return realSum == currentSum ? 1 : 0;
        }
    }
}
