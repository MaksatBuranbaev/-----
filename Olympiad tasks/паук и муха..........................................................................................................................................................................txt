int[,] coor = new int[3,3];
double s = 0;
int[] surface = new int[2];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        coor[i, j] = int.Parse(Console.ReadLine());
    }
}

if ((coor[1, 0] == 0) && (coor[1, 1] < coor[0, 1]) && (coor[1, 2] < coor[0, 2])) { surface[0] = 1; }
else if ((coor[1, 0] == coor[0, 0]) && (coor[1, 1] < coor[0, 1]) && (coor[1, 2] < coor[0, 2])) { surface[0] = 2; }
else if (coor[1, 1] == 0) { surface[0] = 3; }
else if (coor[1, 1] == coor[0, 1]) { surface[0] = 4; }
else if (coor[1, 2] == 0) { surface[0] = 5; }
else if (coor[1, 2] == coor[0,2]) { surface[0] = 6; }

if ((coor[2, 0] == 0) && (coor[2, 1] < coor[0, 1]) && (coor[2, 2] < coor[0, 2])) { surface[1] = 1; }
else if ((coor[2, 0] == coor[0, 0]) && (coor[2, 1] < coor[0, 1]) && (coor[2, 2] < coor[0, 2])) { surface[1] = 2; }
else if (coor[2, 1] == 0) { surface[1] = 3; }
else if (coor[2, 1] == coor[0, 1]) { surface[1] = 4; }
else if (coor[2, 2] == 0) { surface[1] = 5; }
else if (coor[2, 2] == coor[0, 2]) { surface[1] = 6; }

if (surface[0] == surface[1])
{
    s = Math.Sqrt(Math.Pow(coor[1, 0] - coor[2, 0], 2) + Math.Pow(coor[1, 1] - coor[2, 1], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
}
else if ((surface[0] + surface[1] == 3) || (surface[0] + surface[1] == 7) || (surface[0] + surface[1] == 11))
{
    if (surface[0] + surface[1] == 3)
    {
        s = Math.Sqrt(Math.Pow(Math.Min(Math.Min(coor[1, 2] + coor[2, 2], coor[0, 2] - coor[1, 2] + coor[0, 2] - coor[2, 2]), Math.Min(coor[1, 1] + coor[2, 1], coor[0, 1] - coor[1, 1] + coor[0, 1] - coor[2, 1])) + coor[0, 0], 2) + Math.Pow(coor[1, 1] - coor[2, 1], 2));
    }
    else if(surface[0] + surface[1] == 7)
    {
        //s = Math.Min(Math.Sqrt(Math.Pow(Math.Min(coor[1, 2] + coor[2, 2], coor[0, 2] - coor[1, 2] + coor[0, 2] - coor[2, 2]) + coor[0, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2)), Math.Sqrt(Math.Pow(Math.Min(coor[1, 0] + coor[2, 0], coor[0, 0] - coor[1, 0] + coor[0, 0] - coor[2, 0]) + coor[0, 0], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2)));
        s = Math.Sqrt(Math.Pow(Math.Min(Math.Min(coor[1, 2] + coor[2, 2], coor[0, 2] - coor[1, 2] + coor[0, 2] - coor[2, 2]), Math.Min(coor[1, 0] + coor[2, 0], coor[0, 0] - coor[1, 0] + coor[0, 0] - coor[2, 0])) + coor[0, 1], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
    }
    else if(surface[0] + surface[1] == 11)
    {
        s = Math.Sqrt(Math.Pow(Math.Min(Math.Min(coor[1, 1] + coor[2, 1], coor[0, 1] - coor[1, 1] + coor[0, 1] - coor[2, 1]), Math.Min(coor[1, 0] + coor[2, 0], coor[0, 0] - coor[1, 0] + coor[0, 0] - coor[2, 0])) + coor[0, 2], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
    }
}
else
{
    if (surface[0] == 1)
    {
        if (surface[1] == 3)
        {
            s = Math.Sqrt(Math.Pow(coor[1,1] + coor[2,0], 2) + Math.Pow(coor[1,2] - coor[2,2], 2));
        }
        else if (surface[1] == 4)
        {
            s = Math.Sqrt(Math.Pow(coor[0,1] - coor[1, 1] + coor[2, 0], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
        }
        else if (surface[1] == 5)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 1] + coor[2, 0], 2));
        }
        else if (surface[1] == 6)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 2] - coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 1] + coor[2, 0], 2));
        }
    }
    else if(surface[0] == 2)
    {
        if (surface[1] == 3)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 1] + coor[0,0] - coor[2, 0], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
        }
        else if (surface[1] == 4)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 1] - coor[1, 1] + coor[0, 0] - coor[2, 0], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
        }
        else if (surface[1] == 5)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 1] + coor[0, 0] - coor[2, 0], 2));
        }
        else if (surface[1] == 6)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 2] - coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 1] + coor[0, 0] - coor[2, 0], 2));
        }
    }
    else if (surface[0] == 3)
    {
        if (surface[1] == 1)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 1] + coor[2, 0], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
        }
        else if (surface[1] == 2)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 1] + coor[0, 0] - coor[2, 0], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
        }
        else if (surface[1] == 5)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
        }
        else if (surface[1] == 6)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 2] -  coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
        }
    }
    else if (surface[0] == 4)
    {
        if (surface[1] == 1)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 1] - coor[1, 1] + coor[2, 0], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
        }
        else if (surface[1] == 2)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 1] - coor[1, 1] + coor[0, 0] - coor[2, 0], 2) + Math.Pow(coor[1, 2] - coor[2, 2], 2));
        }
        else if (surface[1] == 5)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 2] + coor[0, 1] - coor[2, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
        }
        else if (surface[1] == 6)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 2] - coor[1, 2] + coor[0, 1] - coor[2, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
        }
    }
    else if (surface[0] == 5)
    {
        if (surface[1] == 1)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 1] + coor[2, 0], 2));
        }
        else if (surface[1] == 2)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 1] + coor[0, 0] - coor[2, 0], 2));
        }
        else if (surface[1] == 3)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
        }
        else if (surface[1] == 4)
        {
            s = Math.Sqrt(Math.Pow(coor[1, 2] + coor[0, 1] - coor[2, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
        }
    }
    else if(surface[0] == 6)
    {
        if (surface[1] == 1)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 2] - coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 1] + coor[2, 0], 2));
        }
        else if (surface[1] == 2)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 2] - coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 1] + coor[0, 0] - coor[2, 0], 2));
        }
        else if (surface[1] == 3)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 2] - coor[1, 2] + coor[2, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
        }
        else if (surface[1] == 4)
        {
            s = Math.Sqrt(Math.Pow(coor[0, 2] - coor[1, 2] + coor[0, 1] - coor[2, 1], 2) + Math.Pow(coor[1, 0] - coor[2, 0], 2));
        }
    }
}
Console.WriteLine(s);
