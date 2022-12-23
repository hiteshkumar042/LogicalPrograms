namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void GetPrimeNumber()
        {
            int isPrime = 1; //iterator si prime
            Console.WriteLine("Enter a number to check Prime : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = 0;
                }
            }
            if (isPrime == 1)
            {
                Console.WriteLine("It's a prime Number");
            }
            else
            {
                Console.WriteLine("Its a not a prime Number");
            }
        }
    }
}
