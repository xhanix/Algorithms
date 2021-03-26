namespace Algos
{
    public static class CyclicRotation
    {
        public static int[] solution(int[] A, int K)
        {
            if (A.Length == K || A.Length == 0) return A;

            int shiftBy = K / A.Length;
            var last = A[A.Length - 1];
            while (shiftBy >= 0)
            {
                for (int i = A.Length - 1; i > 0; i--)
                {
                    A[i] = A[i - 1];
                    if (i - 1 == 0)
                    {
                        A[0] = last;
                        last = A[A.Length - 1];
                    }
                }
                shiftBy--;
            }
            return A;
        }
    }
}
