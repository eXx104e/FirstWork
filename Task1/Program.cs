using System.Xml.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Задание №1 ");
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
        Console.ReadKey(); 

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

        Console.WriteLine("Задание №9");
        Console.WriteLine("Введите количество покупок в кг(конфеты, печенье, яблоки)\r\n. Цена: \r\nКонфеты : 350\r\nПеченье : 250\r\nЯблоки : 200");
        double un = double.Parse(Console.ReadLine());
        double deux = double.Parse(Console.ReadLine());
        double trois = double.Parse(Console.ReadLine());
        double summa = 350 * un + 250 * deux + 200 * trois;
        Console.WriteLine($"C вас: {summa}");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №10");
        Console.WriteLine("Мир Труд Май");
        string first = "Мир";
        string second = "    Труд";
        string third = "          Май";
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine();
        Console.ReadKey(); 

        Console.WriteLine("Задание №11");
        Console.WriteLine("Введите два числа");
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        int first, second;
        double first_double, second_double;

        bool try_first_int = Int32.TryParse(a, out first);
        bool try_second_int = Int32.TryParse(b, out second);
        bool try_first_double = Double.TryParse(a, out first_double);
        bool try_second_double = Double.TryParse(b, out second_double);
            if (try_first_double && try_second_double)
            {
                double temp;
                temp = first_double;
                first_double = second_double;
                second_double = temp;
                Console.WriteLine(first_double + " " + second_double);
            }
            else if (try_first_int && try_second_int)
            {
                int temp;
                temp = first;
                first = second;
                second = temp;
                Console.WriteLine(first + " " + second);
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №12");
        Console.WriteLine("Bыберите фигуру (0 - треугольник / 1 - четырёхугольник / 2 - круг)");
        int figurka = int.Parse(Console.ReadLine());
        if (figurka == 0)
        {
            Console.WriteLine("Периметр или площадь? (0 - периметр / 1 - площадь)");
            int tofind = int.Parse(Console.ReadLine());
            if (tofind == 0)
            {
                Console.WriteLine("Длины трех сторон треугольника");
                int[] faf = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                Console.WriteLine("периметр равен: " + (faf[0] + faf[1] + faf[2]));
            }
            else
            {
                Console.WriteLine("Длины трех сторон треугольника");
                int[] vav = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                Console.WriteLine("площадь равна: " + Math.Sqrt(((vav[0] + vav[1] + vav[2]) / 2) * ((vav[0] + vav[1] + vav[2]) / 2 - vav[0]) * ((vav[0] + vav[1] + vav[2]) / 2 - vav[1]) * ((vav[0] + vav[1] + vav[2]) / 2 - vav[2])));
            }
        }
        if (figurka == 1)
        {
            Console.WriteLine("Периметр или площадь? (0 - периметр / 1 - площадь)");
            int rar = int.Parse(Console.ReadLine());
            if (rar == 0)
            {
                Console.WriteLine("Длины сторон четырехугольника");
                int[] ger = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                Console.WriteLine("Периметр равен: " + 2 * (ger[0] + ger[1]));
            }
            else
            {
                Console.WriteLine("Длины сторон четырехугольника");
                int[] kak = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                Console.WriteLine("плоащадь равна: " + (kak[0] * kak[1]));
            }
        }
        if (figurka == 2)
        {
            Console.WriteLine("Периметр или площадь? (0 - периметр / 1 - площадь)");
            int ili = int.Parse(Console.ReadLine());
            if (ili == 0)
            {
                Console.WriteLine("Радиус круга?");
                int radius = int.Parse(Console.ReadLine());
                Console.WriteLine("Периметр равен: " + Math.Round(2 * (radius * Math.PI)));
            }
            else
            {
                Console.WriteLine("Радиус круга?");
                int radius = int.Parse(Console.ReadLine());
                Console.WriteLine("Площадь равна: " + Math.Round(Math.PI * Math.Pow(radius, 2)));
            }
        }
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("задание 13. вы ввели... ");
        Console.WriteLine("введите число");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"вы ввели число {b}");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №14");
        string[] arr = { "2 кг", "13 17" };
        Console.WriteLine(arr[0] + "\n" + arr[1]);
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №15");
        Random rnd = new Random();
        double value = rnd.Next(-100000000, 100000000);    
        double value1 = rnd.Next(-100000000, 100000000);
        double value2 = rnd.Next(-100000000, 100000000);
        double value3 = rnd.Next(-100000000, 100000000);
        Console.WriteLine(value + "\n" + value1 + "\n" + value2 + "\n" + value3);
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №16");
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
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №17");
        Console.WriteLine("Введите первое число");
        int lupa = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int pupa = int.Parse(Console.ReadLine());
        Console.WriteLine("Среднее арифметическое: " + (lupa + pupa) / 2 + "\n" + "Среднее геометрическое: " + Math.Sqrt(lupa * pupa));
        Console.WriteLine();
        Console.ReadKey();


        Console.WriteLine("Задание №18");
        Console.WriteLine("Координаты точки 1 (x , y)");
        int[] xy1 = Console.ReadLine().Split(' ').Select(l => int.Parse(l)).ToArray();
        Console.WriteLine("Координаты точки 2 (x , y)");
        int[] xy2 = Console.ReadLine().Split(' ').Select(l => int.Parse(l)).ToArray();
        Console.WriteLine("Расстояние между точками: " + Math.Sqrt(Math.Pow((xy2[0] - xy1[0]), 2) + Math.Pow((xy2[1] - xy1[1]), 2)));
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №19");
        int z1 = 11;
        int z2 = 22;
        int z3 = 33;
        int z4 = 44;
        Console.WriteLine($"a = {z1}  b = {z2}  c = {z3}");
        z4 = z2;
        z2 = z3;
        c = z1;
        z1 = z4;
        Console.WriteLine($"Пункт А: a = {z1}  b = {z2}  c = {z3}");
        z1 = 11;
        z2 = 22;
        z3 = 33;
        z4 = 44;
        z4 = z2;
        z2 = z1;
        z1 = z3;
        z3 = z4;
        Console.WriteLine($"Пункт Б: a = {z1}  b = {z2}  c = {z3}");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №20");
        Console.WriteLine("Введите число секунд");
        int sec = int.Parse(Console.ReadLine());
        Console.WriteLine("Часы: " + sec / (60 * 60));
        Console.WriteLine("Минуты с начала нового часа: " + ((sec / 60) - ((sec / 60) / 60) * 60));
        Console.WriteLine("Секунды с начала новой минуты: " + sec % 60);
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №21");
        Console.WriteLine("Можно вырезать " + (543 / 130) + " квадратов");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №23");
        Console.WriteLine("Введите трёхначное число");
        int ty = int.Parse(Console.ReadLine());
        Console.WriteLine($"{ty % 10}{ty / 10}");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №23");
        Console.WriteLine("Введите число больше чем 999");
        int grace = int.Parse(Console.ReadLine());
        Console.WriteLine("a) Число сотен: " + (grace / 100) % 10);
        Console.WriteLine("b) Число тысяч: " + (grace / 1000));
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание 24");
        Console.WriteLine("Введите число больше чем 999");
        string lv = Console.ReadLine();
        string vl = "";
        for (int t1 = lv.Length - 1; t1 >= 0; t1--)
        {
            vl += lv[t1];
        }
        Console.WriteLine("a) " + vl);
        if ((int.Parse(lv) / 100) % 10 == 0)
        {
            Console.WriteLine("b) " + lv[0] + lv[2] + lv[3]);
        }
        else
        {
            Console.WriteLine("b) " + lv[1] + lv[0] + lv[2] + lv[3]);
        }
        Console.WriteLine("c) " + lv[0] + lv[2] + lv[1] + lv[3]);
        if ((int.Parse(lv) / 10) % 10 == 0)
        {
            Console.WriteLine("d) " + lv[3] + lv[0] + lv[1]);
        }
        else
        {
            Console.WriteLine("d) " + lv[2] + lv[3] + lv[0] + lv[1]);
        }
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №25");
        Console.WriteLine("Введите число большее или равное 100, но также меньшее или равное 999");
        string frfr = Console.ReadLine();
        if ((int.Parse(frfr) / 10) % 10 == 0)
        {
            Console.WriteLine("Введите другое число");
        }
        else
        {
            Console.WriteLine("x = " + frfr[1] + frfr[2] + frfr[0]);
        }
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №26");
        Console.WriteLine("Часы, минуты, секунды");
        int chasy = int.Parse(Console.ReadLine());
        int minuty = int.Parse(Console.ReadLine());
        int sekundy = int.Parse(Console.ReadLine());
        if (chasy > 11)
        {
            chasy -= 12;
        }
        Console.WriteLine("Искомый угол равен: " + ((360 / 12) * chasy + (0.5 * minuty) + (0.0083 * sekundy)));
        Console.WriteLine();
        Console.ReadKey();


        Console.WriteLine("Задание №28");
        Console.WriteLine("Введите три числа");
        int[] asf = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        int[] wtf = { Math.Abs(asf[0]), Math.Abs(asf[1]), Math.Abs(asf[2]) };
        Console.WriteLine("меньшее из трёх: " + wtf.Min());
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №29");
        Console.WriteLine("Введите три числа");
        int[] kind = Console.ReadLine().Split(' ').Select(r => int.Parse(r)).ToArray();
        Console.WriteLine("Cумма наибольшего и наименьшего : " + (kind.Min() + kind.Max()));
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("Введите целое число");
        int bbb = 0;
        int ccc;
        if (Int32.TryParse(Console.ReadLine(), out ccc))
        {
            Console.WriteLine("Делители числа" + ccc);
            for (int m = 1; m <= ccc; m++)
                if (ccc % m == 0)
                {
                    bbb++;
                }
            Console.WriteLine("Количество делителей числа " + ccc + " : " + bbb);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Введите число");

        }
        Console.WriteLine("Задание №31");
        Console.WriteLine("Введите коэффициенты уравнения a,b,c,d");
        int[] aif = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        for (int eee = -100; eee <= 100; eee++)
        {
            double result = aif[0] * Math.Pow(eee, 3) + aif[1] * eee * eee + aif[2] * eee + aif[3];
            if (result == 0)
            {
                Console.WriteLine("X = " + eee);
            }
        }
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №32");
        Console.WriteLine("Введите первый элемент последовательности");
        double sequence = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второй элемент последовательности");
        double consequence = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите номер элемента последовательности, который желаете найти");
        double nomer = double.Parse(Console.ReadLine());
        double element = sequence + ((consequence - sequence) * (nomer - 1));
        Console.WriteLine($"Элемент последовательности с номером {nomer} равен {element}");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №33");
        Console.WriteLine("Дайте ответы на следующие вопросы");
        Console.WriteLine("Являетесь ли вы пенсионером? (1 - да / 0 - нет)");
        int PAZHILOY = int.Parse(Console.ReadLine());
        Console.WriteLine("Являетесь ли вы студентом? (1 - да / 0 - нет)");
        int MALADOY = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы тродоустроены? (1 - да / 0 - нет)");
        int trud = int.Parse(Console.ReadLine());
        if (((PAZHILOY == 1 && trud == 0) || (MALADOY == 1 && trud == 0)) && (PAZHILOY == 0 || MALADOY == 0))
        {
            Console.WriteLine("Вам одобрен кредит");
        }
        else
        {
            Console.WriteLine("Вам не одобрен кредит");
        }
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №34");
        Console.WriteLine("Введите имя");
        string IMYA = Console.ReadLine();
        Console.WriteLine($"А) {IMYA}");
        Console.WriteLine("введите имя");
        string IMYAESHE = Console.ReadLine();
        Console.WriteLine($"B) Привет, {IMYAESHE}!");
        Console.WriteLine();
        Console.ReadKey();

        Console.WriteLine("Задание №35");
        Random CVET = new Random();
        Console.ReadLine();
        Console.WriteLine("Как тебя зовут?");
        string IMYATRI = Console.ReadLine();
        Console.WriteLine($"Привет, {IMYATRI}");
        Console.ReadLine();
        Console.WriteLine("Да");
        Console.ReadLine();
        Console.WriteLine("Нет");
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("Но могу показать");
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine();
        Console.ReadKey();


    }


}







