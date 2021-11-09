using System;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter numbers to count");
			Console.WriteLine("Enter 0 to end the row\n");
			int sum = 0, n;
			do
			{
				Console.Write("\t");
				n = Int32.Parse(Console.ReadLine());
				sum += n;

			} while (n != 0);

			Console.WriteLine($"\nThe sum of the numbers above is {sum}");

		}
	}
}
