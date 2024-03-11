using System;

namespace Learning
{
    public class Program
    {

        // ---------- FUNCTIONS DEFINITIONS --------

        static void PrintArray(int[] ArrayName, string message)
        {
            foreach (var item in ArrayName)
            {
                Console.WriteLine($"{message} : {item}");
            }
        }

        // END OF FUNCTIONS

        static void Main(string[] args)
        {
            /*Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");*/

            /*Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Long: {0}", long.MinValue);

            Console.WriteLine("Biggest Decimal: {0}", decimal.MaxValue);
            Console.WriteLine("Smallest Decimal: {0}", decimal.MinValue);
            decimal decPiValue = 3.142857142857143M;
            decimal decBigNum = 3.0000000000000000000000011M;
            Console.WriteLine("DECIMAL: PI + bigNum = {0}", decPiValue + decBigNum);

            Console.WriteLine("Biggest Double: {0}", Double.MaxValue);
            Console.WriteLine("Smallest Double: {0}", Double.MinValue);
            double dblPiVal = 3.142857142857143;
            double dblBigNum = 3.000000000000003;
            Console.WriteLine("DBl: PI + BigNum = {0}", dblBigNum + dblPiVal);

            Console.WriteLine("Biggest Float: {0}", float.MaxValue);
            Console.WriteLine("Smallest Float: {0}", float.MinValue);
            double fltPiVal = 3.14285F;
            double fltBigNum = 3.00003F;
            Console.WriteLine("Flt: PI + BigNum = {0}", fltBigNum + fltPiVal);

            string strVal = dblFrmString.ToString();*/

            // BOOLEAN FROM STRING
            /*bool boolFrmString = bool.Parse("true");
            Console.WriteLine($"boolFrmString: {boolFrmString}");
            Console.WriteLine($"Data type of boolFrmString: {boolFrmString.GetType()}");
            int intFrmString = int.Parse("100");
            Console.WriteLine($"intFrmString: {intFrmString}");
            Console.WriteLine($"Data type of intFrmString: {intFrmString.GetType()}");
            double dblFrmString = double.Parse("1.234");
            Console.WriteLine($"dblFrmString: {dblFrmString}");
            Console.WriteLine($"Data type of dblFrmString: {dblFrmString.GetType()}");
            
            string strVal1 = boolFrmString.ToString();
            Console.WriteLine($"strVal1: {strVal1}");
            Console.WriteLine($"Data type of strVal1: {strVal1.GetType()}");
            string strVal2 = intFrmString.ToString();
            Console.WriteLine($"strVal2: {strVal2}");
            Console.WriteLine($"Data type of strVal2: {strVal2.GetType()}");
            string strVal3 = dblFrmString.ToString();
            Console.WriteLine($"strVal3: {strVal3}");
            Console.WriteLine($"Data type of strVal3: {strVal3.GetType()}");

            // converting double to integer causes lose of value after integer so it is called explicit conversion
            double dblNum = 3.14;
            int intFromDblNum = (int)dblNum;
            Console.WriteLine($"\n\ndblNum:{dblNum}");
            Console.WriteLine($"intFromDblNum: {intFromDblNum}");*/

            /*Console.WriteLine("Currency: {0:c}", 23.454);
            Console.WriteLine("Padding with 0s: {0:d4}", 23);
            Console.WriteLine("3 Decimals: {0:f3}", 23.4546);
            Console.WriteLine("Commmas: {0:n8}", 230000);*/

            /*string randString = "Rojesh Shrestha";
            Console.WriteLine($"String Length:{randString.Length}");
            Console.WriteLine("String Contains 'esh'?: {0}", randString.Contains("esh"));
            Console.WriteLine($"Index of 'esh' is {randString.IndexOf("esh")}");
            Console.WriteLine("Remove String: {0}", randString.Remove(5,2));
            Console.WriteLine($"Insert 'Kumar': {randString.Insert(7, "Kumar ")} ");
            Console.WriteLine($"Replace Rojesh by Rasesh: {randString.Replace("Rojesh", "Rasesh")}");
            Console.WriteLine($"Compare A to B: {String.Compare("A", "B", StringComparison.OrdinalIgnoreCase)}");
            // Compare string and ignore case
            // < 0: str1 preceeds str2
            // =0: equal or same
            // > 0: str2 preceeds str1

            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("A = a :{0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Padding Left: {0}", randString.PadLeft(30, '.'));
            Console.WriteLine("Padding Right: {0}", randString.PadRight(20, '.'));
            Console.WriteLine("Trim: {0}", randString.Trim());
            string newStr = String.Format("{0} saw a {1} {2} in the {3}", "Rojesh", "dog", "sleeping", "mat");
            Console.WriteLine(newStr + " which seems cute");
            // \' \' \\ \t \n
            Console.WriteLine(@"I wrote exactly this\n");*/

            // Arrays
            int[] Nums = new int[3];
            Nums = [1,2,3,4];
            for (int i = 0; i < Nums.Length; i++)
                Console.WriteLine(Nums[i]);

            string[] customers = { "Rojesh", "Ram", "Sita" };
            var employees = new[] { "Rojesh", "Ram", "Sita" };
            for (int i = 0; i < customers.Length; i++)
                Console.WriteLine($"Index:{i}\n Data: {customers[i]} \n");
            Console.WriteLine("\n");
            object[] random = { "Rojesh", 25675, true };
            for (int i = 0; i < random.Length; i++)
                Console.WriteLine(random[i].GetType());
            Console.WriteLine("---------------------------------------------");
            string[,] custNames = new string[3, 2] {
                { "Rojesh", "Shrestha"},
                { "Sachin", "Khadka"},
                { "Bibek", "Jha"}
            };
            Console.WriteLine("Multi-Dimensional Array:\n");
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j<2; j++)
                {
                    Console.Write($"{custNames[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine(custNames.GetValue(0, 0));


            int[] randNums = { 1, 4, 9, 16 };
            PrintArray(randNums, "hola mi'amore");

            Console.ReadLine();



        }
    }
}