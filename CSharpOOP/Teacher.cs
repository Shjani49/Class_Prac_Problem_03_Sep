using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Teacher
    {
        /*
         Create Properties for:
         -First Name
         -Last Name
         -Staff ID
         -Date of Birth (private)
        */
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime DateOfBirth { get; set; }

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
