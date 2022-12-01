void FillArrayRandom(int[,,] array, int m, int n, int z) // заполенение трехмерного массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    } 
}

void PrintArray(int[,,] array, int m, int n, int z) // вывод трехмерного массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            
            Console.WriteLine();
        }
    }   
}

Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[m, n, z];

FillArrayRandom(array, m, n, z);
PrintArray(array, m, n, z);
