// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Запрос числа от пользователя
//Console.WriteLine ("Введите целое число: ");
//int number = Convert.ToInt32(Console.ReadLine());

// Возведение в квадрат
//int result = number * number;

// Вывод результата
//Console.WriteLine ($"Результат возведения в квадрат = {result}");

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

//Console.WriteLine ("Введите целое число №1: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine ("Введите целое число №2: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//int x = num1 / num2;

//if(x == num2)
//{
//    Console.WriteLine($"Число {num1} является квадратом {num2}");
//}
//else
//{
//    Console.WriteLine($"Число {num1} не является квадратом {num2}");
//}

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница


// Запрос числа от пользователя
Console.WriteLine ("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1)
{
    Console.WriteLine($"Понедельник является {number} днем на неделе");
}

else if(number == 2)
{
    Console.WriteLine($"Вторник является {number} днем на неделе");
}

else if(number == 3)
{
    Console.WriteLine($"Среда является {number} днем на неделе");
}

else if(number == 4)
{
    Console.WriteLine($"Четверг является {number} днем на неделе");
}


else if(number == 5)
{
    Console.WriteLine($"Пятница является {number} днем на неделе");
}

else if(number == 6)
{
    Console.WriteLine($"Суббота является {number} днем на неделе");
}

else if(number == 7)
{
    Console.WriteLine($"Воскресенье является {number} днем на неделе");
}

else
{
    Console.WriteLine($"на неделе всего 7 дней");
}