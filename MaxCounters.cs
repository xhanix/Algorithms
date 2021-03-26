using System;
namespace Algos
{
    public static class MaxCounters
    {
        public static int[] solution(int N, int[] A)
        {
            var res = new int[N];
            var max = 0;
            var level = 0;
            for (int K = 0; K < A.Length; K++)
            {
                if (A[K] >= 1 && A[K] <= N)
                {
                    if (res[A[K] - 1] < level)
                    {
                        res[A[K] - 1] = level;
                    }
                    res[A[K] - 1]++;
                    max = Math.Max(res[A[K] - 1], max);
                }
                else if (A[K] == N + 1)
                {
                    level = max;
                }
            }
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] < level)
                {
                    res[i] = level;
                }
            }
            return res;
        }
    }
}
