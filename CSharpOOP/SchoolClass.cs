using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class SchoolClass
    {
        /*
         Create Properties for:
         -Class Code
         -Class Name
         -Maximum Students (private)
        */
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        private int MaxStudents { get; set; }

        public Teacher ClassTeacher { get; set; }

        public SchoolClass()
        {
            ClassCode = "CLASS101";
            ClassName = "Introduction to School Stuff";
            MaxStudents = 10;
            ClassTeacher = new Teacher();
        }
    }
}
