namespace Algos
{
    public static class MinAvgTwoSlice
    {
        public static int solution(int[] A)
        {
            var preSum = new int[A.Length];
            preSum[0] = A[0];
            var minIdx = int.MaxValue;
            for (int i = 1; i < A.Length; i++)
            {
                preSum[i] = preSum[i - 1] + A[i];

            }
            double minAvg = int.MaxValue;
            for (int P = 0; P < preSum.Length - 1; P++)
            {
                for (int Q = P + 1; Q < preSum.Length; Q++)
                {
                    if (Q - P > 3) break; // Mathematical theory says that slice cannot be longer than 3
                    var l = (Q - P) + 1;
                    var sum = (preSum[Q] - preSum[P]) + (preSum[P] - (P > 0 ? preSum[P - 1] : 0));
                    var avg = (double)sum / (double)l;
                    if (avg < minAvg)
                    {
                        minAvg = avg;
                        minIdx = P;
                    }
                }
            }
            return minIdx;
        }
    }
}
