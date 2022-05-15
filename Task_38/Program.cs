/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] numbers = new int[5];
FillArray(numbers);
WriteArray(numbers);

Max(numbers);
Min(numbers);
int result = Max(numbers) - Min(numbers);
Console.Write("Разница между максимальным и минимальным элементом массива: " + result);

int Max(int[] array)
{
    int maxNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

int Min(int[] array)
{
    int minNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
