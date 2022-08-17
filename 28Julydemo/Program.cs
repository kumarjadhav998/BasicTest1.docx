using System;

namespace _28Julydemo
{
    class Program
    {
        static void Main(string[] args)

        {
            division d1 = new division();

            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());
            
            if (year % 4 == 0)
            Console.WriteLine(year + "is a leap year");
            else
            Console.WriteLine(year + " is not a leap year");
            
        }
    }
}
