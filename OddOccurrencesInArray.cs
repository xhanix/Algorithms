using System;
using System.Collections.Generic;

namespace Algos
{
    public static class OddOccurrencesInArray
    {
        public static int solution(int[] A)
        {
            var h = new HashSet<int>();
            var unpaired = new int[1];
            for (int i = 0; i < A.Length; i++)
            {
                if (h.Contains(A[i]))
                {
                    h.Remove(A[i]);
                }
                else
                {
                    h.Add(A[i]);
                }
            }
            if (h.Count == 1)
            {
                h.CopyTo(unpaired);
                return unpaired[0];
            }
            else
            {
                throw new ArgumentException("No unpaired value");
            }
        }
    }
}
