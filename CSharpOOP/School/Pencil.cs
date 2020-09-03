using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.School
{
    public class Pencil : WritingInstrument
    {

        //Create a Pencil class that has a similar behaviour to Pen, except uses a GraphiteRemaining property rather than ink level.
        // GraphiteRemaining will start at 100%, and decrease by 0.1% per character written.
       
        private double _graphiteRemaining;
        public double GraphiteRemaining
        {
            get
            {
                // Borrowed math from Sai
                return Math.Round(_graphiteRemaining / 5.0) * 5;
            }
            private set
            {
                // If the incoming value is over current Level, throw an exception.
                if (value > _graphiteRemaining)
                {
                    throw new Exception("You can't add graphite to a pencil");
                }
                else
                {
                    // If the incoming value is below 0, throw an exception.
                    if (value < 0)
                    {
                        throw new Exception("Not enough ink to do that writing!");
                    }
                    _graphiteRemaining = value;
                }
            }
        }

        public override void Write(int characterCount)
        {
           
            GraphiteRemaining /* <- Setting */ = _graphiteRemaining /* <- Getting */ - 0.1 * characterCount;
        }

        public Pencil()
        {
            Brand = "Pilot";
            GraphiteRemaining = 100;
            
        }

        public override string ToString()
        {
            return $"This is a  {Brand} pencil {GraphiteRemaining}% of the ink remaining.";
        }
    }
}
