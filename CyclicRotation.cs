namespace Algos
{
    public static class CyclicRotation
    {
        //Avg. Time elapsed (3X): 00:00:00.5864256
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



        //using queue/dequeue (range 1-100000000) d = 4 : Avg. Time elapsed (3X): 00:00:01.4334910
        //using buffer array(range 1-100000000) d = 4 : Avg. Time elapsed (3X): 00:00:00.5306521
        //Avg. Time elapsed (3X) K = 6; range = 1-100000000: 00:00:00.5864256
        public static int[] rotLeft(int[] a, int d)
        {
            var buffer = new int[d];
            for (int i = 0; i < d; i++)
            {
                buffer[i] = a[i];
            }
            for (int i = 0; i < a.Length - d; i++)
            {
                a[i] = a[i + d];

            }
            for (int i = 0; i < buffer.Length; i++)
            {
                a[(a.Length - 1) - i] = buffer[(buffer.Length - 1) - i];
            }
            return a;
        }


        //Avg. Time elapsed (3X) K = 6; range = 1-100000000: 00:00:00.5983797
        public static int[] rotRight(int[] A, int K)
        {
            if (A.Length == 0 || K == 0) return A;
            if (K >= A.Length)
            {
                K = K % A.Length;
            }
            var buffer = new int[K];
            for (int i = 0; i < K; i++)
            {
                buffer[(buffer.Length - 1) - i] = A[(A.Length - 1) - i];
            }

            for (int i = A.Length - 1; i > 0; i--)
            {
                A[i] = A[i - K];
                if (i == K) break;

            }
            for (int i = 0; i < buffer.Length; i++)
            {
                A[i] = buffer[i];
            }
            return A;
        }

    }



}
