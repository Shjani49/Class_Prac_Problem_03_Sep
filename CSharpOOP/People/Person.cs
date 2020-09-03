using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.People
{
    public class Person
    {
        // A default property auto-generates the backing variable as a private variable of the same type.
        // The getter and setter are also automatically generated.
        public string FirstName { get; set; }
        // The above auto-generated property can be likened to the following:
        private string _lastName;
        public string LastName
        {
            get // Output of the value.
            {
                // The "getter" is called whenever the user tries to use the property.
                // Example: writing it out, assigning another variable to it, etc.
                // (string myVar = student.LastName)
                // Do any formatting of values here.
                return _lastName;

            }
            set // Input to the value.
            {
                // The "setter" is called whenever the user tries to assign the property.
                // 'value' is a keyword that represents what the user is trying to assign thereto.
                // Do any validation of values here.
                _lastName = value;

            }
        }

        // Private properties can only be set in this class.
        public DateTime DateOfBirth { get; set; }
    }
}
