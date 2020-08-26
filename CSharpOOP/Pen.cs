using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Pen
    {
        /*
         
        
         Research and implement a ToString() override that will output a string in the format: “This is a red Bic pen without a lid with approximately 55% of the ink remaining.” Use at least one ternary statement.

        Implement the Pen class into our student-teacher-class example, perhaps have a pen object required to do homework.

    */

        // Done
        public string Brand { get; set; }
        // Done
        public string InkColor { get; set; }

        private double _inkLevel;
        public double InkLevel { 
            get
            {
                // Borrowed math from Sai
                return Math.Round(_inkLevel / 5.0) * 5;
            }
            private set
            {
                // If the incoming value is over 100, set the variable to 100 instead.
                if (value > 100)
                {
                    _inkLevel = 100;
                }
                else
                {
                    // If the incoming value is below 0, throw an exception.
                    if (value < 0)
                    {
                        throw new Exception("Not enough ink to do that writing!");
                    }
                    _inkLevel = value;
                }
            }
        }
        // Done
        public int MaxInk { get; set; }
        // Done
        public bool HasLid { get; set; }

        public void Write()
        {
            Write(10);
        }

        public void Write(int characterCount)
        {
            double percentagePerCharacter = (0.05 / MaxInk) * 100;

            // Before: 
            // InkLevel -= percentagePerCharacter * characterCount
            // This is a problem because it calls the getter, behind shorthand for:
            // InkLevel = InkLevel - (percentagePerCharacter * characterCount)
            // Our getter does rounding, so it creates invalid results.
            // To get around this, on the getting part, we go directly to the backing variable.
            // But we keep the property in the setting part so that we don't bypass our validation.
            InkLevel /* <- Setting */ = _inkLevel /* <- Getting */ - percentagePerCharacter * characterCount;
        }

        public Pen()
        {
            Brand = "Pilot";
            InkColor = "Black";
            InkLevel = 100;
            MaxInk = 250;
            HasLid = false;
        }

        public override string ToString()
        {
            return $"This is a {InkColor} {Brand} pen {(HasLid ? "with" : "without")} a lid with approximately {InkLevel}% of the ink remaining.";
        }
    }
}
