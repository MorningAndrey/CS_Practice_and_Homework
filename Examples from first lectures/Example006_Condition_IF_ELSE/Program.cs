Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "spongebob")
{
    Console.WriteLine("Who lives in a pineapple under the sea? SpongeBob SquarePants!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}