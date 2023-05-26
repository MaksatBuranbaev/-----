MyEvent evt = new MyEvent();
string key;

while(true)
{
    Console.WriteLine("Меню \n\n1.Сложение \n2.Вычитание \n3.Умножение \n4.Деление \n5.Выход");
    key = Console.ReadLine();
    Console.Clear();

    if(key == "1")
    {
        Console.WriteLine("Введите 2 числа");
        evt.filling();
        evt.Operation += Calculator.addition;
    }

    else if (key == "2")
    {
        Console.WriteLine("Введите 2 числа");
        evt.filling();
        evt.Operation += Calculator.subtraction;
    }

    else if (key == "3")
    {
        Console.WriteLine("Введите 2 числа");
        evt.filling();
        evt.Operation += Calculator.multiplication;
    }

    else if (key == "4")
    {
        Console.WriteLine("Введите 2 числа");
        evt.filling();
        evt.Operation += Calculator.division;
    }

    else if (key == "5")
    {
        break;
    }

    else
    {
        Console.WriteLine("Неизвестная команда");
    }

    evt.OnOperation();
    Console.WriteLine("Нажмите любую клавишу");
    Console.ReadLine();
    Console.Clear();
}

delegate double MyEventHandler(double a, double b);
class MyEvent
{
    double a, b;
    public void filling()
    {
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
    }
    public event MyEventHandler Operation;
    public void OnOperation()
    {
        if (Operation != null) { Console.WriteLine(Operation(a, b)); };
    }
}
class Calculator
{
    public static double addition(double a, double b)
    {
        return a + b;
    }
    public static double subtraction(double a, double b)
    {
        return a - b;
    }
    public static double multiplication(double a, double b)
    {
        return a * b;
    }
    public static double division(double a, double b)
    {
        return a / b;
    }
}

