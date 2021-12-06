using ComparingContainer;
using FuncDifference;
using LocalMachineIO;
using PartialClasses;
using StringExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using static FuncDifference.FuncDif;
using static StructNamespace.StructTypes;

namespace ConsoleTestApp 
{
    public class Program
    {
        public static (string, string, int) QueryCityData(string progLang)
        {
            if (progLang == "C#")
                return (progLang, "Microsoft", 2001);

            return ("", "", 0);
        }

        // Action delegate

        static void Operation(int x1, int x2, Action<int, int> op)
        {
            if (x1 != x2)
                op(x1, x2);
        }

        static void Add(int x1, int x2)
        {
            Console.WriteLine("Сумма чисел: " + (x1 + x2));
        }

        static void Substract(int x1, int x2)
        {
            Console.WriteLine("Разность чисел: " + (x1 - x2));
        }

        static void Multiply(int x1, int x2)
        {
            Console.WriteLine("Произведение чисел: " + (x1 * x2));
        }

        public static void Main(string[] args)
        {
            // IComparable, IComparer challenge

            Laptop laptop1 = new("Microsoft", 4, 1800);
            Laptop laptop2 = new("Apple", 2, 1400);

            LaptopComparer comparer = new LaptopComparer();

            Console.WriteLine(laptop1.CompareTo(laptop2));
            Console.WriteLine(comparer.Compare(laptop1, laptop2));


            // Challenge PARTIAL Classes

            SubSystem subSystem = new("Sub1", 40);
            SubSystem subSystem1 = new("John Connor");
            subSystem.DisplayInfo();

            // Searching in strings

            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition + 1, length - 1));
            Console.WriteLine();

            string message1 = "This--is--ex-amp-le--da-ta";
            message1 = message1.Replace("--", " ");
            message1 = message1.Replace("-", "");
            Console.WriteLine(message1);
            Console.WriteLine();

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            string spanTagOpen = "<span>";
            string spanTagClose = "</span>";

            int quantityStart = input.IndexOf(spanTagOpen);
            int quantityEnd = input.IndexOf(spanTagClose);

