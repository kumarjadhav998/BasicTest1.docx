using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTest1.docx
{
    class Class5
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the three number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a>b && a > c)
            {
                Console.WriteLine(a + "is max number");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine(b + "is max number");
            }
            else
            {
                Console.WriteLine(c + "is max number");
            }
        }
    }
}
