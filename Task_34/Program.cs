/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] numbers = new int[4];
FillArray(numbers);
WriteArray(numbers);

int countNumbers = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)  
    {
        countNumbers = countNumbers + 1;
    }      
}
Console.Write("Количество четных чисел в массиве: " + countNumbers);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
