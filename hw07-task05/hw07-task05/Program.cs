namespace hw07_task05
{
    internal class Program
    {
        // a method that return GCD of two numbers
        static public int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.Write("a: ");
            if(!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input for a.");
                return;
            }
            Console.Write("b: ");
            if(!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid input for b.");
                return;
            }
            int gcd = GCD(a, b);
            Console.WriteLine($"GCD of {a} and {b} is {gcd}");
        }
    }
}
