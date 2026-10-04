namespace hw07_task08
{
    internal class Program
    {
        // a method that get a string and return all the possible permutations of the string
        static List<string> GetPermutations(string str)
        {
            List<string> permutations = new();

            if (str.Length <= 1) // if the string is empty or has only one character, return the string itself as the only permutation
            {
                permutations.Add(str);
                return permutations;
            }

            HashSet<char> used = new(); // hashset to track used characters, allows to avoid duplicates

            for (int i = 0; i < str.Length; i++)
            {
                char current = str[i];

                // Skip duplicate characters
                if (!used.Add(current))
                    continue;

                string remaining =str.Substring(0, i) + str.Substring(i + 1); // get the remaining characters after removing the current character

                foreach (string perm in GetPermutations(remaining)) // recursively get the permutations of the remaining characters
                {
                    permutations.Add(current + perm);
                }
            }

            return permutations;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine(string.Join(", ", GetPermutations(input)));
        }
    }
}
