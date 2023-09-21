using System.Text;
using System.Text.RegularExpressions;

public class Laboratory_Tumakov_Number2
{   
    public static void exersice_2_1()
    {
        Console.WriteLine("Упражнение 2.1. Спросить имя пользователя и поприветствовать его");
        Console.WriteLine("Как Вас зовут?");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");
    }

    public static void exersice_2_2()
    {
        Console.WriteLine("Упражнение 2.2. Найти частное от деление одного числа на другое");
        Console.WriteLine("Введите число a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число b:");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b != 0)
        {
            Console.WriteLine($"a / b = {a / b}!");
        }
        else
        {
            Console.WriteLine("На ноль делить нельзя");
        }
    }

    public static void homework_2_1()
    {
        Console.WriteLine("Домашняя работа 2.1. Вывести следующую букву алфавита");
        Console.WriteLine("Введите маленькую английскую букву:");
        int charToNext = Convert.ToChar(Console.ReadLine());
        char nextLetter = (char)(charToNext + 1);
        if (charToNext == 'z')
        {
            nextLetter = 'a';
        }
        Console.WriteLine($"Следующая буква после {(char)charToNext}: {nextLetter}");
    }

    public static void homework_2_2()
    {
        Console.WriteLine("Домашняя работа 2.2. Решение квадратного уравнения");
        Console.WriteLine("Введите число a");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число b");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число c");
        double c = Convert.ToDouble(Console.ReadLine());
        double discriminant;
        double answer;
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.Write("\nУравнение имеет бесконечно много решений\n");
                    return;
                }
                Console.Write("\nУравнение не имеет решений\n");
                return;
            }
            answer = -c / b;
            Console.Write("\nУравнение имеет единственное решение\n");
            Console.Write($"\nX = {answer}\n");
            return;
        }
        discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.Write("\nУравнение не имеет решений в действительных числах\n");
            return;
        }
        if (discriminant == 0)
        {
            answer = -b / (2 * a);
            Console.Write("\nУравнение имеет единственное решение\n");
            Console.Write($"\nX = {answer}\n");
            return;
        }
        double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine("\nУравнение имеет два решения\n");
        Console.WriteLine($"X1 = {x1}");
        Console.WriteLine($"X2 = {x2}");
        return;
    }
    public static void Main()
    {
        exersice_2_1();
        exersice_2_2();
        homework_2_1();
        homework_2_2();
    }
}