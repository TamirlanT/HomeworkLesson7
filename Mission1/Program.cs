// Задать 2 мерный массив m*n заполненый случайными вещественными числами

int m,n ;
Console.WriteLine("Введите количество строк(m)");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов(n)");
n = int.Parse(Console.ReadLine());
Console.WriteLine();

void CrateArray (double [,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = (new Random().NextDouble()-10) + (new Random().NextDouble() + 5) +
            (new Random().NextDouble() * 10);
        }
    }
}
void PrintArray(double [,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        Console.Write ($"{array[i,j]:f}\t");
        Console.WriteLine();
    }
}
double[,] array = new double [m,n];
CrateArray(array, -10, 10);
PrintArray(array);
