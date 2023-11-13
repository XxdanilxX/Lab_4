using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class TVector3D: TVector2D
    {
        private double z;


        public TVector3D() : base()
        {
            z = 0;
        }


        public TVector3D(double xValue, double yValue, double zValue) : base(xValue, yValue)
        {
            z = zValue;
        }


        public TVector3D(TVector3D source) : base(source)
        {
            z = source.z;
        }

        public new void Input()
        {
            base.Input();
            Console.Write("Введіть координату z: ");
            z = Convert.ToDouble(Console.ReadLine());
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Третя координата z: {z}");
        }



        public new void Normalize()
        {
            double magnitude = Math.Sqrt(x * x + y * y + z * z);
            if (magnitude > 0)
            {
                x /= magnitude;
                y /= magnitude;
                z /= magnitude;
            }
        }

        public new bool Compare(TVector2D otherVector)
        {
            if (otherVector is TVector3D)
            {
                TVector3D otherVector3D = (TVector3D)otherVector;
                return x == otherVector3D.x && y == otherVector3D.y && z == otherVector3D.z;
            }
            return false;
        }


        public static TVector3D operator +(TVector3D vector1, TVector3D vector2)
        {
            return new TVector3D(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);
        }

        public static TVector3D operator -(TVector3D vector1, TVector3D vector2)
        {
            return new TVector3D(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);
        }

        public static double operator *(TVector3D vector1, TVector3D vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
        }
    }
}
