using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class TSquare
    {
        private double side;

        public TSquare()
        {
            side = 0;
        }

        public TSquare(double sideLength)
        {
            if (sideLength > 0)
                side = sideLength;
            else
                throw new ArgumentException("Довжина сторони повинна бути більше 0.");
        }


        public TSquare(TSquare source)
        {
            side = source.side;
        }


        public void Input()
        {
            Console.Write("Введіть довжину сторони квадрата: ");
            double input = Convert.ToDouble(Console.ReadLine());
            if (input > 0)
                side = input;
            else
                Console.WriteLine("Довжина сторони повинна бути більше 0. Значення залишено незмінним.");
        }


        public void Display()
        {
            Console.WriteLine($"Сторона квадрата: {side}");
        }


        public double CalculateArea()
        {
            return side * side;
        }


        public double CalculatePerimeter()
        {
            return 4 * side;
        }


        public bool Compare(TSquare otherSquare)
        {
            return side == otherSquare.side;
        }

        public static TSquare operator +(TSquare square1, TSquare square2)
        {
            return new TSquare(square1.side + square2.side);
        }

        public static TSquare operator -(TSquare square1, TSquare square2)
        {
            double result = square1.side - square2.side;
            return result > 0 ? new TSquare(result) : new TSquare();
        }

        public static TSquare operator *(TSquare square, double multiplier)
        {
            return new TSquare(square.side * multiplier);
        }
    }
}
