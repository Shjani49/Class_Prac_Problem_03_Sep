using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Student
    {
        // Public properties can be set externally.
        public int StudentID { get; set; }

        // A default property auto-generates the backing variable as a private variable of the same type.
        // The getter and setter are also automatically generated.
        public string FirstName { get; set; }
        // The above auto-generated property can be likened to the following:
        private string _lastName;
        public string LastName { 
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

        // We have to specify the backing variable for EnergyLevel because we are doing some validation with the value. 
        private int _energyLevel;
        private int EnergyLevel { 
            get
            {
                return _energyLevel;
            } 
            set
            {
                // If the incoming value is over 100, clamp it to 100.
                if (value > 125)
                {
                    _energyLevel = 125;
                }
                else
                {
                    _energyLevel = value;
                }
            }
        }

        // Private properties can only be set in this class.
        private DateTime DateOfBirth { get; set; }

        // Constructor name must be the same as the class name.
        // Constructors are used to create an instance of a class.
        // The class is the schematic and the object is the instance.

        // A "default" constructor takes no parameters. 
        // If no constructor is declared, C# will generate one that populates properties with their default values. The same is true if any properties go undeclared by the end of the constructor.
        public Student()
        {
            StudentID = 1000;
            FirstName = "John";
            LastName = "Doe";
            DateOfBirth = DateTime.Now;
            EnergyLevel = 100;
        }
        // A "partial" constructor takes some of the properties as arguments, and defaults the rest.
        public Student(string firstName, string lastName)
        {
            StudentID = 1000;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = DateTime.Now;
            EnergyLevel = 100;
        }
        // A "greedy" constructor takes all of the properties as arguments.
        // Depending on your implementation you may or may not allow private properties to be set via parameter. In this example we will not.
        public Student(int studentID, string firstName, string lastName)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = DateTime.Now;
            EnergyLevel = 100;
        }

        // Additional methods can be defined on a class, and will operate on the instance of the object.
        public void PlayGames()
        {
            EnergyLevel -= 15;
        }

        public void DoHomework()
        {
            if (EnergyLevel < 25)
            {
                throw new Exception("Not enough energy to do homework!");
            }
            else
            {
                EnergyLevel -= 25;
                // Same as EnergyLevel = EnergyLevel - 25;
            }
        }

        public void Sleep()
        {
            EnergyLevel = 100;
        }

        public void Sleep(int hours)
        {
            EnergyLevel += hours * 10;
        }

        public string QueryEnergyLevel()
        {
            string output;
            if (EnergyLevel > 100)
            {
                output = "I'm super well rested and have tons of energy!";
            }
            else if (EnergyLevel > 75)
            {
                output = "Doing pretty well.";
            }
            else if (EnergyLevel > 40)
            {
                output = "Starting to get a bit tired.";
            }
            else if (EnergyLevel > 10)
            {
                output = "Pretty tired. Need rest soon.";
            }
            else
            {
                output = "Basically a zombie here, why aren't I asleep?";
            }

            return output;
        }

    }
}
