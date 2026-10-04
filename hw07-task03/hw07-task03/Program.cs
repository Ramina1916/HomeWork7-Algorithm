namespace hw07_task03
{
    internal class Program
    {
        // a method that returns the sum of number digits of a given number
        static int SumOfDigits(int number)
        {
            number = Math.Abs(number); // Handle negative numbers
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("number: ");
            if(!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }
            Console.WriteLine($"The sum of digits of {number} is {SumOfDigits(number)}.");
        }
    }
}
