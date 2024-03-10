using System;

namespace Learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");*/

            Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", long.MinValue);

            Console.WriteLine("Biggest Decimal: {0}", decimal.MaxValue);
            Console.WriteLine("Smallest Decimal: {0}", decimal.MinValue);

            decimal decPiValue = 3.142857142857143M;
            decimal decBigNum = 3.0000000000000000000000011M;
            Console.WriteLine("DECIMAL: PI + bigNum = {0}", decPiValue + decBigNum);
            Console.ReadLine();

 
        }
    }
}