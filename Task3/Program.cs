// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("input massive lenght: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

FillArray(array);
PrintArray(array);
double max = array[0];
double min = array[0];

void FillArray(double[] array)
{
    for(int i = 0; i < size; i++)
    {
        double a = new Random().Next(-999, 1000);
        double b = new Random().Next(-99, 100);
        double c = Math.Round(a / b, 2, MidpointRounding.AwayFromZero);
        //Console.WriteLine($"{a}, {b}, {c}");
        array[i] = c;
    }
}
void PrintArray(double[] array)
{
    for(int k = 0; k < size; k++)
        Console.Write($"{array[k]}  ");
}

for(int j = 1; j < size; j++)
{
    if(array[j] > max)
        max = array[j];
    if(array[j] < min)
        min = array[j];
}
double diff = Math.Round(max - min, 2, MidpointRounding.AwayFromZero); ;
Console.WriteLine();
Console.WriteLine($"the difference between the maximum and minimum array elements = {diff}");
