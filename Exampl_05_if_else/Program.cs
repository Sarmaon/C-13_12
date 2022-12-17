Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "лена")
{
    Console.WriteLine("Привет, я так долго тебя ждал!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}