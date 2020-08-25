using System;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolClass theClass = new SchoolClass();
            Teacher theTeacher = theClass.ClassTeacher;
            theTeacher.FirstName = "Jane";



            Console.WriteLine($"The class has the classcode {theClass.ClassCode}, is called {theClass.ClassName} and is being taught by {theClass.ClassTeacher.FirstName} {theClass.ClassTeacher.LastName}.");

            Console.WriteLine(theClass.ClassTeacher == theTeacher);
            

        }
    }
}
