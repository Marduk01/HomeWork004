// Напишите программу, которая 
// 1. Задаёт массив из 8 элементов и 
// 2. Выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



int[] array = new int[8];

Random nmb = new Random();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    array[i] = nmb.Next(0,99);
    Console.Write($"{array[i]} ");
}

Console.Write("]");