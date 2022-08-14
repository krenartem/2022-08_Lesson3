// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = 1;
if (number < 1)
{
    Console.Write($"Число {number} меньше 1");
}
else
{
    Console.Write($"Кубы от 1 до {number}: 1");
    x = x + 1;
    while (x <= number)
    {
        Console.Write($", {Math.Pow(x, 3)}");
        x++ ;
    }
}
Console.WriteLine();