﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumNegative(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] GenerateRandomArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(1, 50);
    }
    return array;
}


int [] array = GenerateRandomArray(10);
Console.Write($"В массиве [{string.Join(",", array)}] сумма чисел на нечетных позициях равна --> {GetSumNegative(array)} ");

