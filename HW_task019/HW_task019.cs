// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberFirst = number;
int pow = 4;
double numberPalindrome = 0;
if (number < 10000 ^ number > 99999)
{
    Console.WriteLine($"Число {number} не пятизначное");
}
else
{
    while (pow > -1)
    {
        numberPalindrome = numberPalindrome + number % 10 * Math.Pow(10, pow);
        number = number / 10;
        pow = pow - 1;
    }
    if (numberFirst==numberPalindrome)
    {
        Console.WriteLine($"УРА! Число {numberFirst} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Жаль, но число {numberFirst} не палиндром");
    }
}