// Задача 14: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int x = 7;
int c = 23;
if(a % x == 0 && a % c == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}