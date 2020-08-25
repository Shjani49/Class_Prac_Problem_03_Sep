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

        
        private List<SchoolClass> _classesTaught;
        public List<SchoolClass> ClassesTaught
        {
            get
            {
                return _classesTaught;
            }

            set 
            {
                // TODO: Fix the logic so that this triggers when Add(), Remove() etc are called on the list.

                // '_classesTaught' is going to be the old list.
                // 'value' is going to be the new list (NOT the one class that gets added).
                // 'this' is going to be the current teacher.

                if (_classesTaught == null)
                {
                    _classesTaught = new List<SchoolClass>();
                }
                // For each class in the old class list, if it's not in the new class list, null out the teacher (class was removed from teacher's roster).
                foreach (SchoolClass classTaught in _classesTaught)
                {
                    if(!value.Contains(classTaught))
                    {
                        classTaught.ClassTeacher = null;
                    }
                }
                // For each class in the new class list, if the teacher is not this teacher, set it to this teacher.
                foreach (SchoolClass classTaught in value)
                {
                    if (classTaught.ClassTeacher != this)
                    {
                        classTaught.ClassTeacher = this;
                    }
                }
                _classesTaught = value;
            }
           
        }

        public static void Test()
        {
            Console.WriteLine("Teachers are responsible for instructing students in classes.");
        }

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
