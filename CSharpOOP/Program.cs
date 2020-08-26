using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen redPen = new Pen()
            {
                Brand = "Bic",
                InkColor = "Red",
                HasLid = true,
                MaxInk = 1
            };
            Pen bluePen = new Pen()
            {
                Brand = "Bic",
                InkColor = "Blue",
                HasLid = false,
                MaxInk = 10
            };
            Pen blackPen = new Pen()
            {
                Brand = "Pilot",
                InkColor = "Black",
                HasLid = false,
                MaxInk = 150
            };

            TestPen(redPen);
            TestPen(bluePen);
            TestPen(blackPen);

        }
        public static void TestPen (Pen toTest)
        {
            Console.WriteLine($"This is a {toTest.Brand} {toTest.InkColor} pen which has {toTest.InkLevel}% of its ink remaining.");
            toTest.Write();
            Console.WriteLine($"This is a {toTest.Brand} {toTest.InkColor} pen which has {toTest.InkLevel}% of its ink remaining.");
            try
            {
                toTest.Write(50);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"This is a {toTest.Brand} {toTest.InkColor} pen which has {toTest.InkLevel}% of its ink remaining.");
        }
    }
}
