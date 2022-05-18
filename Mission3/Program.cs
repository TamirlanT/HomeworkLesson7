// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

double[,] array = new double[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
    for (int i = 3; i < array.GetLength(0); i++)
    {
        for (int j = 4; j < array.GetLength(1); j++)
        Console.WriteLine();
    }

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j]+ "\t");
        Console.WriteLine(); 
    }
}
PrintArray(array);
void Average(double[,] array)
{
    for (int j = 0; j < array.GetLength(1);j++)
    {
        double res = 0;
        for (int i = 0; i < array.GetLength(0);i++)
        {
            res = res + array[i,j];
        }
        Console.WriteLine($"{res/3:f}");
    }
}
Average(array);