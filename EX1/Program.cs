Console.Write($"Введите любое целое число от 1 до 7: ");
string input = Console.ReadLine() ??"";

int number = int.Parse(input);

if (number == 1) 
{
    Console.WriteLine("Monday");
}
else if(number == 2)
{
    Console.WriteLine("Tuesday");
}
else if(number == 3)
{
    Console.WriteLine("Wednesday"); 
} 
else if(number == 4)
{
    Console.WriteLine("Thirsday"); 
} 
else if(number == 5)
{
    Console.WriteLine("Friday");
} 
else if(number == 6) 
{
    Console.WriteLine("Satturday"); 
} 
else if(number == 7)
{
    Console.WriteLine("Sunday"); 
}

