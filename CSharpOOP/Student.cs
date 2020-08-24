using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Student
    {
        // Public properties can be set externally.
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Private properties can only be set in this class.
        private DateTime DateOfBirth { get; set; }


        public Student()
        {
            DateOfBirth = DateTime.Now;
        }



    }
}
