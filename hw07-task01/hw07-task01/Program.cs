namespace hw07_task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");

            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (number == 0)
            {
                Console.WriteLine(1);
                return;
            }

            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }

            Console.WriteLine($"Number of digits: {count}");
        }
    }
}
