﻿// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > b)
{
    max = a;
}
else
{
    if(c >= b)
    {
        max = c;
    }
    else
    {
        max = b;
    }
}
Console.WriteLine(max);