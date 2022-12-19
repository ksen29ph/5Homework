﻿// Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных числе в массиве.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int count = 0;
for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;
Console.WriteLine($"В массиве {numbers.Length} чисел, четных чисел {count} ");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}