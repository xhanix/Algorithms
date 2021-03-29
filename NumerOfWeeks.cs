using System.Collections.Generic;

namespace Algos
{
    public static class NumerOfWeeks
    {
        //summary report: https://app.codility.com/c/feedback/7TB9M8-H2M/

        // vacation weeks - count number of weeks from first Monday of a month to last Sunday of one or more months later
        // Y = year of vacation; A = start month;  B = end month; W = 1st january that year

        //sample inputs:
        //2014, "April","May", "Wednesday" => 8 Weeks
        //2014, "April","August", "Wednesday" => 21 Weeks
        //2014, "February","April", "Wednesday" => 12 Weeks
        //2014, "February","February", "Wednesday" => 3 Weeks
        //2015, "February","February", "Tuesday" => 3 Weeks
        //2015, "June","July", "Thursday" => 8 Weeks
        //2015, "January", "December", "Thursday" => 51 Weeks
        //2021, "January", "March", "Friday" => 12 Weeks
        //2021, "June", "July", "Friday" => 7 Weeks
        public static int solution(int Y, string A, string B, string W)
        {
            var isLeap = Y % 4 == 0;
            var dic = new Dictionary<string, int> { { "January", 1 }, { "February", 2 }, { "March", 3 }, { "April", 4 },
            { "May", 5 }, {"June", 6 }, {"July", 7 }, {"August", 8 }, {"September", 9 }, {"October", 10 }, {"November", 11 }, {"December", 12 } };
            var day = new Dictionary<string, int> { { "Monday", 1 }, { "Tuesday", 2 }, { "Wednesday", 3 }, { "Thursday", 4 },
            { "Friday", 5 }, {"Saturday", 6 }, {"Sunday", 7 } };
            var feb = isLeap ? 29 : 28;
            var monthDays = new int[] { 31, feb, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            var presumDays = new int[monthDays.Length];
            presumDays[0] = monthDays[0];
            for (int i = 1; i < monthDays.Length; i++)
            {
                presumDays[i] = presumDays[i - 1] + monthDays[i];
            }
            var holidayStarted = false;
            var daysCount = 0;
            var dayOfWeek = day[W];
            var lastDayOfWeek = 0;
            var daysToStartOfStartMonth = A == "January" ? 0 : presumDays[dic[A] - 1 - 1];
            for (int i = 0; i < presumDays[presumDays.Length - 1]; i++)
            {

                if (!holidayStarted && dayOfWeek == day["Monday"] && i >= daysToStartOfStartMonth && i < presumDays[dic[B] - 1])
                {
                    //holiday starts first Monday of the Beginning Month
                    holidayStarted = true;
                }



                if (holidayStarted && i == presumDays[dic[B] - 1] - 1)
                {
                    //Count days to last day of End Month & record which day of week it is
                    lastDayOfWeek = dayOfWeek;
                    break;
                }

                if (holidayStarted)
                {
                    daysCount++;
                }

                if (dayOfWeek >= day["Sunday"])
                {
                    dayOfWeek = day["Monday"];
                }
                else
                {
                    dayOfWeek++;
                }

            }

            daysCount = daysCount - (lastDayOfWeek - day["Monday"]); //last day is Last Monday of the End Month
            var weeks = daysCount / 7;
            return weeks;

        }
    }
}
