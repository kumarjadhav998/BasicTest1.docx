using System;

namespace BasicTest1.docx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side of trangle");
            int A = int.Parse(Console.ReadLine());
            double Area = 0.433 * (A * A);
                Console.WriteLine(Area);

        }
    }
}
