using AlgorithmsExercises;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlgorithmsTest
{
    [TestFixture]
    public class SortTest
    {
        //Insertion Sort testing
        [TestCase(new int[] { 8, 5, 4, 6, 2, 9, 1 }, new int[] { 1, 2, 4, 5, 6, 8, 9 })]
        [TestCase(new int[] { 3, 5, 2, 1, 9, 8, 7 }, new int[] { 1, 2, 3, 5, 7, 8, 9 })]
        [TestCase(new int[] { 2, 3, 9, 4, 1, 2, 6 }, new int[] { 1, 2, 2, 3, 4, 6, 9 })]
        [TestCase(new int[] { 6, 0, 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 7, 8, 9, 0, 9, 8, 7 }, new int[] { 0, 7, 7, 8, 8, 9, 9 })]
        public void InsertionTest_InsertingAnArrayOfData_GettingSortedArray(int[] inputArray, int[] outputArray) 
        {
            Assert.That(Sort.IsertionSort(inputArray), Is.EquivalentTo(outputArray));
        }
        [TestCase(new int[] {1} )]
        [TestCase(new int[] {} )]
        public void InsertionTest_InsertingArrayWithLenth0or1_ReturningTheSameArray(int[] inputArray) 
        {
            Assert.That(Sort.IsertionSort(inputArray), Is.EquivalentTo(inputArray));
        }
        //Selection sort testing
        [TestCase(new int[] { 8, 5 ,4 ,6 ,2 ,9 ,1 }, new int[] { 1, 2, 4, 5, 6, 8, 9 })]
        [TestCase(new int[] { 3, 5, 2, 1, 9, 8, 7 }, new int[] { 1, 2, 3, 5, 7, 8, 9 })]
        [TestCase(new int[] { 2, 3, 9, 4, 1, 2, 6 }, new int[] { 1, 2, 2, 3, 4, 6, 9 })]
        [TestCase(new int[] { 6, 0, 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 7, 8, 9, 0, 9, 8, 7 }, new int[] { 0, 7, 7, 8, 8, 9, 9 })]
        public void SelectionSortTest_InseringAnArray_GettingSortedArray(int[] inputArray, int[] outputArray) 
        {
            Assert.That(Sort.SelectionSort(inputArray), Is.EqualTo(outputArray));
        }

        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { })]
        public void SelectionSortTest_InsertingArrayWithLenth0or1_ReturningTheSameArray(int[] inputArray)
        {
            Assert.That(Sort.SelectionSort(inputArray), Is.EquivalentTo(inputArray));
        }
        //merge sort test
        [TestCase(new int[] { 8, 5, 4, 6, 2, 9, 1 }, new int[] { 1, 2, 4, 5, 6, 8, 9 })]
        [TestCase(new int[] { 3, 5, 2, 1, 9, 8, 7 }, new int[] { 1, 2, 3, 5, 7, 8, 9 })]
        [TestCase(new int[] { 2, 3, 9, 4, 1, 2, 6 }, new int[] { 1, 2, 2, 3, 4, 6, 9 })]
        [TestCase(new int[] { 6, 0, 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 7, 8, 9, 0, 9, 8, 7 }, new int[] { 0, 7, 7, 8, 8, 9, 9 })]
        public void MergeSortTest_InsetingAnArray_GettingSortedArray(int[] inputArray, int[] outputArray)
        { 
            Assert.That(Sort.MergeSort(inputArray), Is.EqualTo(outputArray));
        }
        //quicksort test 
        [TestCase(new int[] { 8, 5, 4, 6, 2, 9, 1 }, new int[] { 1, 2, 4, 5, 6, 8, 9 })]
        [TestCase(new int[] { 3, 5, 2, 1, 9, 8, 7 }, new int[] { 1, 2, 3, 5, 7, 8, 9 })]
        [TestCase(new int[] { 2, 3, 9, 4, 1, 2, 6 }, new int[] { 1, 2, 2, 3, 4, 6, 9 })]
        [TestCase(new int[] { 6, 0, 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 7, 8, 9, 0, 9, 8, 7 }, new int[] { 0, 7, 7, 8, 8, 9, 9 })]
        public void QuickSortTest_InsertingAnArray_GettingSortedArray(int[] inputArray, int[] outputArray) 
        {
            Assert.That(Sort.QuickSort(inputArray, 0, inputArray.Length-1), Is.EqualTo(outputArray));
        }

    }
}