            quantityStart += spanTagOpen.Length;
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);

            output = input.Replace("&trade;", "&reg;");

            int divStart = input.IndexOf("<div");
            int divEnd = input.IndexOf(">");
            int divLength = divEnd - divStart;
            divLength += 1;
            output = output.Remove(divStart, divLength);

            int divCloseStart = output.IndexOf("</div");
            int divCloseEnd = output.IndexOf(">", divCloseStart);
            int divCloseLength = divCloseEnd - divCloseStart;
            divCloseLength += 1;
            output = output.Remove(divCloseStart, divCloseLength);

            Console.WriteLine(quantity);
            Console.WriteLine(output);

            // Challenge of data formatting, from MS Learn
            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 23123;
            decimal currentReturn = 0.12322m;
            decimal currentProfit = 123000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);

            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";

            comparisonMessage += newProduct.PadRight(20);

            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);

            // Challenge of using action delegate
            Action<int, int> op;
            op = Add;
            Operation(10, 6, op);
            op = Substract;
            Operation(10, 6, op);
            op = Multiply;
            Operation(8, 10, op);
            Operation(8, 8, op);

            // The instance of base String Formatting

            Console.WriteLine();
            string firstString = "Hello";
            string secondString = "World";
            string resultString = string.Format("{0} {1}!", firstString, secondString);
            Console.WriteLine(resultString);

            // OR

            Console.WriteLine("{0} {1}!", firstString, secondString);

            // Using interpolation

            Console.WriteLine($"{firstString} {secondString}!");


            // Currency formatting

            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            // ':C' - means the currency token of the country. USA - $, etc.


            // Percentages formatting

            decimal tax = .2298767m;
            Console.WriteLine($"Tax rate: {tax:P2}"); // Output: 22,99%


            // Small Challenge of FORMATTING

            Console.WriteLine();
            int invoiceNumber = 1201;
            decimal productMeasurement = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"\tMeasurement: {productMeasurement:N3} mg");
            Console.WriteLine($"\t\tSub Total: {subtotal:C}");
            Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");
            Console.WriteLine($"\t\t\t\tTotal Due: {total:C}");


            // The common and anonymous methods

            Console.WriteLine();
            double result1 = MultipleFunc(4, 5);

            Console.WriteLine($"{result1}");

            MultipleDelegate multipleDelegate = new(FuncDif.Multiple);
            double result2 = multipleDelegate.Invoke(7, 5);
            Console.WriteLine(result2);


            // Local Machine Parameters

            LocalMachine machine = new LocalMachine();
            machine.GetMachineParameters();


            // Tuple Pattern Matching

            static string TupleMatch(string helloPhrase, string lang) =>
                (helloPhrase, lang) switch
                {
                    ("Login", "Password") => "This is secret command!",
                    (_, "C#") => "Console.WriteLine(\"Hello World\");",
                    (_, "C") => "printf(\"Hello World!\");",
                    (_, "Java") => "System.out.println(\"Hello World!\");",
                    (_, "C++") => "std::cout << \"Hello World!\";",
                    (_, _) => "I don`t know how to interpret it",
                };
            Console.WriteLine();
            Console.WriteLine(TupleMatch("", "C#"));
            Console.WriteLine(TupleMatch("", "C++"));
            Console.WriteLine(TupleMatch("", ""));
            Console.WriteLine(TupleMatch("", "Java"));
            Console.WriteLine(TupleMatch("Login", "Password"));
            Console.WriteLine();


            // Tuple Deconstruct

            var result = QueryCityData("C#");

            var language = result.Item1;
            var company = result.Item2;
            var year = result.Item3;

            Console.WriteLine(result);


            // IO namespace some tests:

            IO_testing iO = new IO_testing();
            iO.path = @"C://TestDirectory";
            try
            {
                var allFiles = Directory.EnumerateFiles(iO.path);
                foreach (var file in allFiles)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine($"  Root directory: {d.RootDirectory}");
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} bytes ",
                        d.TotalSize);
                }
            }



            var p1 = new Point(0, 0);
            Console.WriteLine(p1);  // output: (0, 0)

            var p2 = p1 with { X = 3 };
            Console.WriteLine(p2);  // output: (3, 0)

            var p3 = p1 with { X = 1, Y = 4 };
            Console.WriteLine(p3);  // output: (1, 4)

            var p4 = p2 with { X = 12, Y = -4 };
            Console.WriteLine(p4);

            Console.WriteLine();

            // Span advantages

            int[] Years = { 1990, 1991, 1992, 1993, 2002, 2010, 2013, 2016, 2020 };

            int[] yearsBefore2002 = new int[4];
            int[] yearsAfter2002 = new int[4];

            Array.ConstrainedCopy(Years, 0, yearsBefore2002, 0, 4);
            Array.ConstrainedCopy(Years, 5, yearsAfter2002, 0, 4);

            for (int i = 0; i < yearsBefore2002.Length; i++)
            {
                Console.WriteLine(yearsBefore2002[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < yearsAfter2002.Length; i++)
            {
                Console.WriteLine(yearsAfter2002[i]);
            }
            Console.WriteLine();
            Span<int> span = Years;
            var span1 = span.Slice(0, 4);
            for (int i = 0; i < span1.Length; i++)
            {
                Console.WriteLine(span1[i]);
            }
            var span2 = span.Slice(5, 4);
            for (int i = 0; i < span2.Length; i++)
            {
                Console.WriteLine(span2[i]);
            }
            Console.WriteLine();


            string stringContent = "0123456789";
            int charCount = stringContent.ToCharacterCount();
            Console.WriteLine();
            Console.WriteLine($"Total count of characters: {charCount}");







































































            Console.ReadKey();
        }

        private static double MultipleFunc(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}