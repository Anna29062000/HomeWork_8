int line = 4;
int column = 4;
int n = 0;
int m = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = column;

int[,] matrix = new int[line, column];
 
for (int i = 0; i < matrix.Length; i++) 
{
    matrix[n, m] = i + 1;
    if (--visits == 0) 
    {
        visits = column * (dirChanges %2) + line * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
 
    m += dx;
    n += dy;
}

for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {   
            if (matrix[i, j] < 10) 
            {
                Console.Write($"0{matrix[i, j]}  ");
            }
            else
            {
                Console.Write($"{matrix[i, j]}  "); 
            }
        }
        Console.WriteLine();
        
    }
