//Приветствие разных пользователей по разному

Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine( );

if(username.ToLower() == "маша")  //ToLower() - команда которая переводит все верхние регистры в нижние
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}