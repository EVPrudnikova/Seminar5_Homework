/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] numbers = new int[8];
FillArray(numbers);
WriteArray(numbers);

int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    int ostatok = i % 2;
    if(ostatok == 1)  
    {
        sum = sum + numbers[i];
    }      
}
Console.Write("Сумма элементов, стоящих на нечетных позициях: " + sum);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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
