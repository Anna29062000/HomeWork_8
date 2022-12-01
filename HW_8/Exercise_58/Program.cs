void FillArrayRandom(int[,] array, int line, int column) // заполенение двумерного массива
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    } 
}

void PrintArray(int[,] array, int line, int column) // вывод двумерного массива
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите колличество строк в первой матрице:");
int line1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в первой матрице");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество строк во второй матрице:");
int line2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов во второй матрице");
int column2 = Convert.ToInt32(Console.ReadLine());

if (line1 != column2)
{
    Console.WriteLine("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы");
}
else
{
    int[,] matrix1 = new int[line1, column1];
    int[,] matrix2 = new int[line2, column2];

    FillArrayRandom(matrix1, line1, column1);
    PrintArray(matrix1, line1, column1);
    FillArrayRandom(matrix2, line2, column2);
    PrintArray(matrix2, line2, column2);
    
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix3[i, j]}  ");
        }
        Console.WriteLine();
    }
}
