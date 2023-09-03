Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ирина")
{
    Console.WriteLine("Ура, это же ИРИНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
} 