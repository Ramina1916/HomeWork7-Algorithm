namespace hw07_task06
{
    internal class Program
    {
        // a method to reverse a number, without converting to the string
        static public int Reverse(int number)
        {
            bool negative = number < 0;
            long temp = Math.Abs((long)number);
            long reversed = 0;

            while (temp > 0)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
            }

            if (negative) reversed = -reversed;

            if (reversed > int.MaxValue || reversed < int.MinValue) return 0;

            return (int)reversed;
        }
        // a method to reverse a number, with converting to the string
        static public int ReverseString(int number)
        {
            bool negative = number < 0;
            string str = Math.Abs(number).ToString();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            int reversed = int.Parse(reversedStr);
            if (negative) reversed = -reversed;
            return reversed;
        }
        static void Main(string[] args)
        {

            Console.Write("Number: ");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            int result = Reverse(number);
            Console.WriteLine($"Reversed number: {result}");
        }
    }
}
