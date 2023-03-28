// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("input massive lenght: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    for(int k = 0; k < size; k++)
        Console.Write($"{array[k]}  ");
}

for(int j = 0; j < size; j++)
{
    if(array[j] % 2 == 00)
    count++;
}
Console.WriteLine();
Console.WriteLine($"the number of even numbers in the array = {count}");