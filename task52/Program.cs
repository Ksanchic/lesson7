// Задайте двумерный массив из целых чисел (вручную). Найдите среднее арифметическое элементов 
// в каждом столбце.

Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");
int[,] arr = new int[m,n];
string[] str_arr;

for (int i = 0; i < m; i++)
{
    
    str_arr = (Console.ReadLine()).Split(' ');
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = Convert.ToInt32(str_arr[j]);
    }     
}
Console.WriteLine("Среднее арифметическое столбцов:");
Console.WriteLine("---------------------------");

for (int j = 0; j < arr.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();