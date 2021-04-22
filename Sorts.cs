using System;
using System.Linq;

namespace Algos
{
    public static class Sorts
    {
        public static void QuickSort(int[] ar)
        {
            QuickSort(ar, 0, ar.Length - 1);
        }

        private static void QuickSort(int[] ar, int from, int to)
        {
            if (from < to)
            {
                // PARTITION
                //take first element as pivot
                var pivot = ar[from];
                var leftIdx = 0;
                //start from beginning of array
                for (int i = 0; i <= to; i++)
                {
                    //if element value smaller than pivot value shift to left index (leftIdx);
                    if (ar[i] < pivot)
                    {
                        //shift larger value from its current index to left of the pivot-
                        var currIdx = i;
                        while (currIdx > leftIdx)
                        {
                            var tmp = ar[currIdx];
                            ar[currIdx] = ar[currIdx - 1];
                            ar[currIdx - 1] = tmp;
                            currIdx--;
                        }
                        leftIdx++;
                    }
                }
                //Recursive calls on left and right sides of the pivot
                QuickSort(ar, from, leftIdx - 1);
                QuickSort(ar, leftIdx + 1, to);
                Console.WriteLine(string.Join(" ", ar.Skip(from).Take(to - from + 1)));
            }
        }
        //start from left -> move smaller elements to left
        public static void InsertSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var j = i + 1;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    var tmp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = tmp;
                    j--;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }

        //start from right -> larger elements to right
        public static void InsertSortBackScan(int[] arr)
        {
            for (int i = arr.Length; i > 0; i--)
            {
                var j = i - 1;
                while (j < arr.Length - 1 && arr[j] > arr[j + 1])
                {
                    var tmp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = tmp;
                    j++;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
