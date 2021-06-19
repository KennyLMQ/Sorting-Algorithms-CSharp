using System;

namespace MergeSort
{
    public class Algorithm
    {
        public static void MergeSort(int[] array)
        {
            Console.WriteLine("Start MergeSort: " + string.Join(",", array));

            //Console.WriteLine("Before Sort: " + string.Join(",", array[1..2]));
            Sort(array, 0, array.Length - 1);

            Console.WriteLine("End MergeSort: " + string.Join(",", array));
        }

        private static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                Console.WriteLine("Before Sort:" + string.Join(",", array) + " L:" + left.ToString() + " R:" + right.ToString());

                int middle = left + (right - left) / 2;

                Sort(array, left, middle);
                Sort(array, middle + 1, right);

                Merge(array, left, middle, right);

                Console.WriteLine("After Sort: " + string.Join(",", array));
            }
        }

        private static void Merge(int[] array, int left, int middle, int right)
        {
            // Find sizes of two
            // subarrays to be merged
            int leftArraySize = middle - left + 1;
            int rightArraySize = right - middle;

            // Create temp arrays
            int[] leftArray = new int[leftArraySize];
            int[] rightArray = new int[rightArraySize];
            int leftIndex, rightIndex;

            // Copy data to temp arrays
            for (leftIndex = 0; leftIndex < leftArraySize; ++leftIndex)
                leftArray[leftIndex] = array[left + leftIndex];
            for (rightIndex = 0; rightIndex < rightArraySize; ++rightIndex)
                rightArray[rightIndex] = array[middle + 1 + rightIndex];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            leftIndex = 0;
            rightIndex = 0;

            // Initial index of merged
            // subarry array
            int arrayIndex = left;
            while (leftIndex < leftArraySize && rightIndex < rightArraySize)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[arrayIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[arrayIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                arrayIndex++;
            }

            // Copy remaining elements
            // of L[] if any
            while (leftIndex < leftArraySize)
            {
                array[arrayIndex] = leftArray[leftIndex];
                leftIndex++;
                arrayIndex++;
            }

            // Copy remaining elements
            // of R[] if any
            while (rightIndex < rightArraySize)
            {
                array[arrayIndex] = rightArray[rightIndex];
                rightIndex++;
                arrayIndex++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Algorithm.MergeSort(new int[] { 12, 11, 13, 5, 6, 7, 7 });
        }
    }
}
