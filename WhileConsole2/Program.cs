using System;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer N (>1)");
            Console.Write("N = ");
            int N = Int32.Parse(Console.ReadLine());
            while (N <= 1)
            {
                Console.WriteLine("The data entered is incorrect");
                Console.WriteLine("Please, try again");
                Console.Write("\nN = ");
                N = Int32.Parse(Console.ReadLine());
            }
            int k = 1;
            while (Math.Pow(3,k)<=N)
            {
                k++;
            }
            Console.WriteLine($"K is {k}");

        }
    }
}
