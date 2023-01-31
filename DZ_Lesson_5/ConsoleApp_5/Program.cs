// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[]GetRandomArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int [size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(leftRange, rightRange+1);
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int leftRange = 100;
// int rightRange = 1000;
// // формируем рандомный массив
// int [] massive = GetRandomArray(size, leftRange, rightRange); 
// Console.WriteLine(string.Join(", ", massive));
// // считаем кол-во четных элементов
// int element = 0;
// for (int i = 0; i < massive.Length; i++)
// {
//     if(massive[i] % 2 == 0)
//     {
//         element++;
//     }
// }
// Console.WriteLine($"всего {massive.Length} чисел, {element} из них чётные");

// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[]GetRandomArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int [size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(leftRange, rightRange+1);
//     }
//     return array;
// }

// int size = 123;
// int leftRange = 0;
// int rightRange = 151;
// // формируем рандомный массив
// int [] massive = GetRandomArray(size, leftRange, rightRange); 
// Console.WriteLine(string.Join(", ", massive));
// // считаем кол-во элементов на отрезке от 10 до 99
// int element = 0;
// for (int i = 0; i < massive.Length; i++)
// {
//     if(massive[i] > 9 & massive[i] < 100)
//     {
//         element++;
//     }
// }
// Console.WriteLine($"в массиве из {massive.Length} чисел, {element} на отрезке от 10 до 99");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[]GetRandomArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int [size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(leftRange, rightRange+1);
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int leftRange = 100;
// int rightRange = 1000;
// // формируем рандомный массив
// int [] massive = GetRandomArray(size, leftRange, rightRange); 
// Console.WriteLine(string.Join(", ", massive));
// // считаем кол-во нечетных элементов
// int element = 0;
// for (int i = 0; i < massive.Length; i++)
// {
//     if(i % 2 == 1)
//     {
//         element = element + massive[i];
//     }
// }
// Console.WriteLine($"всего {massive.Length} чисел, сумма нечетных элементов равна {element}");


// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[]GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int [size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange+1);
    }
    return array;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int leftRange = 1;
int rightRange = 1000;
// формируем рандомный массив
int [] massive = GetRandomArray(size, leftRange, rightRange); 
Console.WriteLine(string.Join(", ", massive));
// ищем максимальное и минимальное значение массива
int minNumber = massive[0];
int maxNumber = massive[0];

for (int i = 0; i < massive.Length; i++)
{
    if(massive[i] < minNumber)
    {
        minNumber = massive[i];
    }
    if(massive[i] > maxNumber)
    {
        maxNumber = massive[i];
    }
}
Console.WriteLine($"минимальное значение массива {minNumber}, максимальное значение массива {Number}");
