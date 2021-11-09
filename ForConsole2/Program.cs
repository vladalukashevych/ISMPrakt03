using System;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N: ");
            int N = Int32.Parse(Console.ReadLine());
            while (N<=0)
            {
                Console.WriteLine("The data entered is incorrect");
                Console.WriteLine("Please, try again");
                Console.Write("\nN = ");
                N = Int32.Parse(Console.ReadLine());
            }
            double sum = 0;
            for (int i = 1; i<=N; i++)
            {
                sum += (1.0 / i);
            }
            Console.WriteLine($"The summary is {sum}");
        }
    }
}
