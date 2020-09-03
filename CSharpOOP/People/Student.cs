using CSharpOOP.School;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.People
{
    public class Student : Person
    {
        // Public properties can be set externally.
        public int StudentID { get; set; }

        public Stack<Homework> PendingHomework { get; set; }

        public WritingInstrument WritingInstrument { get; set; }

        // We have to specify the backing variable for EnergyLevel because we are doing some validation with the value. 
        private int _energyLevel;
        private int EnergyLevel { 
            get
            {
                return _energyLevel;
            } 
            set
            {
                // If the incoming value is over 125, clamp it to 125.
                if (value > 125)
                {
                    _energyLevel = 125;
                }
                else
                {
                    if (value < 0)
                    {
                        throw new Exception("Not enough energy to do that task!");
                    }
                    _energyLevel = value;
                }
            }
        }

        // We have to specify the backing variable for EnergyLevel because we are doing some validation with the value. 
        private int _stressLevel;
        private int StressLevel
        {
            get
            {
                return _stressLevel;
            }
            set
            {
                // If the incoming value is under 0, set it to 0
                if (value < 0)
                {
                    _stressLevel = 0;
                }
                else
                {
                    if (value > 100)
                    {
                        throw new Exception("Too stressed, can't do that task!");
                    }
                    _stressLevel = value;
                }
            }
        }



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
            StressLevel = 0;
            WritingInstrument = new Pen();
            PendingHomework = new Stack<Homework>();
        }
        // A "partial" constructor takes some of the properties as arguments, and defaults the rest.
        public Student(string firstName, string lastName)
        {
            StudentID = 1000;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = DateTime.Now;
            EnergyLevel = 100;
            StressLevel = 0;
            WritingInstrument = new Pen();
            PendingHomework = new Stack<Homework>();
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
            StressLevel = 0;
            WritingInstrument = new Pen();
            PendingHomework = new Stack<Homework>();
        }

        // Additional methods can be defined on a class, and will operate on the instance of the object.
        public void PlayGames()
        {
            EnergyLevel -= 15;
            StressLevel -= 25;
        }

        public void DoHomework()
        {
            // Save the values before we try the homework.
            int tempEnergy = EnergyLevel, tempStress = StressLevel;

            try
            {
                // Try to set the properties to the new ones.
                // If we pop first, then we will be missing the item if anything fails.
                // If we pop in each step, we'll be getting a new item each time.
                // So we peek, which shows the top item, without removing it. Kind of like flipping the top card on a deck.
                EnergyLevel -= 10*PendingHomework.Peek().Complexity;
                StressLevel += 5*PendingHomework.Peek().Complexity;
                WritingInstrument.Write(100*PendingHomework.Peek().Complexity);
                // Once we're sure everything is good, we pop the top item off.
                PendingHomework.Pop();
            }
            catch (Exception ex)
            {
                // If either one fails, rollback both.
                EnergyLevel = tempEnergy;
                StressLevel = tempStress;
                // Throw the exception up the stack to main.
                throw ex;
            }
        }

        public void Sleep()
        {
            EnergyLevel = 100;
            StressLevel -= 50;
        }

        public void Sleep(int hours)
        {
            EnergyLevel += hours * 10;
            StressLevel -= hours * 5;
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

        public string QueryStressLevel()
        {
            string output;
            if (StressLevel > 90)
            {
                output = "I'm super stressed!";
            }
            else if (StressLevel > 60)
            {
                output = "Getting pretty stressed, need a break soon.";
            }
            else if (StressLevel > 30)
            {
                output = "Not too stressed.";
            }
            else if (StressLevel > 10)
            {
                output = "Barely stressed at all.";
            }
            else
            {
                output = "I am zen. I am one with the universe.";
            }
            return output;
        }

    }
}
