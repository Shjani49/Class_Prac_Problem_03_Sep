using System;
using System.Collections.Generic;
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

            List<SchoolClass> temp = new List<SchoolClass>();
            temp.AddRange(joeTeacher.ClassesTaught.ToArray());
            temp.Add(historyClass);
            joeTeacher.ClassesTaught = temp;


            Console.WriteLine($"The class has the classcode {historyClass.ClassCode}, is called {historyClass.ClassName} and is being taught by {historyClass.ClassTeacher.FirstName} {historyClass.ClassTeacher.LastName}.");

            

        }
    }
}
