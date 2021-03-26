using System;
namespace Algos
{
    public static class BinaryGap
    {
        /// <summary>
        /// O(n)
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int solution(int N)
        {
            var b = Convert.ToString(N, 2);
            if (b.Length < 2) return 0;
            long firstIdx = -1;
            long max = 0;
            for (int i = 0; i < b.Length - 1; i++)
            {
                if (firstIdx == -1 && b[i] == '1' && b[i + 1] == '0')
                {
                    firstIdx = i;
                }
                else if (b[i] == '0' && b[i + 1] == '1' && firstIdx > -1)
                {
                    var l = i - firstIdx;
                    max = Math.Max(max, l);
                    firstIdx = -1;
                }

            }
            return (int)Math.Min(int.MaxValue, max);
        }
    }
}
