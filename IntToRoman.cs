using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public static class IntToRoman
    {
        public static string Convert(int num)
        {
            var nums = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            var sBuilder = new StringBuilder();
            for (int i = 0; i < nums.Length && num > 0; i++)
            {
                if (nums[i] > num)
                    continue;
                while (nums[i] <= num)
                {
                    num -= nums[i];
                    sBuilder.Append(symbols[i]);
                }
            }
            return sBuilder.ToString();
        }

        public static int Reverse(string roman)
        {
            var dic = new Dictionary<char, int> { { 'M', 1000 }, { 'D', 500 }, { 'C', 100 }, { 'L', 50 }, { 'X', 10 }, { 'V', 5 }, { 'I', 1 } };
            var res = dic[roman[roman.Length - 1]];
            for(int i = roman.Length - 2; i >= 0; i--)
            {
                if (dic[roman[i]] < dic[roman[i + 1]])
                {
                    res -= dic[roman[i]];
                }
                else
                {
                    res += dic[roman[i]];
                }
            }
            return res;
        }
    }
}
