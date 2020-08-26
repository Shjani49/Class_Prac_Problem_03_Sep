using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            Console.WriteLine(myStudent.WritingInstrument);
            myStudent.DoHomework();
            Console.WriteLine(myStudent.WritingInstrument);
        }
        
    }
}
