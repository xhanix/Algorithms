using System.Collections.Generic;

namespace Algos
{
    public static class LongestCommonSubstring
    {
        // Driver function
        public static int commonChild(string s1, string s2)
        {
            int m = s1.Length;
            int n = s2.Length;
            int[,] memo = new int[s1.Length + 1, s2.Length + 1];
            for (int i = 1; i < s1.Length + 1; i++)
            {
                for (int j = 1; j < s2.Length + 1; j++)
                {
                    memo[i, j] = int.MinValue;
                }
            }
            var res = lcs(s1, s2, m, n, memo);
            var con = new List<char>();
            reconstruct(s1, s2, s1.Length, s2.Length, memo, con);
            return res;
        }

        // Reconstruct string from dp table
        public static void reconstruct(string a, string b, int i, int j, int[,] memo, List<char> res)
        {
            if (i == 0 || j == 0)
            {
                res.Clear();
            }
            else if (a[i - 1] == b[j - 1])
            {

                reconstruct(a, b, i - 1, j - 1, memo, res);
                res.Add(a[i - 1]);
            }
            else if (memo[i, j] == memo[i - 1, j])
            {
                reconstruct(a, b, i - 1, j, memo, res);
            }
            else if (memo[i, j] == memo[i, j - 1])
            {
                reconstruct(a, b, i, j - 1, memo, res);
            }
        }



        //create dp table and calculate length of longest common substring
        public static int lcs(string s1, string s2, int l1, int l2, int[,] memo)
        {
            if (l1 == 0 || l2 == 0) return 0;
            if (memo[l1, l2] > int.MinValue) return memo[l1, l2];
            if (s1[l1 - 1] == s2[l2 - 1])
            {

                memo[l1, l2] = 1 + lcs(s1, s2, l1 - 1, l2 - 1, memo);
            }
            else
            {
                memo[l1, l2] = max(lcs(s1, s2, l1 - 1, l2, memo), lcs(s1, s2, l1, l2 - 1, memo));
            }

            return memo[l1, l2];
        }

        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
