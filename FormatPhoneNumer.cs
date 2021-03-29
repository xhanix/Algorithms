using System.Text;

namespace Algos
{
    class FormatPhoneNumer
    {
        //sample input: var P = "00-44  48 5555 836";
        //sample output: 004-448-555-83-61



        //Avg. Time elapsed (100X): 00:00:00.0000056
        public static string solutionV2(string S)
        {
            var sb = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '-' || S[i] == ' ' || S[i] == '*') continue;
                if ((counter == 3 && i < S.Length - 2) || (counter == 2 && i == S.Length - 2))
                {
                    sb.Append('-');
                    counter = 0;
                }

                sb.Append(S[i]);
                counter++;

            }

            var s = sb.ToString();
            return s;
        }

        // Avg. Time elapsed (100X): 00:00:00.0000361
        public static string solution(string S)
        {
            var sb = new StringBuilder();
            var count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (int.TryParse($"{S[i]}", out int num))
                {
                    if (count == 2)
                    {
                        sb.Append($"{num}-");
                        count = 0;
                    }
                    else
                    {
                        sb.Append($"{num}");
                        count++;
                    }
                }
            }

            var s = sb.ToString();
            sb.Clear();
            if (s[s.Length - 2] == '-')
            {
                var arr = s.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 2) continue;
                    if (i == arr.Length - 3)
                    {
                        sb.Append($"-{arr[i]}");
                    }
                    else
                        sb.Append(arr[i]);
                }
                s = sb.ToString();
            }
            return s.Trim('-');
        }
    }
}
