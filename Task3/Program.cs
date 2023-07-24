// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void DoArray(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().NextDouble() * (4.50 - 2.30) + 2.30;
        Console.Write($"{randomArray[i]:F2} ");
    }

}


double MinMaxComparision(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max<randomArray[i])  max = randomArray[i];
        if (min>randomArray[i])  min = randomArray[i];
        i = i + 1;
    }
    return max-min;
}

DoArray(a);
Console.Write($"Разница между максимальным и минимальным элементов массива: {MinMaxComparision(randomArray):F2}");