// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите координаты точек X и Y через запятую");
string[] array = Console.ReadLine().Split(", ");
int X = Convert.ToInt32(array[0]);
int Y = Convert.ToInt32(array[1]);
if(X > 0 && Y > 0)
{
    Console.WriteLine(1);
}
if(X < 0 && Y > 0)
{
    Console.WriteLine(2);
}
if(X < 0 && Y < 0)
{
    Console.WriteLine(3);
}
if(X > 0 && Y < 0)
{
    Console.WriteLine(4);
}
if(X == 0 || Y == 0)
{
    Console.WriteLine("Введите иные координаты Х или У");
}















