using System;
using ConsoleApp1_ProblemSolvingInDS1.DS_Book_probSolve;
using ConsoleApp1_ProblemSolvingInDS1.MyExplorationsFromNET;


namespace ConsoleApp1_ProblemSolvingInDS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Inside Sequential Search");
            PROB1.SequentialSearch(array, array.Length, 7);
            Console.WriteLine("Sequential Search Result is : " + PROB1.SequentialSearch(array, array.Length, 7));
            Exp1.BubblesortArray();
            Check_1.mycheck1();           
            Console.WriteLine("   *************************************** ");

            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            Exp2.printArray_1(arr, n);
            Exp2.MyQuickSortTesting(arr, 0, n - 1);
            Console.WriteLine("sorted array ");            
            Exp2.printArray_1(arr, n);
            Console.WriteLine("With PrintArray");
            Exp2.PrintArray();
            Console.WriteLine(" :::::::: ***************::::::::");
            //Exp3.Print_Quck_Sort();
            Exp4.Printarray();
            Console.WriteLine();
            Exp5.Display();
            Exp_7.GFG_Bubble.display_1();
            Exp7.DisplayBubblesortoptimized();
            Exp8.Insertion_Sort();
            Exp9.InsertionSort.Display();
            Exp10.display();
            Exp_1.HeapSort.HeapDisPlay();
            Exp_2.GFG.Display_Selection();
            Exp_3.SelectionSortCideWrinkle();
            
        }


    }
}
