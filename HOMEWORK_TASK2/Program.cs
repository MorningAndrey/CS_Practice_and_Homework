Console.Write("Введите первое целое число: ");
string input1 = Console.ReadLine() ??"";
int a = int.Parse(input1);

Console.Write("Введите второе целое число: ");
string input2 = Console.ReadLine() ??"";
int b = int.Parse(input2);

//можно решить задачу через метод Math.Max():
//int result = Math.Max(a,b);  
//Console.WriteLine($"Максимальным числом является число {result}");
// или просто через ветвление:

int max = a;
if(a < b)
{
    max = b;
}
Console.WriteLine($"Максимальным числом является число {max}");