using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_ProblemSolvingInDS1.MyExplorationsFromNET
{
    public class Check_1
    {
        public static void mycheck1()
        {
            int x, y;
            Console.WriteLine(  );
            Console.WriteLine("Enter the numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("The Addition is {0}" , x+y);
            Console.WriteLine($" The Addition with symbol $ is (X+Y)");
            Console.WriteLine("Addition will be " , (x+y).ToString());
            Console.WriteLine($"The Value of added numbers is: {x + y}");
            Console.WriteLine("The Value of added numbers are:{0}", (x + y).ToString());
            DateTime dt = DateTime.UtcNow;
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.Hour);
            Console.WriteLine(" Date is {0}", dt);
            Console.WriteLine(" Date is {0}", dt.ToLongDateString());
            Console.WriteLine(" Date is {0}", dt.ToShortTimeString());
            Console.WriteLine(" Date is {0:d}", dt);
            Console.WriteLine(" Date is {0:D}", dt);
            Console.WriteLine(" Time is {0:t}", dt);
            Console.WriteLine(" Time is {0:T}", dt);


        }
    }
}
