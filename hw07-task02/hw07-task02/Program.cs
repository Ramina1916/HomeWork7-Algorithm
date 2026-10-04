namespace hw07_task02
{
    internal class Program
    {
        static public bool IsPrime(int n) // a method to check if a number (both positive and negative) is prime
        {
            n = Math.Abs(n);
            if (n < 2) return false; // o and 1 are not prime numbers
            if (n % 2 == 0) return n == 2; // even numbers greater than 2 are not prime
            double limit = Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2) // check only odd numbers starting from 3
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Number: ");

            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.WriteLine(IsPrime(n) ? "The number is prime."  : "The number is not prime.");
        }
    }
}
