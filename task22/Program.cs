// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
              //a = a + 1
Console.WriteLine($"Таблица квадратов от числа 1 до числа {N}:");
for(;a <= N; a++)
{
    Console.WriteLine($"{a * a}");
}
