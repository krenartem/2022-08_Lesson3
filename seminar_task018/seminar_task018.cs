// по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)
void coordinates(int number)
{
    switch (number)
    {
        case 1: Console.WriteLine($"в четверти {number} координаты: x > 0, y > 0"); break;
        case 2: Console.WriteLine($"в четверти {number} координаты: x > 0, y < 0"); break;
        case 3: Console.WriteLine($"в четверти {number} координаты: x < 0, y < 0"); break;
        case 4: Console.WriteLine($"в четверти {number} координаты: x < 0, y > 0"); break;
        default: Console.WriteLine($"введенное значение {number} не входит в диапазон от 1 до 4"); break;
    }
}
Console.Clear();
Console.WriteLine("    ^    ");
Console.WriteLine("    |    ");
Console.WriteLine("  4 | 1  ");
Console.WriteLine("    |    ");
Console.WriteLine("-------->");
Console.WriteLine("    |    ");
Console.WriteLine("  3 | 2  ");
Console.WriteLine("    |    ");
Console.WriteLine();
Console.Write("введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());
coordinates(quarter);