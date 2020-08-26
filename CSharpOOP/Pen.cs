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

        public string Brand { get; set; }
        public string InkColor { get; set; }
        public double InkLevel { get; set; }
        public int MaxInk { get; set; }
        public bool HasLid { get; set; }

        public void Write()
        {

        }

        public void Write(int characterCount)
        {

        }
    }
}
