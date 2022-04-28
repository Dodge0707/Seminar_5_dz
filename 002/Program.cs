//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


Console.Write("Введите количество элементов массива -> ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[number];



FillArray(numbers);
WriteArray(numbers);
int result = Summ(numbers);
Console.WriteLine(result);


int Summ(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 > 0 || array[i] % 2 < 0)
        {
            result += array[i];
        }
    }
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