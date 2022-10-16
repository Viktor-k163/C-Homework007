// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 8 -9
// 8 7 -7 9

// Console.WriteLine("ВВедите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("ВВедите количество стобцов: ");
// int colums = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, colums, -99, 99);
// PrintArray(array);


// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

// Console.WriteLine("Введите позицию числа a и b в двумерном массиве: ");
// int[,] array = GetArray(4, 4, 0, 99);

// int a = int.Parse(Console.ReadLine()!);
// int b = int.Parse(Console.ReadLine()!);

// PrintArray(array);
// FindNumberInaArray();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GetArray(5, 5 , 1, 9);
PrintArray(array);
Console.WriteLine("");
Console.Write("среднее арифметическое элементов в каждом столбце = ");
double AV = FindAverage(5, array);



// void FindNumberInaArray()// Метод для второй задачи 
// {
//   if (a < array.GetLength(0) && b < array.GetLength(1))
//   {
//     Console.WriteLine($" В веденной позиции находиться число {array[a,b]}");
//   }
//   else
//   {
//   Console.WriteLine("Такого Элемента нет");
//   }
// }

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i,j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}

void PrintArray(int[,]array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

double FindAverage(int m, int [,] array)
{
    double sum = 0;
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        for (int i = 0; i < array.GetLength(0); i++) 
        { 
            sum += (double)array[i, j]; 
        }
        average = sum/m;
        Console.Write($"{Math.Round(average, 2)}; ");
        sum = 0;
        }
    return average;

}