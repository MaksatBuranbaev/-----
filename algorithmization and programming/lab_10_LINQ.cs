using System;
using System.Linq;

int[] numbers = new[] {1, 2, 3, 0, -3, -2, -1 };

Console.Write("Массив: ");
for (int i = 0; i < numbers.Length; i++) { Console.Write(numbers[i] + " "); }
Console.WriteLine();

var new_numbers = from n in numbers
                  where n > 0
                  select n;
int count = 0;

foreach(var n in new_numbers)
{
    count += n;
}
Console.WriteLine($"Сумма положительных чисел: {count}");


new_numbers = from n in numbers
                  where n != 0
                  select n;
count = 1;

foreach (var n in new_numbers)
{
    count *= n;
}
Console.WriteLine($"Произведение ненулевых чисел: {count}");


new_numbers = from n in numbers
                 where n % 2 == 0
                 select n;
count = 0;

foreach (var n in new_numbers)
{
    count++;
}
Console.WriteLine($"Количество четных чисел: {count}");


int[] numbers2 = new int[numbers.Length/2 + numbers.Length % 2];

for(int i = 0, j = 0; i < numbers.Length;i++)
{
    if (i % 2 == 0) { numbers2[j] = numbers[i]; j++; };
}

Console.Write("Массив после удаления нечетных элементов: ");
for (int i = 0;i < numbers2.Length; i++) { Console.Write(numbers2[i] + " "); }
Console.WriteLine();


new_numbers = from n in numbers2
                  where n > 0
                  select n;
count = 0;

foreach (var n in new_numbers)
{
    count += n;
}
Console.WriteLine($"Сумма положительных чисел: {count}");


new_numbers = from n in numbers2
              where n != 0
              select n;
count = 1;

foreach (var n in new_numbers)
{
    count *= n;
}
Console.WriteLine($"Произведение ненулевых чисел: {count}");


new_numbers = from n in numbers2
              where n % 2 == 0
              select n;
count = 0;

foreach (var n in new_numbers)
{
    count++;
}
Console.WriteLine($"Количество четных чисел: {count}");
