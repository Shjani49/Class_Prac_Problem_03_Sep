using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Homework
    {
        private int _complexity;
        public int Complexity
        {
            get
            {
                return _complexity;
            }
            set
            {
                if (value > 5)
                {
                    _complexity = 5;
                }
                else if (value < 1)
                {
                    _complexity = 1;
                }
                else
                {
                    _complexity = value;
                }
            }
        }
    }
}
