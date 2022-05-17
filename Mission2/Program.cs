// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int m,n ;
Console.WriteLine("Введите количество строк(m)");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов(n)");
n = int.Parse(Console.ReadLine());

int line, column;
Console.WriteLine("Введите строку(line)");
line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец(column)");
column = int.Parse(Console.ReadLine());

void CreateArray(int [,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    
}
void FindIndex(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == line-1 && j == column-1)
            Console.WriteLine(array[i , j]);
        else
        if (line > array.GetLength(0) && column > array.GetLength(1))
            Console.WriteLine("Такого числа нет");
            break;
        }     
    }      
}
int [,] array = new int [m,n];
CreateArray(array, -10,10);
PrintArray(array);
FindIndex(array);