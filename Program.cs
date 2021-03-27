using System;
using System.Collections.Generic;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            var P = new int[] { 2, 5, 0 };
            var Q = new int[] { 4, 5, 6 };
            var S = "CAGCCTA";
            Console.WriteLine(GenomicRangeQuery.solution(S, P, Q));
        }
    }
}
