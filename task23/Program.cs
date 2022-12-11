// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.WriteLine($"Таблица кубов от числа 1 до числа {N}:");
for(; a <= N; a++)
{
    Console.WriteLine($"{a * a * a}");
}