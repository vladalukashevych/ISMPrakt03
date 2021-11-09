using System;

namespace WhileConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value in percents");
            Console.Write("P = ");
            float P = float.Parse(Console.ReadLine());
            P /= 100;
            float S = 10;
            int days = 1;
            float sum = 10;
            while (sum<=200)
            {
                days++;
                S *= (1 + P);
                sum += S;             
            }
            Console.WriteLine($"Sportsman spent {days} days running and riched a mark of {sum} km"); 
        }
    }
}
