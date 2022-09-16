class Program
{
    static void Main(String[] args)
    {
        /*Console.WriteLine("Задание №1 ");
        Console.WriteLine(Math.Round(Math.E, 1));
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №2");
        Console.WriteLine("50");
        Console.WriteLine("10");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №3");
        Console.WriteLine("11\r\n121\r\n1331\r\n14641");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №4");
        Console.WriteLine("Введите любое число");
        double x = double.Parse(Console.ReadLine());
        double x1 = x + 10;
        Console.WriteLine(x1);
        Console.WriteLine();
        Console.ReadKey(); 

        Console.WriteLine("Задание №5");
        Console.WriteLine("Введите длину стороны квадрата");
        double y = double.Parse(Console.ReadLine());
        double y1 = y * 4;
        Console.WriteLine(x1);
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №6");
        Console.WriteLine("Введите длину радиуса круга");
        double c = double.Parse(Console.ReadLine());
        double c1 = c * c * Math.PI;
        double c2 = 2 * c * Math.PI;
        Console.WriteLine($"Площадь круга равна: {c1}");
        Console.WriteLine($"Длина окружности равна: {c2}");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №7");
        Console.WriteLine("Введите аргумент х для функции y=cos(x)");
        double f = double.Parse(Console.ReadLine());
        double f1 = Math.Cos(f);
        Console.WriteLine(f1);
        Console.WriteLine();
        Console.ReadKey(); */

        Console.WriteLine("Задание №8");
        Console.WriteLine("Введите длину высоты трапеции");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину верхнего основания трапеции");
        double upperlength = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину нижнего основания трапеции");
        double lowerlength = double.Parse(Console.ReadLine());
        double u1 = Math.Sqrt(length * length + Math.Abs((upperlength - lowerlength) / 2) * Math.Abs((upperlength - lowerlength) / 2));
        double resultat = upperlength + lowerlength + 2 * u1;
        Console.WriteLine($"Периметр трапеции равен: {resultat}");
        Console.WriteLine();
        Console.ReadKey();


    }
}