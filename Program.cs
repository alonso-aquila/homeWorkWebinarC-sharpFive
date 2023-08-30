// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

var array = GenerateArray(8); // в условии задачи не говорится о количестве элементов массива (зададим восемь)

PrintArray(array);

var resultSumPositiveNumber = GetSumPositiveNumber(array);

Console.WriteLine($" Сумма четных чисел в  массиве = {resultSumPositiveNumber}");

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(99, 1000);
    }
    return result;
}

int GetSumPositiveNumber (int[] array)
{
    int result = default;
    
    foreach (var item in array)
    {
        
        if (item % 2 == 0)
        {
            result += item;
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write($"Случайно сгенерированный массив: [ ");
    foreach (int i in array) // перебирает непосредственно значение элементов массива
    {   
        Console.Write($"{i} ");
    }
    Console.Write($"]");
}



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


var array = GenerateArray(10); // в условии задачи не говорится о количестве элементов массива (зададим десять)

PrintArray(array);

var resultSumPositivePosition = GetSumPositivePosition(array);

Console.WriteLine($" Сумма элементов на четных позициях в массиве = {resultSumPositivePosition}");


int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-99, 100);
    }
    return result;
}


int GetSumPositivePosition (int[] array)
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
      if(i != 0 && i % 2 == 0)
      {
        result += array [i];
        i++;
      }
    }
    return result;
}
    

void PrintArray(int[] array)
{
    Console.Write($"Случайно сгенерированный массив: [ ");
    foreach (int i in array)
    {   
        Console.Write($"{i} ");
    }
    Console.Write($"]. ");
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


var array = GenerateArray(10); // в условии задачи не говорится о количестве элементов массива (зададим десять)

PrintArray(array);

var resultetDiffMinOfMax = GetDiffMinOfMax(array);

Console.WriteLine($" Разница между минимальным и максимальным значениями массива = {resultetDiffMinOfMax}");


double[] GenerateArray(int length)
{
    double[] result = new double[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

double GetDiffMinOfMax (double[] array)
{   
    double min = array [0];
    double max = array [0];
    double result = default;

    for (int i = 1; i < array.Length; i++)
    {
      if(array [i] > max)
      {
        max = array [i];
      }
      else
      {
        min = array [i];
      }
      i++;
    }
    
    result = max - min;
    return result;

}

void PrintArray(double[] array)
{
    Console.Write($"Случайно сгенерированный массив: [ ");
    foreach (int i in array)
    {   
        Console.Write($"{i} ");
    }
    Console.Write($"]. ");
}

