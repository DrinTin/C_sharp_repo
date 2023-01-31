// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

// int ReadNumberA(string messege)
// {
//     Console.WriteLine(messege);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int ReadNumberB(string messege)
// {
//     Console.WriteLine(messege);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int AdegreeB(int a, int b)
// {
    
//     int st_meaning = a;
//     for (int i = 2; i <= b; i++)
//     {
//         a = a * st_meaning;
//     }
//     return a;
// }

// int Footing = ReadNumberA("Введите число А");
// int Indicator = ReadNumberB("Введите число B");
// int Meaning = AdegreeB(Footing, Indicator);
// Console.WriteLine ($"Число {Footing} в степени {Indicator} равно {Meaning}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int ReadNumber(string messege)
// {
//     Console.WriteLine(messege);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int summa(int a)
// {
//     int element = Convert.ToString(a).Length;
//     int ResultSumma = 0;
//     int remains = a;
//     for (int i = 1; i <= element; i++)
//     {
//         int result = remains % 10;
//         remains = a / 10;
//         ResultSumma = ResultSumma + result;

//     }
//     return ResultSumma;
// }

// int Number = ReadNumber("Введите число N");
// int Meaning = summa(Number);
// Console.WriteLine ($"Сумма цифр в числе {Number} равна {Meaning}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




void CompletionArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        array[i] = int.Parse(Console.ReadLine());
     }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.Write("]");
}

int[] MyArray = new int [8];
CompletionArray(MyArray);
PrintArray(MyArray);

