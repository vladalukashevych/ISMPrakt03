using System;

namespace ForConsole4
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
            while (a! > b)
            {
                Console.WriteLine("The data entered is incorrect");
                Console.WriteLine("Please, try again");
                Console.Write("\na = ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = Int32.Parse(Console.ReadLine());
            }
            double sum = 0;
            for(int i = a; i<=b; i++)
            {
                sum += Math.Pow(i, 2);
            }
            Console.WriteLine($"The sum of squares is {sum}");
        }
    }
}
