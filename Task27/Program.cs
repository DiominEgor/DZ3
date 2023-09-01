// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int NumberDigitSummary( int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = num % 10 + sum;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumberDigitSummary(number);
Console.Write(result);