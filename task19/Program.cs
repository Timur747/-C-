// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int X = Convert.ToInt32(Console.ReadLine());
int X2 = X;
int Y = 1;
int Z = 0;
if (X2 >= 10000 && X2 < 100000)
{
    while (X2 > 0)
    {
        Y = X2 % 10;
        Z = Z * 10 + Y;
        X2 = X2 / 10;
    }
}
if(Z == X)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}