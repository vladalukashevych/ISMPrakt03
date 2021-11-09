using System;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers (a<b) ");
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            while (a!>b)
            {
                Console.WriteLine("The data entered is incorrect");
                Console.WriteLine("Please, try again");
                Console.Write("\na = ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = Int32.Parse(Console.ReadLine());
            }
            long prod = 1;
            for(int i = a; i<=b; a++)
            {
                prod *= a;
            }
            Console.WriteLine($"The product is {prod}");
        }
    }
}
