using System;

namespace Algos
{
    public static class PermMissingElem
    {
        public static int solution(int[] A)
        {
            long sum = (A.Length * (A.Length + 1L)) / 2L;
            long sumA = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
            }
            long diff = (A.Length + 1L) - (sumA - sum);
            return (int)Math.Min(int.MaxValue, diff);
        }
    }
}
