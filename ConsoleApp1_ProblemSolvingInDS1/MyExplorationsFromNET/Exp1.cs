using System;
using System.Collections.Generic;
using System.Text;

// Codewrinkles YouTube
// bubble sort

namespace ConsoleApp1_ProblemSolvingInDS1.MyExplorationsFromNET
{
    public class Exp1
    {
        public static Random rand = new Random();


        public static void BubblesortArray()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);

            }
            Console.WriteLine();
            Console.WriteLine("Display the Array", -30);
            foreach (int i in array)
            {
              Console.Write("  " + i);
            }
            Console.WriteLine();
            Console.WriteLine("After BUBBLE SORT ", -30);
            Bubblesort(array);


        }

        private static void Bubblesort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j + 1] = temp;
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine(" The Sorted array of Numbers ");
            foreach(var number in numbers)
            {
                Console.Write(" "+ number);
            }
            Console.WriteLine();
        }
    }
}
