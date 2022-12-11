// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А через запятую");
string[] arrayA = Console.ReadLine().Split(",");
int A1 = Convert.ToInt32(arrayA[0]);
int A2 = Convert.ToInt32(arrayA[1]);
int A3 = Convert.ToInt32(arrayA[2]);
Console.WriteLine("Введите координаты точки B через запятую");
string[] arrayB = Console.ReadLine().Split(",");
int B1 = Convert.ToInt32(arrayB[0]);
int B2 = Convert.ToInt32(arrayB[1]);
int B3 = Convert.ToInt32(arrayB[2]);
double AB = Math.Sqrt(Math.Pow(B1 - A1, 2) + Math.Pow(B2 - A2, 2) + Math.Pow(B3 - A3, 2));
Console.WriteLine($"{AB:f2}");