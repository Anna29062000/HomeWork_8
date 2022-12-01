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

int GetLineMin(int[,] array, int line, int column) // нахождение строки, в которой сумма элеметов минимальна
{
    int sum = 0;
    int[] ArraySum = new int[line];

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sum = sum + array[i, j];
        }
        
        ArraySum[i] = sum;
        sum = 0;
    }

    int num = ArraySum[1];
    int min = 0;

    for (int k = 0; k < line; k++)
    {
        if (num > ArraySum[k])
        {
            min = k;
            num = ArraySum[k];
        } 
    }

    return min;
}

Console.WriteLine("Введите колличество строк в массиве:");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[line, column];
int min = 0;

FillArrayRandom(array, line, column);
PrintArray(array, line, column);
min = GetLineMin(array, line, column);

Console.WriteLine($"Минимальная сумма элемтов в строке № {min + 1}");