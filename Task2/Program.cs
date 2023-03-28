//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("input massive lenght: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    for(int k = 0; k < size; k++)
        Console.Write($"{array[k]}  ");
}

for(int j = 1; j < size; j++)
{
    if( j % 2 != 0)
        sum += array[j];
}
Console.WriteLine();
Console.WriteLine($"the sum of the elements in odd positions of array = {sum}");