// Функции: 1. заполнения массива случайными элементами;
// 2. Вывода значений всех элементов массива в терминал;
// 3. Нахождения индекса нужного нам элемента.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
