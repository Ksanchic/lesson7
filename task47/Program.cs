//  задать двумерный массив (вручную) размером  m*n,
//заполненный вещественными числами

Console.WriteLine("Введите количество строк маccива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите элементы массива согласно количеству строк и столбцов через пробел:");
double[,] Array2d = new double[m,n];
string[] str_arr;

for (int i = 0; i < m; i++)
{
    str_arr = (Console.ReadLine()).Split(' ');
    for (int j = 0; j < n; j++)
    {
        Array2d[i,j] = Convert.ToDouble(str_arr[j]);
    }     
}
Console.WriteLine("Полученный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(Array2d[i, j] + "\t");
    } 
        Console.WriteLine("\n");
    
}