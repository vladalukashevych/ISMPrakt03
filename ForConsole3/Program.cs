using System;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers ( A - fractional, N - natural) ");
            Console.Write("A = ");
           double A = Double.Parse(Console.ReadLine());
            Console.Write("N = ");
            int N = Int32.Parse(Console.ReadLine());
            while (N % 1 != 0 || A % 1 == 0)
            {
                Console.WriteLine("The data entered is incorrect");
                Console.WriteLine("Please, try again");
                Console.Write("A = ");
                A = Double.Parse(Console.ReadLine());
                Console.Write("N = ");
                N = Int32.Parse(Console.ReadLine());
            }
            double pow = 1;
            for (int i = 1; i<=N; i++)
            {
                pow *= A; 
            }
            Console.WriteLine($"A^N = {pow}");
        }
    }
}
