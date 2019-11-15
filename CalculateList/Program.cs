using System;


namespace CalculateList
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Validate())
            {
                int[] values = args.TryParseFirst();
                if (values.Length > 0)
                {
                    Console.WriteLine($"You have entered {args[0]}");
                    var list = new IntegerList(values);
                    Console.WriteLine($"Calculate statistics for {list.GetArrayString}");
                    Console.WriteLine(list);
                }
                
            }
            
            Console.ReadLine();
        }
    }
}
