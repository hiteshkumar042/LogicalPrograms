namespace LogicalPrograms
{
    internal class ToBinary
    {
        public static int[] binary = new int[8];
        public static void GetBinary()
        {
            Console.WriteLine("Enter a Decimal Number : ");
            int decNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; decNum > 0; i++)
            {
                binary[i] = decNum % 2;
                decNum /= 2;
                Console.Write(binary[i] + " ");
            }
            for (int i = binary.Length-1; i >= 0; i--)
            {
                Console.Write("\n"+binary[i] + " ");
            }
        }
    }
}
