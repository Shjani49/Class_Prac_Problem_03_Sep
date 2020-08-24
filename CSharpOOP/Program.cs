using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string output;
            int value = 12;

            /*
            if (value % 2 == 0)
            {
                output = "even";
            }
            else
            {
                output = "odd";
            }
            */

            /* target = condition ? ifTrue : ifFalse; */
            output = value % 2 == 0 ? "even" : "odd";

            Console.WriteLine(output);
        }
    }
}
