// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int pow = 4;
int numberPalindrome;
if (number < 10000 ^ number > 99999)
{
    Console.WriteLine($"Число {number} не пятизначное");
}
else
{
    while (pow > 0)
    {
        numberPalindrome = numberPalindrome + number % 10 * Math.Pow(10, pow);
        number = number / 10;
    }
    Console.Writeline(numberPalindrome);
}