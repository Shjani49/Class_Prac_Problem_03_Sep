using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stacks are "Last-In, First-Out"
            Stack<string> myStack = new Stack<string>();

            // Push means "add to".
            myStack.Push("First String");
            myStack.Push("Second String");
            myStack.Push("Third String");

            // Pop means "take the next" (return it, and remove it).
            Console.WriteLine(myStack.Pop());

            // Queues are "First-In, First-Out"
            // Enqueue and dequeue mean the same thing as push and pop respectively, except dequeue will remove from the front instead of the end.
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("First String");
            myQueue.Enqueue("Second String");
            myQueue.Enqueue("Third String");

            Console.WriteLine(myQueue.Dequeue());

            // Dictionaries are sort of like lists, except rather than indexed by an integer, they can be indexed by other things.
            string testString = "TechCareers teach code";

            // Create a dictionary indexed by characters (instead of ints like everything else).
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                charCounts.Add(i, 0);
            }

            // For each character in our test string:
            foreach(char character in testString)
            {
                if (charCounts.ContainsKey(char.ToLower(character)))
                {
                    // Increment that character count.
                    charCounts[char.ToLower(character)]++;
                }
                
            }

            // You can index dictionaries by ints as well, if you don't want to start numbering at 0.
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1001, "John Doe");
            students.Add(1002, "Jane Doe");

            Console.WriteLine(students[1002]);

            // Displays the value associated with the key 's'.
            Console.WriteLine(charCounts['s']);


        }
    }
}
