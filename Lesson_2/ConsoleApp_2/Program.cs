//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Например:
//78 -> 8
//12-> 2
//85 -> 8

// Случайное число
//int number = new Random().Next(10, 100);

//int fd = number / 10;
//int sd = number % 10; 

//Console.WriteLine ($"Случайное число {number}");

//if (fd > sd){
//    Console.WriteLine ($"Наибольшая цифра числа {number}: {fd}");
//}
//if (fd < sd){
//    Console.WriteLine ($"Наибольшая цифра числа {number}: {sd}");
//}

//if (fd == sd){
//    Console.WriteLine ($"Наибольшая цифра числа {number}: отсутствует, так как {fd} и {sd} равны");
//}

////Задача №11 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 720
//918 -> 98

// Случайное число
//int number2 = new Random().Next(100, 1000);

//int fd2 = number2 / 10;
//int td2 = number2 % 10;
//int sd2 = fd2 % 10;
//int x = fd2 - sd2;
//int anser = x + td2;

//Console.WriteLine ($"Случайное число {number2}, ответ: {anser}");

//Задача №12, Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

//Console.WriteLine("Введите число №1");
//int num1 =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число №2");
//int num2 =Convert.ToInt32(Console.ReadLine());

//int num3 = num1 % num2;

//if (num3 == 0){
//    Console.WriteLine($"{num2} кратно {num1}");
//}
//else{
//    Console.WriteLine($"{num2} не кратно {num1}, остаток от деления {num3}");
//}

//Задача №3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//Например 14 -> нет 
//46 -> нет 
//161 -> да

//Console.WriteLine("Введите число");
//int num1 = Convert.ToInt32(Console.ReadLine());
//while ( num1 == 0){
//   Console.WriteLine("на ноль делить нельзя");
//   Console.WriteLine("Введите число");
//   num1 = Convert.ToInt32(Console.ReadLine()); 
//}

//if (num1 % 7 == 0 && num1 % 23 == 0){
//    Console.WriteLine($"{num1} кратно 7 и 23");
//}
//else{
//    Console.WriteLine($"{num1}  не кратно 7 и 23");
//}

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

//Console.WriteLine("Введите число №1");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число №2");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (Math.Sqrt(num1) == num2){
//    Console.WriteLine($"{num2} является квадратом {num1}");
//}
//else{
//    Console.WriteLine($"{num2} не является квадратом {num1}");
//}

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число");
        int a = Convert.ToInt32(Console.ReadLine());
        while (a < 10000 && a > 99999)
        {
            Console.WriteLine("Введите пятизначное число");
            a = Convert.ToInt32(Console.ReadLine());
        }
        string s = a.ToString();
        char[] ar = s.ToCharArray();
        Array.Reverse(ar);
        s = new string(ar);
        int d = Convert.ToInt32(s);
        Console.WriteLine($"{a} не является {d}");
    }
}