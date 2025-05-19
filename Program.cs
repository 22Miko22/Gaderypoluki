using Szyfry;

Console.WriteLine("Podaj tekst do zakodowania: ");
//readline zawsze zwraca string - nawet jeśli wpiszecie jedną literę
string text = Console.ReadLine();

//wywołujemy metodę statyczną klasy Cypher
string output = Cypher.Gaderypoluki(text);
//wypisujemy wynik
Console.WriteLine("Zaszyfrowany tekst: " + output);
