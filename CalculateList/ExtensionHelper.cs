using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CalculateList
{
    public static class ExtensionHelper
    {
        //Validation helper
        public static bool Validate(this string[] args)
        {
            //Is there a parameter at all?
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("No parameter. One parameter is required. Example: 1,5,4,12,21");
                return false;
            }
            //Is there only one parameter?
            else if (args.Length > 1)
            {
                Console.WriteLine($"Your input {args.ArrToString()} contains {args.Length} parameters.\n" +
                    $"One is required. Example: 1,5,4,12,21\n" +
                    $"Make sure no spaces in the input.");
                return false;
            }
            //Does the parameter match the pattern for a comma separated list of numbers?
            string commaSeparatedList = @"^-?[0-9]+(,-?[0-9]+)*$";
            string input = args[0];
            Match m = Regex.Match(input, commaSeparatedList, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                //Console.WriteLine("Correct list of values found '{0}' ", m.Value);
                return true;
            }
            else
            {
                Console.WriteLine($"You have entered {input}\nMake sure to provide comma separated list of integers. Example: 1,5,4,12,21");
            }

            //All other cases
            return false;
        }

        public static int[] TryParseFirst(this string[] args)
        { 
            //Converting comma separated string of intergers into array
            try
            {
                string list = args[0];
                string[] stringArr = list.Split(',');
                int[] values = Array.ConvertAll(stringArr, i => int.Parse(i, CultureInfo.InvariantCulture));
                return values;
            }
            catch
            {
                Console.WriteLine("Error in converting text list to integer array.");
            };

            return new int[] { };
        }
        public static string ArrToString(this string[] list)
        {
            return string.Join(" ", list);
        }

    }
}
