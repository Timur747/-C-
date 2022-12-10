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
int B = 0;
int C = 0;
int D = 0;
int E = 0;
if (X2 >= 10000 && X2 < 100000)
{
    while (X2 > 0)
    {
        if (X2 > 9999 && X2 < 100000)
        {
            Y = X2 % 10;
            Z = Y;
            X2 = X2 / 10;
        }
        if (X2 > 999 && X2 < 10000)
        {
            Y = X2 % 10;
            B = Z * 10 + Y;
            X2 = X2 / 10;
        }
        if (X2 > 99 && X2 < 1000)
        {
            Y = X2 % 10;
            C = B * 10 + Y;
            X2 = X2 / 10;
        }
        if (X2 > 9 && X2 < 100)
        {
            Y = X2 % 10;
            D = C * 10 + Y;
            X2 = X2 / 10;
        } 
        if (X2 <= 9)
        {
            Y = X2 % 10;
            E = D * 10 + Y;
            X2 = X2 / 10;
        }
    }
}
if(E == X)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}