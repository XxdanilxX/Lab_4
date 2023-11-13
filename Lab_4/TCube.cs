using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class TCube: TSquare
    {
        public TCube() : base() { }


        public TCube(double sideLength) : base(sideLength) { }


        public TCube(TCube source) : base(source) { }


        public double CalculateVolume()
        {
            return Math.Pow(base.CalculateArea(), 3);
        }


        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Об'єм куба: {CalculateVolume()}");
        }
    }
}
