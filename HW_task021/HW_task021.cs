// принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Введите 3D координаты первой точки:");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3D координаты второй точки:");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double range = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 2);
Console.WriteLine($"Расстояние между точками 1 и 2 = {range}");