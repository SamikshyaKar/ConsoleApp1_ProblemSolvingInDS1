using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProblemSolvingInDS1.MyExplorationsFromNET
{
    // Codewrinkles YouTube
    public class Exp2
    {
        //public static void swap(int[] arr, int i,int j)
        //{
        //    int temp = arr[i];
        //    arr[i] = arr[j];
        //    arr[j] = temp;
        //}

        public static int partition (int[]arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for(int j= low; j<high; j++)
            {
                if(arr[j]< pivot)
                {
                    i++;
                    //swap(arr, i, j);
                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            //swap(arr, i + 1, pivot);
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return (i + 1);

        }
       public static void MyQuickSortTesting(int[] QuickSortArray, int Start, int End)
        {
                    
            if (Start<End)
            {
                int Piv_Position = partition(QuickSortArray, Start, End);
                MyQuickSortTesting(QuickSortArray, Start, Piv_Position - 1);
                MyQuickSortTesting(QuickSortArray, Piv_Position + 1, End);

            }        
        }
       public static void PrintArray()
        {
            Console.WriteLine();
            //int[] myQuick = new int[] { 12, 34, 45, 56, 43, 45, 56, 67, 62, 36 };
            //foreach(int i in myQuick)
            //{

            //    Console.Write(" " + i );
            //}
            //Console.WriteLine();

            // MyQuickSortTesting(myQuick, 0, myQuick.Length);

            //Console.WriteLine("After Sorted by Quick SORT");
            //foreach(int j in myQuick)
            //{
            //    Console.Write(j + " ");
            //}
            //Console.WriteLine();
            Console.WriteLine();
            int[] arr = { 34,89,1,45,67,2};
            int n = arr.Length;
            foreach(int p in arr)
            {
                Console.Write(" " + p);
            }
            Console.WriteLine();
            Console.WriteLine("The Sorted array Is : ");
            MyQuickSortTesting(arr, 0, n - 1);
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

        }

      public  static void printArray_1(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }


    }
}
