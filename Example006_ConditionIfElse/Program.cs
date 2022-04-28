Console.Write("Введите Ваше имя:   ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("УРА ЭТОЖЕ МАША");
}
else
{
    Console.Write("Привет,   ");
    Console.WriteLine(username);
}
