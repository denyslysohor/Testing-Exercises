using System;
using System.Collections.Generic;
using System.Linq;
using static ConsoleTestApp.StructTypes;

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
        public static void Main(string[] args)
        {

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
    }
}