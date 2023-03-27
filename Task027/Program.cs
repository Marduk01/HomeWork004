// Напишите программу, которая 
// 1. Принимает на вход число и 
// 2. Выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12;

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.Write($"Сумма от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i; 
    }
    return sum;
}