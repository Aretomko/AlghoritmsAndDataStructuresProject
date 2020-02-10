using System;
using System.Diagnostics;

namespace AlgorithmsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arrays = new  int [][]{new int[] { 8, 5, 4, 6, 2, 9, 1 },new int[] { 3, 5, 2, 1, 9, 8, 7 },new int[] { 2, 3, 9, 4, 1, 2, 6 },new int[] { 6, 0, 1, 2, 3, 4, 5 },new int[] { 7, 8, 9, 0, 9, 8, 7 } };
            foreach (int[] i in arrays)
            {
                Stopwatch timer = Stopwatch.StartNew();
                timer.Start();
                Sort.IsertionSort(i);
                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);
                timer.Reset();
            }
            foreach (int[] i in arrays)
            {
                Stopwatch timer = Stopwatch.StartNew();
                timer.Start();
                Sort.SelectionSort(i);
                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);
                timer.Reset();
            }
            foreach (int[] i in arrays)
            {
                Stopwatch timer = Stopwatch.StartNew();
                timer.Start();
                Sort.MergeSort(i);
                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);
                timer.Reset();
            }
            foreach (int[] i in arrays)
            {
                Stopwatch timer = Stopwatch.StartNew();
                timer.Start();
                Sort.QuickSort(i,0,i.Length-1);
                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);
                timer.Reset();
            }
            Console.ReadLine();
        }
    }
}
