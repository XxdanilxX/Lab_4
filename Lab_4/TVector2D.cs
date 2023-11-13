using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class TVector2D
    {
        public double x;
        public double y;


        public TVector2D()
        {
            x = 0;
            y = 0;
        }


        public TVector2D(double xValue, double yValue)
        {
            x = xValue;
            y = yValue;
        }


        public TVector2D(TVector2D source)
        {
            x = source.x;
            y = source.y;
        }


        public void Input()
        {
            Console.Write("Введіть координату x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть координату y: ");
            y = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Вектор: ({x}, {y})");
        }


        public void Normalize()
        {
            double magnitude = Math.Sqrt(x * x + y * y);
            if (magnitude > 0)
            {
                x /= magnitude;
                y /= magnitude;
            }
        }


        public bool Compare(TVector2D otherVector)
        {
            return x == otherVector.x && y == otherVector.y;
        }



        public static TVector2D operator +(TVector2D vector1, TVector2D vector2)
        {
            return new TVector2D(vector1.x + vector2.x, vector1.y + vector2.y);
        }

        public static TVector2D operator -(TVector2D vector1, TVector2D vector2)
        {
            return new TVector2D(vector1.x - vector2.x, vector1.y - vector2.y);
        }

        public static double operator *(TVector2D vector1, TVector2D vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y;
        }
    }
}
