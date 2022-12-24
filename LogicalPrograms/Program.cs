namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs!");
            Console.WriteLine("\n01. Fibonacci Series. \n02. Perfect Number. \n03. Prime Number. \n04. Reverse Number. \n05. Coupon Numbers. \n06. StopWatch.");
            Console.WriteLine("07. Vending Machine.\n08. Day of Week.\n09. Temperature Conversion.\n10. Montly Payment.");
            Console.WriteLine("11. Square Root. \n12. Decimal to Binary.\n13. Swap Nibble\n");
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
                //Q5. Coupon Numbers 
                case 5:
                    CouponNumbers.GetCouponNumbers();
                    break;
                //Q6. Stop Watch
                case 6:
                    StopWatchCls.GetStopWatch();
                    break;
                //Q7. Vending Machine
                case 7:
                    VendingMachine.VendingMachineFn();
                    break;
                //Q8. Day of Week
                case 8:
                    DayOfWeek.DayOfWeekFn();
                    break;
                //Q9. temprature Conversion
                case 9:
                    TemperatureConversion.GetTempConvert();
                    break;
                //Q 10. Monthly Payment
                case 10:
                    MonthlyPayment.GetMonthlyPayment();
                    break;
                //Q 11. Square Root
                case 11:
                    SquareRoot.GetSquareRoot();
                    break;
                //Q 12. Binary to Decimal
                case 12:
                    ToBinary.GetBinary();
                    break;
                //Q 13. Swap Nibble and Result
                case 13:
                    SwapNibble.GetSwapNibble();
                    break;
                // Out of range question
                default:
                    Console.WriteLine("Choose given option only.");
                    break;
            }
        }
        
    }
}