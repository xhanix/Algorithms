using System.Collections.Generic;

namespace Algos
{
    public static class UndirectedGraph
    {
        //In undirected graph consisting of N nodes, numbered from 1 to N, and M edges.
        //A pair (A[K], B[K]), for K from 0 to M-1, describes an edge between vertex A[K] and vertex B[K].
        //Given an integer N and two arrays A and B of M integers each, returns true if there exists a path from vertex 1 to N going through all vertices, one by one, in increasing order, or false otherwise.
        //sample input: 3, new int[] { 1, 3 }, new int[] { 2, 2 } => with edges(1, 2) and (3, 1) there is path
        //sample input: 4, new int[] { 1, 2, 4, 4, 3 }, new int[] { 2, 3, 1, 3, 1 } => with edges(1, 2), (2, 3) and (4, 3) there is path
        //sample input: 4, new int[] { 1, 2, 1, 3 }, new int[] { 2, 4, 3, 4 } => there is NO path
        public static bool solution(int N, int[] A, int[] B)
        {
            var list = new Dictionary<int, List<int>>();
            for (int i = 0; i < A.Length; i++)
            {
                if (list.ContainsKey(A[i]))
                {
                    list[A[i]].Add(B[i]);
                }
                else
                {
                    list.Add(A[i], new List<int> { B[i] });
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (!list.ContainsKey(B[i]))
                {
                    list.Add(B[i], new List<int> { A[i] });
                }
                else
                {
                    list[B[i]].Add(A[i]);
                }
            }
            var visited = 1;
            for (int i = 1; i < N; i++)
            {
                if (!list.ContainsKey(i)) continue;
                var neighbors = list[i];
                if (neighbors.Contains(i + 1))
                {
                    visited++;
                }
            }

            return visited == N;
        }
    }
}
