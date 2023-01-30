// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[]GetRandomArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int [size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(leftRange, rightRange+1);
//     }
//     return array;
// }

// int size = 12;
// int leftRange = -9;
// int rightRange = 9;
// int [] massive = GetRandomArray(size, leftRange, rightRange);
// Console.WriteLine(string.Join(", ", massive));
// int sumP = 0; // сумма позитивных значений
// int sumN = 0; // сумма негативных значений
// for(int i = 0; i < massive.Length; i++){
//     if (massive[i] > 0){
//         sumP += massive[i];
//     }
//     else{
//         sumN += massive[i];
//     }
// }
// Console.WriteLine($"Сумма подожительных значений {sumP}, сумма отрицательных значений {sumN}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[]GetRandomArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int [size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(leftRange, rightRange+1);
//     }
//     return array;
// }

// int size = 12;
// int leftRange = -9;
// int rightRange = 9;
// int [] massive = GetRandomArray(size, leftRange, rightRange);
// Console.WriteLine(string.Join(", ", massive));

// for(int i = 0; i < massive.Length; i++){
//     massive[i] = massive[i] * -1;
//     }
// Console.WriteLine(string.Join(", ", massive));

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[]GetRandomArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int [size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(leftRange, rightRange+1);
//     }
//     return array;
// }

// int size = 12;
// int leftRange = -9;
// int rightRange = 9;
// Console.WriteLine("Введите переменную для поиска в массиве");
// int variable = Convert.ToInt32(Console.ReadLine());
// int [] massive = GetRandomArray(size, leftRange, rightRange);
// Console.WriteLine(string.Join(", ", massive));

// int ancer = 0;
// for(int i = 0; i < massive.Length; i++)
// {
//     while(massive[i] == variable)
//     {
//         ancer = 1;
//         break;
//     }
// }
// if (ancer == 1)
// {
//     Console.WriteLine($"переменная {variable} содержится в созданном массиве");
// }
// else
// {
//     Console.WriteLine($"переменная {variable} не содержится в созданном массиве");
// }


// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//  второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[]GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int [size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange+1);
    }
    return array;
}
int[] MultiArray(int[] array1, int[] array2)
{
    int[]array3 = new int [array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        array3[i] = array1[i]*array2[i];
    }
    
    int lengtArray3 = array1.Length/2;
    Array.Resize(ref array3, lengtArray3);
    if (array1.Length % 2 == 1)
    {
        Array.Resize(ref array3, array3.Length + 1);
        array3[array3.Length - 1] = array1[array1.Length / 2];
    }
    return array3;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int leftRange = -9;
int rightRange = 9;
// формируем рандомный массив
int [] massive = GetRandomArray(size, leftRange, rightRange); 
Console.WriteLine(string.Join(", ", massive));
// разворачиваем созданный массив
int [] revMassive = Enumerable.Reverse(massive).ToArray();
Console.WriteLine(string.Join(", ", revMassive));
// получаем произведение двух массивов
int []Answer = MultiArray(massive, revMassive);

Console.WriteLine(string.Join(", ", Answer));
