//Console.WriteLine("Введите значение Х");
//int x = Convert.ToInt32(Console.ReadLine());
//while ( x == 0){
//   Console.WriteLine("Введите Х не равный нулю");
//   x = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Введите значение Y");
//int y = Convert.ToInt32(Console.ReadLine());
//while ( y == 0){
//   Console.WriteLine("Введите Y не равный нулю");
//   y = Convert.ToInt32(Console.ReadLine());
//}
//if (x > 0 && y > 0){
//    Console.WriteLine("точка находится во 2-й четверти");
//}
//else if (x < 0 && y > 0){
//    Console.WriteLine("точка находится в 1-й четверти");
//}
//else if (x > 0 && y < 0){
//    Console.WriteLine("точка находится в 3-й четверти");
//}
//else if (x < 0 && y < 0){
//    Console.WriteLine("точка находится в 4-й четверти");
//}


//Console.WriteLine("Введите значение четверти");
//int quarter = Convert.ToInt32(Console.ReadLine());
//while ( quarter > 4 || quarter <1){
//   Console.WriteLine("значение четверти некорректно, введите знгачение четверти");
//   quarter = Convert.ToInt32(Console.ReadLine());
//}

//if (quarter == 1){
//    Console.WriteLine("значение X от - бесконечности до 0, значение Y от 0 до + бесконечности");
//}
//if (quarter == 2){
//    Console.WriteLine("значение X от 0 до + бесконечности, значение Y от 0 до + бесконечности");
//}

//if (quarter == 3){
//    Console.WriteLine("значение X от 0 до + бесконечности, значение Y от - бесконечности до 0");
//}
//if (quarter == 4){
//    Console.WriteLine("значение X от - бесконечности до 0, значение Y от - бесконечности до 0");
//}

// Задача № и21; Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координаты точки A");
Console.WriteLine("по X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("по Y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.WriteLine("по X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("по Y");
int y1 = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));

Console.WriteLine($"Расстояние между точками = {Math.Round(AB,2)}");


 //√(xb - xa)2 + (yb - ya)2
