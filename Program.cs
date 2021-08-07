using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert string to integer
            int num = Convert.ToInt32("45");
            Console.WriteLine(num);

            // string to integer and math function
            Console.WriteLine(num + 6);

            //Calculator

            //Adding two integers
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            //Adding two doubles (due to decimals)
            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num3 + num4);








        }
    }
}
