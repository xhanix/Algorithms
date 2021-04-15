namespace Algos
{
    public static class MergeSort
    {

        public static int[] SortArray(int[] array)
        {
            if (array.Length <= 1) return array;
            int middle = array.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[array.Length - middle];

            var aIdx = 0;
            for (int i = 0; i < middle; i++)
            {
                left[aIdx] = array[i];
                aIdx++;
            }
            aIdx = 0;
            for (int i = middle; i < array.Length; i++)
            {
                right[aIdx] = array[i];
                aIdx++;
            }

            left = SortArray(left);
            right = SortArray(right);
            var res = Merge(left, right);

            return res;
        }

        public static int swaps = 0;

        static int[] Merge(int[] left, int[] right)
        {
            var result = new int[left.Length + right.Length];
            var leftIdx = 0;
            var rightIdx = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (leftIdx < left.Length && rightIdx < right.Length)
                {
                    if (left[leftIdx] >= right[rightIdx])
                    {
                        result[i] = left[leftIdx];
                        leftIdx++;
                    }
                    else
                    {
                        result[i] = right[rightIdx];
                        rightIdx++;
                        swaps += left.Length - leftIdx;
                    }
                }
                else if (leftIdx < left.Length)
                {
                    result[i] = left[leftIdx];
                    leftIdx++;
                }
                else if (rightIdx < right.Length)
                {
                    result[i] = right[rightIdx];
                    rightIdx++;
                }
            }

            return result;
        }
    }
}
