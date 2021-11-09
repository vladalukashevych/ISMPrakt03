using System;

namespace WhileConsole1
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
            int i = 1, j = N;
            double sum = 0;
            while (i<=N)
            {
                sum += Math.Pow(i, j);
                i++;
                j--;
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
