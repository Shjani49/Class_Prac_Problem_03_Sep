using System;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assigning properties with individual statements.
            SchoolClass historyClass = new SchoolClass();
            historyClass.ClassCode = "HIST101";
            historyClass.ClassName = "Introduction to History";

            // Rather than assigning props as multiple statements, you can assign them during construction using an initializer list.
            SchoolClass englishClass = new SchoolClass()
            {
                ClassCode = "ENGL101",
                ClassName = "Introduction to English"
            };

            // Using a constructor.
            SchoolClass programmingClass = new SchoolClass("CPRG101", "Introduction to Programming");

            Teacher sueTeacher = new Teacher()
            {
                StaffID = 2050,
                FirstName = "Sue",
                LastName = "Smith"
            };
            Teacher joeTeacher = new Teacher()
            {
                StaffID = 2050,
                FirstName = "Joe",
                LastName = "Testificate"
            };

            // For this test run:
            // Old teacher will be NULL
            // New teacher will be Sue
            // "this" will be History class
            historyClass.ClassTeacher = sueTeacher;

            // For this test run:
            // Old teacher will be Sue
            // New teacher will be Joe
            // "this" will be History class
            historyClass.ClassTeacher = joeTeacher;


            englishClass.ClassTeacher = joeTeacher;
            programmingClass.ClassTeacher = joeTeacher;


            Console.WriteLine($"The class has the classcode {historyClass.ClassCode}, is called {historyClass.ClassName} and is being taught by {historyClass.ClassTeacher.FirstName} {historyClass.ClassTeacher.LastName}.");

            

        }
    }
}
