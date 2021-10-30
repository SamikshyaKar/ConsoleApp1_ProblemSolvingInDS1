 using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProblemSolvingInDS1.MyExplorationsFromNET
{
    //codewrinkle insertion sort
   public class Exp8
    {
        public static Random rand = new Random();
        public static void Insertion_Sort()
        {
            int[] arr = new int[10];
            for (int i =0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);

            }

            Console.WriteLine("  ************ The Unsorted array of Inserion Sort " );

            foreach(int i in arr)
            {
                Console.Write(" " +i);
            }

            InsertionSort(arr);
        }

        private static void InsertionSort(int[] arr)
        {
            
            for(int i=0; i<arr.Length-1;i++)
            {
                for(int j=i+1;j>0;j--)
                {
                    if(arr[j-1]>arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("      The Sorted array as Follows ");
            foreach (int i in arr)
            {
                Console.Write(" " + i);

            }
            Console.WriteLine();
        }
    }
}
