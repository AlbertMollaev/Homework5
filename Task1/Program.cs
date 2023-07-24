// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int GetNumber4(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int numbers = array[i];
        if (numbers % 2 == 0)
        {
            result = result + 1;
        }       
    }
    return result;
} 
    

int[] GenerateRandomArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}


int [] array = GenerateRandomArray(20);
Console.Write($"В массиве [{string.Join(",", array)}] колличество четных чисел равно --> {GetNumber4(array)} ");
