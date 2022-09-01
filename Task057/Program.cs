// 57. Составить частотный словарь элементов двумерного массива.

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

int[] TransformMatrixIntoArray(int[,] matrix)
{
    int count = 0;
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int[] array = new int[row * column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[count] = matrix[i,j];
            count++;
        }
    }
    return array;
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
    return array;
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

void FindFrequency(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        int frequency = 0;
        
        {
            for (int j = 0; j < array.Length; j++)
            {
                if(array[j] == array[i]) frequency++;
            }
            if(i == 0 || array[i] != array[i-1]) Console.WriteLine($"{array[i]} встречается {frequency} раз."); 
        }
    
    } 
}

int[,] matrix = CreateMatrix(3, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = TransformMatrixIntoArray(matrix);
PrintArray(array);
Console.WriteLine();
int[] newArray = SortArray(array);
PrintArray(newArray);
Console.WriteLine();
FindFrequency(newArray);
