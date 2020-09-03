using CSharpOOP.People;
using CSharpOOP.School;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance means that one class can be derived from another, and will inherit that object's properties, methods, etc.
            
            // Polymorphism means that a reference to a base class can have objects of its derived classes (classes that inherit from it) assigned to it.
            
            // Encapsulation means that a class should be responsible for itself. It should not depend on other objects assigning values to it, it should only accept requests for action (IE "Object.Start()" and "Object.Stop()" vs "Object.Running = true". It makes for a more realistic feel for objects in most circumstances.
            
            // Abstraction means that the properties, methods, etc. of an objects that do not require outside usage are hidden from outside view, in order to simplify the object.


            Student myStudent = new Student();
            myStudent.PendingHomework.Push(new Homework() {Complexity = 3});
            Console.WriteLine(myStudent.WritingInstrument);
            myStudent.DoHomework();
            Console.WriteLine(myStudent.WritingInstrument);
        }
        
    }
}
