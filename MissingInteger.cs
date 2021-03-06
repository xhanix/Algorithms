using System;
namespace Algos
{
    public static class MissingInteger
    {
        public static int solution(int[] A)
        {
            Array.Sort(A);
            var res = 1;
            var hasGap = false;
            if (A.Length == 1) return A[0] == 1 ? 2 : 1;
            if (A[0] > 1) return 1;
            for (int i = A.Length - 1; i > 0; i--)
            {
                if (A[i] < 1 || i == 0) break;
                if (A[i] == A[i - 1]) continue;
                if (A[i] > Math.Max(A[i - 1], 0) + 1)
                {
                    res = Math.Max(A[i - 1], 0) + 1;
                    hasGap = true;
                }
            }
            if (!hasGap && A[A.Length - 1] > 0) res = A[A.Length - 1] + 1;
            return res;
        }

        // cleaner and faster approach
        public static int solutionV2(int[] A)
        {
            Array.Sort(A);
            if (A[A.Length - 1] < 1) return 1;
            var res = 0;
            var counter = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 1) continue;
                if (i < A.Length - 2 && A[i + 1] == A[i]) continue;
                if (A[i] - counter != 0)
                {
                    res = counter;
                    break;
                }
                counter++;
            }
            if (res == 0) res = A[A.Length - 1] + 1;
            return res;
        }
    }
}
