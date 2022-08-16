using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTest1.docx
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("divisible number");
            }
            else
            {
                Console.WriteLine("not divisible number");
            }
        }
    }
}

