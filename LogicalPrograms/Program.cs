namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs!");
            Console.WriteLine("\n1. Fibonacci Series. \n2. Perfect Number. \n3. Prime Number. \n4. Reverse Number\n");
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
                //Q3. Prime Number
                case 3:
                    PrimeNumber.GetPrimeNumber();
                    break;
                //Q4. Reverse Number
                case 4:
                    ReverseNumber.GetReverseNumber();
                    break;
                // Out of range question
                default:
                    Console.WriteLine("Choose given option only.");
                    break;
            }
        }
    }
}