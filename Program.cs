using Szyfry;

Console.WriteLine("Wybierz metodę szyfrowania:  ");
Console.WriteLine("1 - Gaderypoluki");
Console.WriteLine("2 - Szyfr Caesara");

string method = Console.ReadLine();

Console.WriteLine("Podaj texst do zakodowania: ");
string text = Console.ReadLine();

string output = "";

if (method == "1")
{
  output = Cyber.Gaderypoluki(text);
}
else if (method == "2")
{
  output = Cypher.CaesarShift(text);
}
else 
{
  Console.WriteLine("Niepoprawny wybór metody. ");
}

Console.WriteLine("Zaszyfrowany tekst: " + output);
