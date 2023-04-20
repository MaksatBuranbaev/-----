DoubleMod a = IMath.addition;
DoubleMod b = IMath.subtraction;
DoubleMod c = IMath.multiplication;
DoubleMod d = IMath.division;


while (true)
{
    Console.WriteLine("1.Сложение \n2.Вычитание \n3.Умножение \n4.Деление \n5.Выход");
    string key = Console.ReadLine();
    Console.Clear();

    if(key == "1")
    {
        Console.WriteLine("Введите 2 числа");
        Console.WriteLine(a(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    else if (key == "2")
    {
        Console.WriteLine("Введите 2 числа");
        Console.WriteLine(b(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    else if (key == "3")
    {
        Console.WriteLine("Введите 2 числа");
        Console.WriteLine(c(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    else if (key == "4")
    {
        Console.WriteLine("Введите 2 числа");
        Console.WriteLine(d(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    else
    {
        break;
    }

    Console.WriteLine("Нажмите любую клавишу");
    Console.ReadLine();
    Console.Clear();
}


delegate double DoubleMod(double x, double y);

interface IMath
{
    static double addition(double x, double y)
    {
        Console.WriteLine("Сложение");
        return x + y;
    }

    static double subtraction(double x, double y)
    {
        Console.WriteLine("Вычитание");
        return x - y;
    }

    static double multiplication(double x, double y)
    {
        Console.WriteLine("Умножение");
        return x * y;
    }

    static double division(double x, double y)
    {
        Console.WriteLine("Деление");
        return x / y;
    }
}





