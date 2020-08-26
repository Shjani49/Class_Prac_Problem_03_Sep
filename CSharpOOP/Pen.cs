using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Pen
    {
        /*
         
        
            *Create a “Pen” class that has the following properties:
        * Brand (Bic, Pilot, etc.)
        InkColor (Red, Blue, Black, etc. - RGB values not needed)
        InkLevel (Percentage, must not accept values below 0 or above 100, throw an exception if an attempt to go lower than 0 is made, and clamp values higher than 100 to 100. Round inputs to two decimal places.) - make the setter private, and make the getter round the output to the nearest 5%. ( public double InkLevel { get {} private set {} } )
        _inkLevel might be 42.15%, but when InkLevel is queried it will output 40%.
        MaxInk (Integer in mL)
        HasLid (True / False)
        and methods:
        Write() and Write(characterCount) - lower ink level according to the number of characters written, assuming 10 characters for the version without parameters. One character equals 0.05mL of ink usage. Your properties should handle validation of ink level if implemented as listed above.
        Create a pen in Program.cs and have code to test it. Write various character counts and check the ink levels. Check the math with a calculator, and ensure it is behaving correctly.

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
    }
}
