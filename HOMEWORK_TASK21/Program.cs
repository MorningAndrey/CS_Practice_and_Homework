Console.Clear();

Console.WriteLine("Введите координаты точки А: ");
Console.Write("X1: ");
int X1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Y1: ");
int Y1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Z1: ");
int Z1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X2: ");
int X2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Y2: ");
int Y2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Z2: ");
int Z2 = int.Parse(Console.ReadLine() ?? "");

double distance = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
double result = Math.Round(distance, 2);
Console.Write($"Расстояние в пространстве между двумя точками A({X1}, {Y1}, {Z1});  B({X2}, {Y2}, {Z2}) -> {result}");