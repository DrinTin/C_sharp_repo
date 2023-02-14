// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange) // Создание рандомной матрицы
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
void PrintMatrix(int[,] matrix) // Печать матрицы
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
// void matrixM(int[,] matrix){ // замена строк
//     int temp = 0;
//     for(int j = 0; j < matrix.GetLength(1); j++){
//         temp = matrix[0,j];
//         matrix[0,j] = matrix[matrix.GetLength(0)-1, j];
//         matrix[matrix.GetLength(0)-1, j] = temp;

//     }
// }

// int rows = 3;
// int columns = 4;
// int leftRange = 0;
// int rightRange = 10;

// int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
// Console.WriteLine("\nИсходный массив");
// PrintMatrix(array);
// matrixM(array);
// Console.WriteLine("\nперевернутый массив");
// PrintMatrix(array);


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

// int[,] TMatrix (int[,] matrix) //транспорирование матрицы
// {
//     int[,] Tmatrix = new int [matrix.GetLength(1), matrix.GetLength(0)];
    
//     for (int i = 0; i < Tmatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < Tmatrix.GetLength(1); j++)
//         {
//             Tmatrix[i,j] = matrix[j,i];
//         }
//         Console.WriteLine();
//     }
//     return Tmatrix;

// }

// int rows = 3;
// int columns = 4;
// int leftRange = 0;
// int rightRange = 10;

// int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
// int[,] Tarray = TMatrix(array);
// Console.WriteLine("Исходный массив");
// PrintMatrix(array);
// Console.WriteLine("\nТранспорированная матрица");
// PrintMatrix(Tarray);
// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9



void Count(int[,] matrix, int rightRange)
{
    int [] counters = new int[rightRange+1];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int index = matrix[i,j];
            counters[index]++;

        }
    }
    for (int i = 0; i < counters.Length; i++)
    {
        Console.WriteLine($"Ээлемент {i} встречается {counters[i]} раз");
    }
}

int rows = 3;
int columns = 5;
int leftRange = 0;
int rightRange = 9;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
Console.WriteLine("Исходный массив");
PrintMatrix(array);
Count(array, rightRange);