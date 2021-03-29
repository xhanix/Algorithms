using System;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            var numLoops = 10000d;
            TimeSpan sum = TimeSpan.FromMilliseconds(0);
            var printedRes = false;
            for (int i = 0; i < numLoops; i++)
            {
                var st = new System.Diagnostics.Stopwatch();
                st.Start();
                var res = UndirectedGraph.solution(6, new int[] { 1, 4, 6, 7, 8, 10, 11, 11, 5, 4, 2, 3 }, new int[] { 2, 8,7,  8, 9, 9, 10, 5, 6, 5, 3, 4 });
                st.Stop();
                if (!printedRes)
                {
                    Console.WriteLine(res);
                    printedRes = true;
                }
                if (i % (numLoops / 4) == 0)
                {
                    Console.WriteLine("...");
                }
                sum += st.Elapsed;
            }
            Console.WriteLine($"==============================================");
            Console.WriteLine($"Avg. Time elapsed ({numLoops}X): {sum / numLoops}");
            Console.WriteLine($"==============================================");
        }
    }
}
