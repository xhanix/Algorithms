namespace Algos
{
    // Hacker rank Fraudulent Activity Notifications
    //some kind of sorting is needed to get the median of the spending in the days before
    //queues and SortedSets gave accurate results but too slow for large sets
    //since we know the range of spending is 0 to 200 - we can use count sorting as it is faster that comparison sorting
    // we dont actually need a sorted array of spendings - we use the counts until we reach the median index then use the count index to get the  median spending
    public static class FraudulentActivityNotifications
    {
        public static int activityNotifications(int[] expenditure, int d)
        {
            var notifications = 0;

            // count array for count sorting length is spending range + 1
            var count = new int[201];

            //median val depends on if length of d is even or odd
            var isEven = d % 2 == 0;
            var medianIdx = isEven ? d / 2 : (d + 1) / 2;


            for (int i = 0; i < expenditure.Length; i++)
            {
                //minimum needed number of days passed
                if (i >= d)
                {
                    var sum = count[0];
                    double med = 0;
                    //if median is even, this is the first value
                    var firstVal = int.MinValue;
                    //traverse count array to count days where there was a spending,
                    //if we are at a day number == median index we get the value of spending for that day (this is our median spending)
                    for (int j = 1; j < count.Length; j++)
                    {
                        sum += count[j];
                        if (sum >= medianIdx)
                        {
                            if (!isEven)
                            {
                                med = j;
                                break;
                            }
                            else
                            {
                                if (sum == medianIdx)
                                {
                                    firstVal = j;
                                }
                                else if (firstVal == int.MinValue)
                                {
                                    med = j;
                                    break;
                                }
                                else
                                {
                                    med = (firstVal + j) / 2d;
                                    break;
                                }

                            }

                        }
                    }

                    //does the current spending meed that notification threshold of 2 * median spending?
                    if (expenditure[i] >= 2 * med) notifications++;

                    //shift spendings window for day after (remove first spending before the range of d)
                    count[expenditure[i - d]]--;
                }

                //count number of spending values (e.g. $10 today and $10 tomorrow, index 10 of count array becomes 2)
                count[expenditure[i]]++;

            }
            return notifications;
        }
    }
}
