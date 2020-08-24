﻿using System;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify the student class to have a property for energy level.
            // The energy level should not be accessible from outside the student.
            // Create methods in the student that are accessible, for do homework and sleep.
            // Do homework will lower the student's energy level by 25. Sleep will set the energy level to 100.
            // When a student is created, ensure their energy level starts at 100.

            // Overload the sleep method to allow a value of hours. Increase energy by 10 per hour slept.
            // Add a ceiling of 100 to sleep.

            // Task:
            // Add a play games method that will decrease energy by 15.

            /* Group Task:
             
            Add an inaccessible stress level variable, initialized at 0. 
	            -When homework is done, increase stress by 30. 
	            -When sleep is done, decrease stress by 50 (or 5 per hour).
	            -When games are done, decrease stress by 25.
	            -Add a floor to stress level of 0 (similar to ceiling on energy).

            Add a query method for stress level and that will output a string based on its level.

            Throw an exception if stress tries to go over 100.



            */

            Student myStudent = new Student();
            Student twoStudent = new Student("Bob", "Jones");
            myStudent.FirstName = "Jane";

            Console.WriteLine(myStudent.StudentID + ": "+myStudent.FirstName + " " + myStudent.LastName);

            Console.WriteLine(twoStudent.StudentID + ": " + twoStudent.FirstName + " " + twoStudent.LastName);

            Console.WriteLine(myStudent.QueryEnergyLevel());
        }
    }
}
