using CSharpOOP.School;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.People
{
    public class Teacher : Person
    {
        public int StaffID { get; set; }

        public List<SchoolClass> ClassesTaught { get; set; }


        public Teacher()
        {
            StaffID = 1000;
            FirstName = "John";
            LastName = "Doe";
            DateOfBirth = DateTime.Now;
            ClassesTaught = new List<SchoolClass>();
        }
    }
}