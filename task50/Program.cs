//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Write("Введите строку: ");
int poz1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int poz2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] array2d = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
{
    array2d[i, j] = random.Next(10, 99);
Console.Write("{0} ", array2d[i, j]);
}
Console.WriteLine();
}
    if (poz1 < 0 | poz1 > array2d.GetLength(0) - 1 | poz2 < 0 | poz2 > array2d.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", array2d[poz1, poz2]);
}
Console.ReadLine();