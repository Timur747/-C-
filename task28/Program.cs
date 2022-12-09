// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

//возвращает сумму от 1 до number
int GetProduct(int number)
{
    int Product = 1;
    for(int i = 1; i <= number; i++)
    {
        Product = Product * i;
    }
    return Product;
}

int A = ReadInt("Введите число: ");
int result = GetProduct(A);
Console.WriteLine($"Произведение чисел от 1 до {A} = {result}");