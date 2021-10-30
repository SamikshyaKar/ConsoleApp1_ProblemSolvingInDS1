using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProblemSolvingInDS1.MyExplorationsFromNET
{
    // wrong programm for Quick sort

   public class Exp3
    {
       public static void swap (int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[j] = temp;
            arr[i] = arr[j];
        }

        public static int Partition(int[] arr2, int start, int end)
        {
            int pivot = arr2[start];
            int swapindex = start;
            for(int i= start+1; i<end; i++)
            {
                if(arr2[i]<pivot)
                {
                    swapindex ++;
                    swap(arr2, i, swapindex);
                }              

            }
            swap(arr2, start, swapindex);
            return swapindex;
        }
        public static int[] Quick_Sort(int[] array, int start, int end)
        {
            if (start< end)
            {
                int pivot = Partition(array, start, end);

                Quick_Sort(array, start, pivot-1);
                Quick_Sort(array, pivot + 1, end);

            }
            return array;

        }

        public static void Print_Quck_Sort()
        {
            int[] array_1 = new int[] { 1, 4, 3, 23, 56, 5, 9, 98, 100 };
            int n = array_1.Length - 1;
            foreach (int item in array_1)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            var sorted = Quick_Sort(array_1, 0, array_1.Length);

            foreach (var item in sorted)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();
            var sorted2 = Quick_Sort(array_1, 0, n-1);
            foreach (var item in sorted2)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();

            var arr = new[] { 34, 98,12, 76, 34, -2 };
            var sorted1 = Quick_Sort(arr, 0, arr.Length);

            foreach (var item in sorted1)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();

        }
    }
}
