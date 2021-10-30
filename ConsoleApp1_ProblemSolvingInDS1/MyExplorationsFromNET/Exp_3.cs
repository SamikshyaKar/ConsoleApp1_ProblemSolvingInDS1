using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProblemSolvingInDS1.MyExplorationsFromNET
{

    // codewrinkle
   public  class Exp_3
    {
           
        public static Random rand = new Random();

        public static void SelectionSortCideWrinkle()
        {
            int[] arr = new int[10];
            Console.WriteLine();
            for (int i= 0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            Console.WriteLine(" The Unsorted Array Is ");
            foreach (int p in arr)
            {
                Console.Write(" " + p);
            }

            Selection_Sort(arr);
        }

        private static void Selection_Sort(int[] arr)
        {
            Console.WriteLine();
            Console.WriteLine(" The Selection Sort of CODE WRINKLE  HAH HA HA HA ");
            Console.WriteLine($" The Selection Sort of cod wrinkle ");
            
            for (int i =0; i<arr.Length-1; i++)
            {
                int min = i;

                for (int j= i+1; j<arr.Length; j++)
                {
                   if(arr[j]<arr[min])
                    {
                        min = j;
                    }

                }

                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            Console.WriteLine("    The  SORTED ARRAY IS : SELECTION SORTED "  );

            foreach(int p in arr)
            {
                Console.Write(" " + p);
            }
            Console.WriteLine(" The Sorted Array ");
        }
    }
}
