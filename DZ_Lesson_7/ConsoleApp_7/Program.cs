
// Домашняя работа:
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9 ​
// 8 7,8 -7,1 9


// void GetRandomMatrix(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintMatrix(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("введите количество строк");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[lines, columns];
// GetRandomMatrix(matrix);
// PrintMatrix(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет
// ​

// int[,] GetRandomMatrix (int rows, int columns, int leftRange, int rightRange)
// {
//     int[,] matrix = new int[rows,columns];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(leftRange, rightRange +1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int leftRange = 0;
// int rightRange = 10;

// int [,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
// Console.WriteLine();
// PrintMatrix (array);
// Console.WriteLine();

// if (n > array.GetLength(0)-1 || m > array.GetLength(1)-1)
// {
//     Console.WriteLine("такого элемента нет");
//     Console.WriteLine();
// }
// else
// {
//     Console.WriteLine($"значение элемента [{n},{m}] равно {array[n,m]}");
//     Console.WriteLine();
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomMatrix (int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows,columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(leftRange, rightRange +1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int leftRange = 0;
int rightRange = 10;

int [,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
Console.WriteLine();
PrintMatrix (array);
Console.WriteLine();

for (int j = 0; j < array.GetLength(1); j++)
{
    double arithMean = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        arithMean = (arithMean + array[i, j]);
    }
    arithMean = arithMean / rows;
    Console.Write(arithMean + "; ");
    Console.WriteLine();
}
Console.WriteLine();
