// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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
            Console.Write($"{arr[row, column]}  ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if(matrix1.GetLength(1) != matrix2.GetLength(0)) 
    {
        Console.WriteLine("Перемножение матриц невозможно.");
        return newMatrix;
        } 
    
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                newMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
        
    return newMatrix;   
}



int[,] matrix1 = CreateMatrix(2, 2, 0, 10);
int[,] matrix2 = CreateMatrix(2, 2, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] newMatrix = MultiplyMatrixes(matrix1, matrix2);
Console.WriteLine("Результат умножения двух матриц: ");
PrintMatrix(newMatrix);
Console.WriteLine();

int[,] arr1 = CreateMatrix(2, 2, 0, 10);
int[,] arr2 = CreateMatrix(4, 2, 0, 10);
PrintMatrix(arr1);
Console.WriteLine();
PrintMatrix(arr2);
Console.WriteLine();
int[,] newArr = MultiplyMatrixes(arr1, arr2);
Console.WriteLine("Результат умножения двух матриц: ");
PrintMatrix(newArr);
