using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, output;
            // In-Class Practice Round 2:

            // Try to do it without any variables at all (remove the line above these comments).
            // Two lines (prompt and output).

            Console.Write("Please enter a string: ");
            input = Console.ReadLine();

            output = input.Trim().Contains(' ') ? "Multiple words." : "One word.";

            Console.WriteLine(output);
        }
    }
}
