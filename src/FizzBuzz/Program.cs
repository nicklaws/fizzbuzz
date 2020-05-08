using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {     
            double count = 15;// default value

            if (args.Length > 0)
            {
                count = ParseArgs(args);
            }
            FizzyCheck(count);

            
            
        }

        private static double ParseArgs(string[] argList)
        {
            double count = 0;

            if(argList.Length > 0 && argList.Length != 1)
            {
                Console.WriteLine($"You have {argList.Length-1} too many argument(s)");
                Console.WriteLine("Please rerun with either 0 or 1 argument");
                Environment.Exit(1);
            }
            else if (argList.Length == 1)
            {
                try
                {
                    count = double.Parse(argList[0]);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);         
                    Environment.Exit(1);     
                }
            }
            return count;
        }
        private static void FizzyCheck(double count)
        {
            for (double i = 1; i <= count; i += 1)
            {
                bool newLine = false;
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    newLine = true;
                }
                if (i %5 == 0)
                {
                    Console.Write("Buzz");
                    newLine = true;
                }                
                if (newLine)
                {
                    Console.Write(Environment.NewLine);
                }    

            }
        }
    }
}
