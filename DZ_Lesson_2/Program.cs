//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

//Console.WriteLine("Введите трехзначное число");
//int num1 = Convert.ToInt32(Console.ReadLine());
//while ( num1 < 100 || num1 >1000){
//   Console.WriteLine("Введите трехзначное число");
//   num1 = Convert.ToInt32(Console.ReadLine());
//}
//int fd2 = num1 / 10;
//int td2 = num1 % 10;
//int sd2 = fd2 % 10;

//Console.WriteLine ($"вторая цифра: {sd2}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

// вводим число, возвращаем отбивку в случае ввода двухзначного числа, запрашиваем ввод трехзначного числа.
//Console.WriteLine("Введите число");
//int num1 = Convert.ToInt32(Console.ReadLine());
//while ( num1 < 100 ){
//    Console.WriteLine("Вы ввели двухзначное число");
//    Console.WriteLine("Введите трехзначное число");
//    num1 = Convert.ToInt32(Console.ReadLine());
//}
// формируем массив.
//int[] array = new int[num1.ToString().Length];

//  for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = num1 % 10;
//                num1 /= 10;
//            }
//            Array.Reverse(array);
// // выводим 3-ю цыфру из массива.
//int fd = array [2];
//Console.WriteLine($"третяя цифра в веденном числе {fd}");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели");
int num1 = Convert.ToInt32(Console.ReadLine());
while ( num1 < 1 || num1 >7 ){
    Console.WriteLine("Такого дня недели не существует");
    Console.WriteLine("Введите номер дня недели");
    num1 = Convert.ToInt32(Console.ReadLine());
}
if (num1 < 6){
    Console.WriteLine($"Очень хотелось бы, но {num1}-й день на неделе не выходной");
}
else {
   Console.WriteLine($"Ура {num1}-й день на неделе выходной"); 
} 