int size = ReadInt("Введите размер массива: ");
int min = ReadInt("Введите минимальное число: ");
int max = ReadInt("Введите максимальное число: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");


void FillArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message) 
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
