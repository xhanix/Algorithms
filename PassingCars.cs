namespace Algos
{
    public static class PassingCars
    {
        public static int solution(int[] A)
        {
            var eastCount = 0;
            var passed = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0) eastCount++;
                else if (A[i] == 1)
                {
                    var p = passed + eastCount;
                    if (p <= 1000000000)
                        passed = p;
                    else
                    {
                        passed = -1;
                        break;
                    }

                }

            }
            return passed;
        }
    }
}
