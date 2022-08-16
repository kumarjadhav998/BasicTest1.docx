using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTest1.docx
{
    class Class1
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter the 1st sub mark");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd sub mark");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd sub mark");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 4th sub mark");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 5th sub mark");
            int E = int.Parse(Console.ReadLine());
            double per = ((A + B + C + D + E) / 5.00) ;
            Console.WriteLine(per);

        }

    }
}
