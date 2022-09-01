// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
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

int[,] ArrangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            for(int k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
                if (matrix[i,k] < matrix[i,k + 1]) 
                {
                    int temp = matrix[i,k];
                    matrix[i,k] = matrix[i,k+1];
                    matrix[i,k+1] = temp;
                }
                
            }
            
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix(3, 4, 0, 10);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
matrix = ArrangeMatrix(matrix);
Console.WriteLine("Упорядоченный массив: ");
PrintMatrix(matrix);