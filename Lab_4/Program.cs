namespace Lab_4
{
    
    
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Завдання 1");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Тестування класу TSquare:");
            TSquare square1 = new TSquare();
            square1.Input();
            square1.Display();
            Console.WriteLine($"Площа: {square1.CalculateArea()}, Периметр: {square1.CalculatePerimeter()}");
            Console.WriteLine("\n");

            TSquare square2 = new TSquare();
            square2.Input();
            Console.WriteLine("\nДругий квадрат:");
            square2.Display();

            if (square1.Compare(square2))
                Console.WriteLine("Квадрати мають однакові сторони.");
            else
                Console.WriteLine("Квадрати мають різні сторони.");

            TSquare square3 = square1 + square2;
            Console.WriteLine("\nСума перших двох квадратів:");
            square3.Display();

            TSquare square4 = square3 * 2.5;
            Console.WriteLine("\nДобуток третього квадрата на 2.5:");
            square4.Display();

            TSquare square5 = square1 - square2;
            Console.WriteLine("\nРізниця перших двох квадратів:");
            square5.Display();

            Console.WriteLine("\nТестування класу TCube:");
            TCube cube1 = new TCube();
            cube1.Input();
            Console.WriteLine("\nКуб:");
            cube1.Display();

            Console.ReadLine();
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Завдання 2");
            Console.WriteLine("Тестування класу TVector2D:");
            TVector2D vector2D1 = new TVector2D();
            vector2D1.Input();
            vector2D1.Display();
            vector2D1.Normalize();
            Console.WriteLine("Нормований вектор:");
            vector2D1.Display();

            TVector2D vector2D2 = new TVector2D();
            vector2D2.Input();
            Console.WriteLine("\nДругий вектор:");
            vector2D2.Display();

            if (vector2D1.Compare(vector2D2))
                Console.WriteLine("Вектори мають однакові координати.");
            else
                Console.WriteLine("Вектори мають різні координати.");

            TVector2D vector2D3 = vector2D1 + vector2D2;
            Console.WriteLine("\nСума перших двох векторів:");
            vector2D3.Display();

            double dotProduct = vector2D1 * vector2D2;
            Console.WriteLine($"\nСкалярний добуток перших двох векторів: {dotProduct}");

            Console.WriteLine("\nТестування класу TVector3D:");
            TVector3D vector3D1 = new TVector3D();
            vector3D1.Input();
            vector3D1.Display();
            vector3D1.Normalize();
            Console.WriteLine("Нормований вектор:");
            vector3D1.Display();

            TVector3D vector3D2 = new TVector3D();
            vector3D2.Input();
            Console.WriteLine("\nДругий вектор:");
            vector3D2.Display();

            if (vector3D1.Compare(vector3D2))
                Console.WriteLine("Вектори мають однакові координати.");
            else
                Console.WriteLine("Вектори мають різні координати.");

            TVector3D vector3D3 = vector3D1 + vector3D2;
            Console.WriteLine("\nСума перших двох векторів:");
            vector3D3.Display();

            double dotProduct3D = vector3D1 * vector3D2;
            Console.WriteLine($"\nСкалярний добуток перших двох векторів: {dotProduct3D}");

            Console.ReadLine();
            Console.WriteLine(new string('=', 60));
        }
    }

}

