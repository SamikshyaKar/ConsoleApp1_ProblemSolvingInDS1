using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProblemSolvingInDS1.MyExplorationsFromNET
{
    // quick sort 
   public  class Exp4
    {
        public static int PartitionArray(int[] arr, int low , int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j= low; j<high; j++)
            {
                if (arr[j]< pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return (i + 1);
        }

        public static int[] Quick_Sort (int[] array, int low, int high)
        {
            if (low < high)
            {
                int piv_pos = PartitionArray(array, low, high);
                Quick_Sort(array, low, piv_pos-1);
                Quick_Sort(array, piv_pos+1, high);
             }


            return array;
        }

        public static void Printarray()
        {
            int[] array = new int[] { 12, 78, 54, 98, 37, 2 };
            foreach(int i in array)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            int n = array.Length;
            Quick_Sort(array, 0, n-1);
            Console.WriteLine(" SORTED ");
            foreach (int i in array)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();

        }



    }
}
