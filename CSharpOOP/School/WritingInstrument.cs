using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.School
{
    abstract public class WritingInstrument
    {
        /*
            WritingInstrument should have a Write() method that MUST be overridden by its children.
          
            Set Pen to inherit from WritingInstrument.
            
            Create a Pencil class that has a similar behaviour to Pen, except uses a GraphiteRemaining property rather than ink level.
                GraphiteRemaining will start at 100%, and decrease by 0.1% per character written.

            Set the WritingInstrument property in Student to be polymorphic.
         */
        public string Brand { get; set; }
        public void Write()
        {
            Write(10);
        }
        abstract public void Write(int charcterCount);
    }
}
