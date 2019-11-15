using System;
using System.Text.RegularExpressions;

namespace CalculateList
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validate(args))
            {
                int[] arr = Process(args);
                var list = new IntegerList(arr);
                Console.WriteLine(list);
            }

            //Console.WriteLine($"My input: {args[0]}");
            // Here some magic...
            Console.WriteLine("Max number is: ??");
            Console.WriteLine("Min number is: ??");
            Console.WriteLine("Average is: ??");
            Console.WriteLine("Std Deviation is: ??");
            Console.ReadLine();
        }
       
        public static int[] Process(string[] args)
        {
                string list = args[0];
                string[] stringArr = list.Split(',');
                int[] values = Array.ConvertAll(stringArr, int.Parse);
                return values;
        }

        public static bool Validate(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("No parameter. One parameter is required. Example: 1,5,4,12,21");
                return false;
            }
            else if (args.Length > 1)
            {
                Console.WriteLine($"To many parameters. One is required. Example: 1,5,4,12,21");
                return false;
            }
  
            string commaSeparatedList = @"^[0-9]+(,[0-9]+)*$";
            string input = args[0];
            Match m = Regex.Match(input, commaSeparatedList, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                Console.WriteLine("Correct list of values found '{0}' ", m.Value);
                return true;
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            return false;
        }


    }
}
