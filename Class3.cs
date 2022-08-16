using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTest1.docx
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            if (year%4==0)
            {
                Console.WriteLine(year + "year is a leap year");
            }
            else
            {
                Console.WriteLine(year + "year is not a leap year");
            }
        }
    }
}
