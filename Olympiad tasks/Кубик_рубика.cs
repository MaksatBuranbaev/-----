int[] n = new int[5];
string[,] s = new string[3,3];
for(int i = 0; i < 5; i++)
{
    n[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n[1]; i++)
{
    for(int j = 0; j < 3; j++)
    {
        s[i,j] = Console.ReadLine();
    }
}
int size = n[0]; 
int[,,] matrix = new int[size,size,size];
matrix[n[4] - 1, n[3] - 1, n[2] - 1] = 1;

for (int v = 0; v < n[1]; v++)
{
    if (int.Parse(s[v, 2]) == 1)
    {
        matrix = Rotate(matrix, s[v, 0], s[v, 1]);
        matrix = Rotate(matrix, s[v, 0], s[v, 1]);
        matrix = Rotate(matrix, s[v, 0], s[v, 1]);
    }
    else if(int.Parse(s[v, 2]) == -1)
    {
        matrix = Rotate(matrix, s[v, 0], s[v, 1]);
    }
   
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            if (matrix[i,j,k] == 1) 
            {
                Console.WriteLine($"{j + 1} {k + 1} {i + 1}");
            }
        }
    }
}

int[,,] Rotate(int[,,] matrix, string A, string K)
{
    int iK = int.Parse(K) - 1;
    int[,,] result = new int[matrix.GetLength(0), matrix.GetLength(0), matrix.GetLength(0)];
    Array.Copy(matrix, result, matrix.Length);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if(A == "X")
            {
                result[i, j, iK] = matrix[matrix.GetLength(0) - 1 - j, i, iK];
                
            }
            else if (A == "Y")
            {
                result[i, iK, j] = matrix[matrix.GetLength(0) - 1 - j, iK, i];
            }
            else if (A == "Z")
            {
                result[iK, i, j] = matrix[iK, matrix.GetLength(0) - 1 - j, i];
            }
        }
    }
    return result;
}



