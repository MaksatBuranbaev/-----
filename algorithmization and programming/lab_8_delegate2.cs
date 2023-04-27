using System.Collections;


d_1 dw = Washing.car_wash;
d_2 dw2 = Washing.car_wash;
Garage garage = new Garage();
Automobile n1 = new Automobile("Lexus", 1);
Automobile n2 = new Automobile("BMW", 2);
Automobile n3 = new Automobile("MITSUBISHI", 3);
Garage.Add(n1); Garage.Add(n2); Garage.Add(n3);

//Пример
Console.WriteLine($"{n1.purity}, {n1.purity}, {n3.purity}");
dw2(Garage.cars);
Console.WriteLine($"{n1.purity}, {n1.purity}, {n3.purity}");


class Automobile
{
    public Automobile(string br, double num) { brand = br; number = num; }
    public string brand;
    public double number;
    public bool purity = false;
}


class Garage
{
    public static void Add(Automobile c)
    {
        cars.Add(c);
    }

    public static void Remove(Automobile c)
    {
        cars.Remove(c);
    }

    public static void indRemove(int index)
    {
        cars.RemoveAt(index);
    }

    public static ArrayList cars = new ArrayList();
}


class Washing
{
    public static void car_wash(Automobile c)
    {
        c.purity = true;
    }

    public static void car_wash(ArrayList cars)
    {
        foreach(Automobile i in cars)
        {
            i.purity = true;
        }
    }
}


delegate void d_1(Automobile car);
delegate void d_2(ArrayList cars);
