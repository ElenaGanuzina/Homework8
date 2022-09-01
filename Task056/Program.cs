// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int rowCount, int min, int max)
{
    int n = new Random().Next(1, 5);
    int columnCount = rowCount + n;
    int[,] array = new int[rowCount, columnCount];

    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindSumRow(int[,] matrix)
{
    int[] rowSum = new int[matrix.GetLength(0)];
    int count = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        rowSum[count] = sum;
        count++;

    }
    return rowSum;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if(index > 0) Console.Write(", ");
        Console.Write(array[index]);
    }
    Console.WriteLine("]");
}


void FindRowMinimum(int[] array)
{
    int minimum = array[0];
    int row = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < minimum) 
        {
            minimum = array[i];
            row = i;
        }
    }
    Console.WriteLine($"{row + 1} строка.");
} 

int[,] matrix = CreateMatrix(3, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[]rowSum = FindSumRow(matrix);
PrintArray(rowSum);
Console.WriteLine();
FindRowMinimum(rowSum);
Console.WriteLine();
