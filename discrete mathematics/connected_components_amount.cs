Console.WriteLine("Введите кол-во вершин:");
int n = int.Parse(Console.ReadLine());

double[,] graphs = new double[n, n];
bool[] cheak = new bool[n];


for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Строка {i + 1}");
    string[] str = Console.ReadLine().Split();
    for (int j = 0; j < n; j++)
    {
        graphs[i, j] = int.Parse(str[j]);
        if (graphs[i, j] == 0)
        {
            graphs[i, j] = double.PositiveInfinity;
        }
    }
}


for (int k = 0; k < n; k++)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (graphs[i, k] + graphs[k, j] == 2)
                graphs[i, j] = 1;
        }
    }
}


int count = 0;
for (int i = 0; i < n; i++)
{
    if (!cheak[i])
    {
        count++;
        cheak[i] = true;
        for (int j = 0; j < n; j++)
        {
            if (graphs[i, j] == 1 && !cheak[j])
                cheak[j] = true;
        }
    }
}

Console.WriteLine(count);
