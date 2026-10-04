namespace hw07_task07
{
    internal class Program
    {
        // a method that get an integer and return the binary
        static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";
            string binary = "";
            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary; // get the remainder and add it to the binary string
                decimalNumber /= 2; // get the quotient for the next iteration
            }
            return binary;
        }
        static void Main(string[] args)
        {
            Console.Write("number: ");
            if (!int.TryParse(Console.ReadLine(), out int decimalNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }
            Console.WriteLine("Binary: " + DecimalToBinary(decimalNumber));
        }
    }
}
