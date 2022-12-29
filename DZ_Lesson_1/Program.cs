﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

// запрос число 1
Console.WriteLine("Задача 2: Введите число №1");
int num1 = Convert.ToInt32(Console.ReadLine());

// запрос число 2
Console.WriteLine("Задача 2: Введите число №2");
int num2 = Convert.ToInt32(Console.ReadLine());

//Алгоритм сравнения
if (num1 > num2)
{
    Console.WriteLine($"{num1} больше {num2}");
}
else if (num1 == num2)
{
   Console.WriteLine($"числа равны"); 
}
else 
{
    Console.WriteLine($"{num1} меньше {num2}");
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// Запрос числа от пользователя
Console.WriteLine("Задача 4: Введите число №1");
int num3 = Convert.ToInt32(Console.ReadLine());

// Запрос числа от пользователя
Console.WriteLine("Задача 4: Введите число №2");
int num4 = Convert.ToInt32(Console.ReadLine());

// Запрос числа от пользователя
Console.WriteLine("Задача 4: Введите число №3");
int num5 = Convert.ToInt32(Console.ReadLine());

// Поиск максимального значения
if (num3 > num4 && num3 > num5)
{
    Console.WriteLine($"{num3} самое большое число");
}
else if (num5 > num4 ) 
{
     Console.WriteLine($"{num5} самое большое число");
}
else
{
    Console.WriteLine($"{num4} самое большое число");
}


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//Запрос ввода числа от пользователя
Console.WriteLine("Задача 6: Введите число");
int num6 = Convert.ToInt32(Console.ReadLine());

// Проверка на четность нечотность
int b = num6 % 2;

if (b == 0)
{
    Console.WriteLine($"{num6} четное число");
}
else 
{
    Console.WriteLine($"{num6} нечетное число");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

// Запрашиваем число у пользователя
Console.WriteLine("Задача 8: Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

// счетчик до введенного числа
for (int i = 1; i <= N; i++) {
    // отбираем четные и выводим на экран
    int a = i % 2;
    if (a == 0){
        Console.WriteLine($"{i} ");
    }
    
}