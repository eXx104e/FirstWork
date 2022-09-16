class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Упражнение 2.1");
        Console.WriteLine("Введите свое имя");
        string name = (Console.ReadLine());
        Console.WriteLine($"Привет, {name}");
        Console.WriteLine("");

        Console.WriteLine("Упражнение 2.2");
        Console.WriteLine("Введите целое число");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите еще одно целое число");
        int b = int.Parse(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("Введите новое целое число, отличное от нуля");
            int c = int.Parse(Console.ReadLine());
            int res = a / c;
            Console.WriteLine(res);
        }
        else
        {
            int res = a / b;
            Console.WriteLine(res);
        }
        Console.WriteLine("");

        Console.WriteLine("Домашнее задание 2.1");
        Console.WriteLine("Введите букву");
        string letter = Console.ReadLine();
        int index = char.Parse(letter);
        int index1 = index + 1;
        Console.WriteLine((char)index1);
        Console.WriteLine();

        Console.WriteLine("Домашнее заданите 2.2");
        Console.WriteLine("Введите первый коэффициент квадратного уравнения");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второй коэффициент квадратного уравнения");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третий коэффициент квадратного уравнения");
        int c = int.Parse(Console.ReadLine());
        int discriminant = b * b - 4 * a * c; 
        if (discriminant < 0)
        {
            Console.WriteLine("Нет корней, т.к. D < 0");
        }
        if (discriminant == 0)
        {
            double x1 = -b / (2 * a);
            Console.WriteLine($"Уравнение имеет один корень: {x1}");
        }
        if (discriminant > 0)
        {
            double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x3 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Уравнение имеет корни: {x2},{x3}");
        }















    }
}