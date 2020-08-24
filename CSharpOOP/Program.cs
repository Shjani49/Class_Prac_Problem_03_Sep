using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            Console.WriteLine(Console.ReadLine().Trim().Contains(' ') ? "Multiple words." : "One word.");
        }
    }
}
