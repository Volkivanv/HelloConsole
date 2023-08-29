Console.WriteLine("Введите имя пользователя!");
string username = Console.ReadLine();

if(username.ToLower() == "Masha"){
    Console.WriteLine("Hurra, this is Masha!");

} else {
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
