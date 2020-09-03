using CSharpOOP.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.School
{
    public class SchoolClass
    {
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        private int MaxStudents { get; set; }
        public Teacher ClassTeacher { get; set; }


        public SchoolClass()
        {
            ClassCode = "CLASS101";
            ClassName = "Introduction to School Stuff";
            MaxStudents = 10;
        }

        public SchoolClass(string classCode, string className)
        {
            ClassCode = classCode;
            ClassName = className;
            MaxStudents = 10;
        }
    }
}