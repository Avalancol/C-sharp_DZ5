int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CountChetMass(int[] massive)
{
    int count = 0;
    foreach (int element in massive)
    {
        if (element % 2 == 0) count++;
    }
    return count;
}
//________________________________________________________________________

int[] array = GetRandomArray(20, 100, 999);
Console.WriteLine($"\nЗадача 1.\n[{String.Join(", ", array)}]");
Console.WriteLine($"Количество четных элементов: {CountChetMass(array)}]");


// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SummNechetIndex(int[] massive)
{
    int summ = 0;
    for (int count = 1; count < massive.Length; count += 2)
    {
        summ += massive[count];
    }
    return summ;
}
//________________________________________________________________________

array = GetRandomArray(11, 1, 10);
Console.WriteLine($"\nЗадача 2.\n[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных индексах: {SummNechetIndex(array)}]");


// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

double[] GetRandomFloatArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
    }

    return result;
}

double DiffMinMax(double[] massive)
{
    double MaxElem = massive[0];
    double MinElem = massive[0];
    foreach (double elem in massive)
    {
        if (elem > MaxElem) MaxElem = elem;
        if (elem < MinElem) MinElem = elem;
    }
    Console.WriteLine("Минимальный элемент: " + MinElem);
    Console.WriteLine("Максимальный элемент: " + MaxElem);
    return MaxElem - MinElem;
}
//________________________________________________________________________

double[] arrayD = GetRandomFloatArray(11, 5, 10);
Console.WriteLine($"\nЗадача 3.\n[{String.Join("; ", arrayD)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {Math.Round(DiffMinMax(arrayD),2)}");