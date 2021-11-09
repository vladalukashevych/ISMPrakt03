using System;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer N (>0)");
            Console.Write("N = ");
            int N = Int32.Parse(Console.ReadLine());
            while (N <= 0)
            {
                Console.WriteLine("The data entered is incorrect");
                Console.WriteLine("Please, try again");
                Console.Write("\nN = ");
                N = Int32.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 1; i<=N; i++)
            {
                int factorial = 1;
                for (int j = 1; j<=i; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            Console.WriteLine($"The sum is {sum}");
        } 
    }
}
