Console.Write("Введите имя пользователя");

string username = Console.ReadLine();

if(username.ToLower() == "Masha")
{
    Console.WriteLine("Ura eto zhe Masha");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}