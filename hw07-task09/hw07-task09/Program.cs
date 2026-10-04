namespace hw07_task09
{
    internal class Program
    {
        // a method that takes an array, check does any duplicate values exist in the array? 
        static public bool CheckDuplicate(int[] arr)
        {
            HashSet<int> set = new HashSet<int>(); // avoid duplicates
            foreach (int num in arr)
            {
                if (set.Contains(num))
                {
                    return true; // Duplicate found
                }
                set.Add(num);
            }
            return false; // No duplicates
        }

        static void Main(string[] args)
        {
            // test method
            Console.Write("array length: ");
            if(!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Duplicate found: " + CheckDuplicate(arr));
        }
    }
}
