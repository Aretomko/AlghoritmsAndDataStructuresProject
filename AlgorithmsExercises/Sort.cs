using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsExercises
{
    public class Sort
    {
        public static int[] IsertionSort(int[] inputArray) 
        {
            if (inputArray.Length == 0 || inputArray.Length == 1) return inputArray;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        public static int[] SelectionSort(int[] inputArray) 
        {
            if (inputArray.Length == 0 || inputArray.Length == 0) return inputArray;

            int temp, smallest;
            int n = inputArray.Length;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (inputArray[j] < inputArray[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = inputArray[smallest];
                inputArray[smallest] = inputArray[i];
                inputArray[i] = temp;
            }
            return inputArray;
        }
        public static int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            if (array.Length <= 1)
                return array;
            int midPoint = array.Length / 2;
            left = new int[midPoint];
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            else
                right = new int[midPoint + 1];
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];   
            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            left = MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right);
            return result;
        }
        private static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
        public static int[] QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
            return arr;
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }
}
