using System.Collections.Generic;

namespace Algos
{
    public static class FrogRiverOne
    {
        public static int solution(int X, int[] A)
        {
            var hash = new HashSet<int>();
            var res = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] <= X)
                {
                    hash.Add(A[i]);
                }
                if (hash.Count == X)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
    }
}
