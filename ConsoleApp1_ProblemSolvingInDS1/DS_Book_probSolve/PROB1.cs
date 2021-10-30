using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProblemSolvingInDS1.DS_Book_probSolve
{
    public class PROB1
    {

        public static int SequentialSearch(int[] arr, int size, int value)
        {
            for (int i = 0; i < size; i++)
            {

                if (value == arr[i])
                    return i;

            }

            return -1;
        }
    }

}
