// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System.Xml.XPath;

int NumberPower(int num, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result = result * num;
    }
    return result;
}

Console.Write("Введите число для возведения в степень: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень возведения: ");
int power = Convert.ToInt32(Console.ReadLine());

int result = NumberPower(number, power);
Console.WriteLine(result);