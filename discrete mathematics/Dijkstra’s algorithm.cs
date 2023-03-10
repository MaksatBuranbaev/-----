int s = 0, p = 0, n = int.Parse(Console.ReadLine());
double[] graph = new double[n];
double[,] path= new double[n, n];
double cheak = 0, c = 0, min_road = double.PositiveInfinity;
for(int i = 0; i < n ; i++)
{
    Console.WriteLine($"Точка {i + 1}");
    graph[i] = double.PositiveInfinity;
    for(int j = 0; j < n; j++)
    {
        Console.WriteLine("Введите дллину пути от точки, если пути нет то введите 0");
        path[i,j] = double.Parse(Console.ReadLine());
    }
}
bool flag = true;
graph[0] = 0;
while(flag)
{
    for(int i = 0; i < n ;i++)
    {
        cheak += path[s, i];
    }
    if(cheak == 0)
    {
        flag = false;
    }
    else
    {
        cheak = 0;
    }
    for (int j = 0; j < n; j++)
    {
        if ((path[s, j] != 0) && (graph[j] > path[s, j] + c))
        {
            graph[j] = path[s, j] + c;
        }
        if ((path[s, j] != 0) && (min_road > path[s, j]))
        {
            min_road = path[s, j];
        }
    }
    for (int j = 0; j < n; j++)
    {
        if (path[s, j] == min_road)
        {
            p = j;
        }
    }
    for (int j = 0; j < n; j++)
    {
        path[s, j] = 0;
    }
    s = p;
    c += min_road;
    min_road = double.PositiveInfinity;
}
for(int i = 0; i < n; i++)
{
    Console.WriteLine(graph[i]); 
}
