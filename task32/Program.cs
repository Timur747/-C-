// Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

void ChangePosNeg(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1; //поменять положительный элемент на отрицательный
    }
}

const int LENGTH = 10;
const int LEFTRANGE = -10;
const int RIGHTRANGE = 10;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
ChangePosNeg(massive);
Console.WriteLine($"{string.Join(", ", massive)}");