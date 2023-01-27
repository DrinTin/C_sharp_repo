// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(-10,10);
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// int[,] matrix = new int[3, 4];
// Console.WriteLine();
// PrintArray(matrix);
// Console.WriteLine();

// int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
// {
//     int[,] matrix = new int[rows, columns];

//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
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

// const int ROWS = 3;
// const int COLUMNS = 4;
// const int LEFT_RANGE = 0;
// const int RIGHT_RANGE = 10;

// int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
// PrintMatrix(array);

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


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

// int[,] GetRandomMatrix(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];

//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }

//     return matrix;
// }

// const int ROWS = 3;
// const int COLUMNS = 4;

// int[,] array = GetRandomMatrix(ROWS, COLUMNS);
// PrintMatrix(array);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
// {
//     int[,] matrix = new int[rows, columns];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
//         }
//     }

//     return matrix;
// }

// void GetSquareElem(int[,] matrix)
// {
//     for (int i = 1; i < matrix.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < matrix.GetLength(1); j += 2)
//         {
//             matrix[i, j] *= matrix[i, j];
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// // void PrintMatrix2(int[,] matrix)
// // {
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             if (i % 2 != 0 && j % 2 != 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
// //             Console.Write(matrix[i, j] + " ");
// //         }
// //         Console.WriteLine();

// const int ROWS = 5;
// const int COLUMNS = 7;
// const int LEFT_RANGE = 0;
// const int RIGHT_RANGE = 10;

// int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);

// Console.WriteLine();
// PrintMatrix(resultMatrix);
// Console.WriteLine();
// GetSquareElem(resultMatrix);
// // PrintMatrix2(array);
// PrintMatrix(resultMatrix);
// Console.WriteLine();


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной


int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

int GetSumMainDiagonal(int[,] matrix)
{
    int result = 0;

    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {        
        result += matrix[i, i];        
    }

    return result;   
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 4;
const int COLUMNS = 7;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine();
PrintMatrix(resultMatrix);
int sum = GetSumMainDiagonal(resultMatrix);
Console.WriteLine();
Console.WriteLine(sum);
Console.WriteLine();