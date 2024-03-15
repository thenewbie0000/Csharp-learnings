using System;
using ObjectLifeTime;
using ScopeP3;

namespace Learning
{
    public class Program
    {

        //private field
        private static string k = "";

        // ---------- FUNCTIONS DEFINITIONS --------

        static void PrintArray(int[] ArrayName, string message)
        {
            foreach (var item in ArrayName)
            {
                Console.WriteLine($"{message} : {item}");
            }
        }

        static double DoDivision(double a, double b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            return a / b;
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
            /*int[] Nums = new int[3];
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
            PrintArray(randNums, "hola mi'amore");*/

            /*Console.WriteLine("--------------------------------------");
            int[] newArray = { 1, 24, 2, 25, 7, 8, 9, 3 };
            Array.Sort(newArray);
           *//* foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(newArray);
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }*//*
            newArray.SetValue(6,0);
            PrintArray(newArray, "");
            int[] destinationArray = new int[3];
            Array.Copy(newArray, destinationArray, 3);
            PrintArray(destinationArray, "copied");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            newArray.CopyTo(anotherArray, 0);
            foreach (var item in anotherArray)
            {
                Console.WriteLine($"Copied to: {item}");
            }
            
            int[] numArray = { 1, 11, 22, 33 };
            Console.WriteLine(">10:" + Array.Find(numArray, n=> n>10));
            */

            /*int age;
            Console.WriteLine("Enter her age:");
            string strAge = Console.ReadLine();
            age = int.Parse(strAge);
            if (age > 18 && age <= 40)
                Console.WriteLine("Marry her");
            else if (age < 18)
                Console.WriteLine("Oh Boy! You are in trouble");
            else
                Console.WriteLine("Dude! Have Patience");

            string msg = age >= 18 ? "She can drive though" : "She can't drive";
            Console.Write(msg);

            string name1 = "Rojesh";
            string name2 = "rojesh";
            if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\n\nequal");
            }*/

            /*int i = 1;
            while (i<=10)
            {
                if (i%2 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }*/

            /*Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed;
            Console.WriteLine("Enter number between 1 and 10:");
            do
            {
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);
            Console.Write("You guessed write");
            */

            /*double n1 = 5;
            double n2 = 0;
            try
            {
                Console.WriteLine("5/0 = {0}", DoDivision(n1, n2));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

            }
            // any exception
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning Up");
            }*/

            // String Builders
            /* StringBuilder sb1 = new StringBuilder("Random Text");
             StringBuilder sb2 = new StringBuilder(" by Rojesh", 256);
             Console.Write("Capacity: {0}\n", sb2.Capacity);
             Console.Write("LENGTH: {0}\n", sb2.Length);
             sb2.AppendLine("\n New Appended Line");
             Console.WriteLine(sb2);
             CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
             string bestCust = "Rojesh Shrestha";
             sb2.AppendFormat(enUS, "Best Customer: {0}", bestCust);
             Console.WriteLine(sb2.ToString());
             sb2.Replace("Text", "Characters");
             Console.WriteLine(sb2.ToString());
             sb2.Clear();*/

            //string myString = "Rojesh \"Sama\" Shrestha";
            //string myString = @"Go to your C:\Drive";
            //string myString = string.Format("{0:C}", 123.45); 
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("{0:P}", .69);
            //string myString = string.Format("Phone Number: {0: (+###) ####-######}", 9779841123922);
            // string myString = " Put your hands in mine  ";
            //myString = myString.Substring(1,16);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "-");
            //myString = String.Format("Before Length:{0}\nAfter Length:{1} ", myString.Length, myString.Trim().Length);
            //Console.WriteLine(myString);
            //DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.AddDays(-7).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(12).ToShortTimeString());
            //DateTime myBirthday = new DateTime(2002, 12, 21);
            //Console.WriteLine(myBirthday.ToShortDateString());
            //DateTime myBirthday = DateTime.Parse("12/21/2002");
            /*TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);*/

            /*Car myCar = new Car();

            myCar.Make = "Old Version";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1969;
            myCar.Color = "#000";
            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}");
            //decimal value = DetermineMarketvalue(myCar);
            //Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
*/

            /*Car myCar = new Car();

           *//* myCar.Make = "OldModel";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1969;
            myCar.Color = "#000";*//*

            Car myOtherCar;
            myOtherCar = myCar;
            myOtherCar.Year = 2002;
            Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} {myOtherCar.Year} {myOtherCar.Color}");
            //myOtherCar = null;
            //Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} {myOtherCar.Year} {myOtherCar.Color}");*/
            //Car thirdCar = new Car("Ford", "Escape", 2005, "#fff");
            //Car.myMethod();


            /*string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
                if (i == 9)
                {
                    string l = i.ToString();
                }
                // Console.WriteLine(l);
            }

            Console.WriteLine($"Outside of Loop: {j}");
            Console.WriteLine($"Outside of Loop: {k}");
            HelperMethod();*/
            //ScopeExample.Scope();


            Car myCar = new Car();
            myCar.publicMethod();
            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of K from Helper Method is {0}", k);
        }
        /*private static decimal DetermineMarketvalue (Car car)
        {
            decimal carValue = 10000.0M;

            return carValue;
        }*/
    }
    /*class Car{
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                return carValue = 10000;
            else
                return carValue = 20000;
        }
    }*/
}

