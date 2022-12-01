void FillArrayRandom(int[,] array, int line, int column) // заполенение двумерного массива
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

void SortingMin(int[,] array, int line, int column) // сортировка по убыванию
{
    int num = 0;

    for (int i = 0; i < line; i++)
    {
        for (int k = 0; k < array.Length; k++ )
        {
            for (int j = 0; j < column - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    num = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = num;
                }
            }
        }
    }
}

Console.WriteLine("Введите колличество строк в массиве:");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[line, column];

FillArrayRandom(array, line, column);
PrintArray(array, line, column);
SortingMin(array, line, column);
PrintArray(array, line, column);

