Console.Write("Enter the user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Wow! This is Masha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}