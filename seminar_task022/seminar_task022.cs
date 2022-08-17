// принимает на вход число N и выдает таблицу квадратов чисел от 1 до N
void Square(int a)
{
    int aSquared = a * a;
    Console.Write($"{aSquared} ");
}
int N = new Random().Next(1, 100);
Console.WriteLine($"для случайного числа {N} квадраты целых чисел от 1 до {N}:");
int i = 1;
// while (i <= N)
// {
//     Square(i);
//     i++;
// }
// Console.WriteLine();
for (i = 1; i <= N; i++)
{
    Square(i);
}
Console.WriteLine();