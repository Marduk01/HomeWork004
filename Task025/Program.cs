// Напишите цикл, который 
// 1. Принимает на вход два числа (A и B) и 
// 2. Возводит число A в натуральную степень B.

Console.Write("Введите число A : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int b = Convert.ToInt32(Console.ReadLine());
int number = a;

for (int i = 1; i < b; i++)
{
    number = number * a;
}
Console.WriteLine("A в степени B = " + number);