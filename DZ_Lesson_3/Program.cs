//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Console.WriteLine("Введите пятизначное число");
//int a = Convert.ToInt32(Console.ReadLine());
//while (a < 10000 && a > 99999)
//{
//    Console.WriteLine("Введите пятизначное число");
//    a = Convert.ToInt32(Console.ReadLine());
//}
//string s = a.ToString();
//char[] ar = s.ToCharArray();
//Array.Reverse(ar);
//s = new string(ar);
//int b = Convert.ToInt32(s);
// if (a == b){
//    Console.WriteLine($"{a} является полиндромом");
// }
//else {
//    Console.WriteLine($"{a} не является полиндромом");
//}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

//Console.WriteLine("Введите координаты точки A");
//Console.WriteLine("по X");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("по Y");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("по Z");
//int z = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите координаты точки B");
//Console.WriteLine("по X");
//int x1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("по Y");
//int y1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("по Z");
//int z1 = Convert.ToInt32(Console.ReadLine());

//double AB = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2) + Math.Pow(z - z1, 2));

//Console.WriteLine($"Расстояние между точками = {Math.Round(AB,2)}");

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0){
    for (int n1 = 0; n1 <= n; n1++)
    {
        double n2 = Math.Pow(n1, 2);
        Console.WriteLine($"Квадрат {n1} = {n2}");
    }
}
else{
    for (int n1 = 0; n1 >= n; n1--)
    {
        double n2 = Math.Pow(n1, 2);
        Console.WriteLine($"Квадрат {n1} = {n2}");
    } 
}