using System.Drawing;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs!");
            Console.WriteLine("\n1. Fibonacci Series. \n2. Perfect Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                // Q1. Fibonacci Series
                case 1:
                    FibonacciSeries.GetFibonacciSeries();
                    break;
                //Q2. Perfect Number
                case 2:
                    PerfectNumber.GetPerfectNumber();
                    break;
                // Out of range question
                default:
                    Console.WriteLine("Choose given option only.");
                    break;
            }
        }
    }
}