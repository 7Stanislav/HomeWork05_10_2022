// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] array = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        positiveSum += 1;
    }
}

Console.WriteLine($"Количество четных чисел в массиве: {positiveSum}");


int[] GetArray(int size, int minValue, int maxValue)
    {
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
    }
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] array = GetArray(5, -99, 100);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;

for (int i = 1; i < array.Length; i = i + 2)
{
    positiveSum += array[i];
}

Console.WriteLine($"Сумма элементов на нечетных позициях: {positiveSum}");


int[] GetArray(int size, int minValue, int maxValue)
    {
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
    }
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] numbers = new double[5];
GetArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
        {
            max = numbers[a];
        }
    if (numbers[a] < min)
        {
            min = numbers[a];
        }
}

Console.WriteLine();
Console.WriteLine($"{max} - {min} = {max - min}");

void GetArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
            Console.Write(numbers[i] + " ");
        }
}