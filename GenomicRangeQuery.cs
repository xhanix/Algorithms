namespace Algos
{
    public static class GenomicRangeQuery
    {
        public static int[] solution(string S, int[] P, int[] Q)
        {
            var M = P.Length;
            var res = new int[M];
            var arr = S.ToCharArray();
            int[][] letters = new int[][] {
                new int[S.Length + 1],
                new int[S.Length + 1],
                new int[S.Length + 1],
            };


            for (int i = 0; i < arr.Length; i++)
            {
                var a = 0;
                var c = 0;
                var g = 0;
                if ('A' == arr[i])
                {
                    a = 1;
                }
                if ('C' == arr[i])
                {
                    c = 1;
                }
                if ('G' == arr[i])
                {
                    g = 1;
                }
                //here we calculate prefix sums. To learn what's prefix sums look at here https://codility.com/media/train/3-PrefixSums.pdf
                letters[0][i + 1] = letters[0][i] + a;
                letters[1][i + 1] = letters[1][i] + c;
                letters[2][i + 1] = letters[2][i] + g;
            }

            for (int i = 0; i < P.Length; i++)
            {
                var startIdx = P[i];
                var endIdx = Q[i] + 1;
                if (letters[0][endIdx] - letters[0][startIdx] > 0)
                {
                    res[i] = 1;
                }
                else if (letters[1][endIdx] - letters[1][startIdx] > 0)
                {
                    res[i] = 2;
                }
                else if (letters[2][endIdx] - letters[2][startIdx] > 0)
                {
                    res[i] = 3;
                }
                else
                {
                    res[i] = 4;
                }
            }

            return res;
        }
    }
}
