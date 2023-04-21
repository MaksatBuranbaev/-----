Operation Min = (double x, double y, double z) =>
{ double min;
    if (x < y && x < z) { min = x; }
    else if (y < x && y < z) { min = y; }
    else { min = z; }
    return min;
 };

Operation Max = (double x, double y, double z) =>
{
    double max;
    if (x > y && x > z) { max = x; }
    else if (y > x && y > z) { max = y; }
    else { max = z; }
    return max;
};

Operation Sum = (double x, double y, double z) => x + y + z;

Operation Product = (double x, double y, double z) => x * y * z;

Operation Average = (double x, double y, double z) => (x + y + z) / 3;

Operation operation;


while (true)
{
    Console.WriteLine("1.Минимальное число \n2.Максимальное число \n3.Сумма \n4.Произведение \n5.Среднее арифметическое \n6.Выход");
    string key = Console.ReadLine();
    Console.Clear();

    if (key == "1")
    {
        operation = Min;
        Console.WriteLine("Введите 3 числа");
        Console.WriteLine(operation(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    else if (key == "2")
    {
        operation = Max;
        Console.WriteLine("Введите 3 числа");
        Console.WriteLine(operation(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    else if (key == "3")
    {
        operation = Sum;
        Console.WriteLine("Введите 3 числа");
        Console.WriteLine(operation(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    else if (key == "4")
    {
        operation = Product;
        Console.WriteLine("Введите 3 числа");
        Console.WriteLine(operation(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }
    
    else if(key == "5") 
    {
        operation = Average;
        Console.WriteLine("Введите 3 числа");
        Console.WriteLine(operation(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }
    
    else if(key == "6")
    {
        break;
    }
    
    else
    {
        Console.WriteLine("Неизвестаная команда");
        break;
    }

    Console.WriteLine("Нажмите любую клавишу");
    Console.ReadLine();
    Console.Clear();
}


delegate double Operation(double x, double y, double z);
