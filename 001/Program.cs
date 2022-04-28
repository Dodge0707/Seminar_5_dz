Console.Write("Введите количество элементов массива -> ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[number];

FillArray(numbers);
WriteArray(numbers);
int result = Kolvo(numbers);
Console.WriteLine(result);

int Kolvo(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}



void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
