// принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
void Distance(int a1, int b1, int a2, int b2)
{
    double cathet1 = a1 - a2;
    double cathet2 = b1 - b2;
    cathet1 = Math.Pow(cathet1, 2);
    cathet2 = Math.Pow(cathet2, 2);
    double hypotenuse = cathet1 + cathet2;
    hypotenuse = Math.Round(Math.Sqrt(hypotenuse), 2);
    Console.WriteLine($"Расстояние между точками = {hypotenuse}");
    }
Console.Clear();
Console.WriteLine("Введите координаты (X,Y) первой точки:");
Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты (X,Y) второй точки:");
Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine());
Distance(x1, y1, x2, y2);