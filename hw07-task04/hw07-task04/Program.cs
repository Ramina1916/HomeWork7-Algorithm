namespace hw07_task04
{
    internal class Program
    {
        // A method that checks if a number is palindrome
        static public bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                number /= 10;
            }
            return originalNumber == reversedNumber;
        }
        static void Main(string[] args)
        {

            int[] array =
            {
                121,
                12321,
                123,
                10,
                0,
                -121
            };

            foreach (int number in array)
            {
                Console.WriteLine($"Is {number} a palindrome => {IsPalindrome(number)}");
            }
        }
    }

}
