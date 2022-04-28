//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.Write("Введите количество элементов массива -> ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[number];



FillArray(numbers);
WriteArray(numbers);
int min = Min(numbers);
int max = Max(numbers);
int result = Otvet(min, max);
Console.WriteLine(result);


int Otvet(int x, int y)
{
    int result = 0;
    result = y -x;
    return result;
}


void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 101);
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

int Max(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array [i];
        }
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array [i];
        }
    }
    return min;
}