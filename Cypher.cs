using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaderypoluki
{
     class Cypher
    {
        public static string Gaderypoluki(string text)
        {
            //zamieniamy na duże litery i usuwamy spacje - chainowanie metod
            text = text.ToUpper().Replace(" ", "");
            char[] charArray = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in charArray)
            {
                //jesli wpisano literę pomiedzy A a Z to jej wartośc liczbowa wynosi pomiędzy 65 a 90
                //wyciągamy wartość liczbową poprzez jawne rzutowanie na int
                int charValue = (int)c;
                //dodajemy wartość "klucza" - 3
                charValue += 3;
                //sprawdzamy czy wynik mieści się w zakresie dużych liter alfabetu łacińskiego
                if (charValue > 90)
                {
                    //jeśli nie to odejmujemy 26 żeby "przewinąć do początku alfabetu"
                    charValue -= 26;
                }
                //konwertujemy wartość liczbową na znak
                char result = (char)charValue;
                //dodajemy znak do wyniku
                output += result;
            }
            return output;
        }
        public static string DictionaryCaesar(string text)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('A', 'D');
            dict.Add('B', 'E');
            dict.Add('C', 'F');
            dict.Add('D', 'E');
            dict.Add('E', 'H');
            dict.Add('F', 'I');
            dict.Add('G', 'A');
            dict.Add('H', 'K');
            dict.Add('I', 'L');
            dict.Add('J', 'M');
            dict.Add('K', 'I');
            dict.Add('L', 'U');
            dict.Add('M', 'P');
            dict.Add('N', 'Q');
            dict.Add('O', 'R');
            dict.Add('P', 'O');
            dict.Add('Q', 'T');
            dict.Add('R', 'Y');
            dict.Add('S', 'V');
            dict.Add('T', 'W');
            dict.Add('U', 'X');
            dict.Add('V', 'Y');
            dict.Add('W', 'Z');
            dict.Add('X', 'A');
            dict.Add('Y', 'B');
            dict.Add('Z', 'C');
            text = text.ToUpper().Replace(" ", "");
            char[] charArray = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in charArray)
            {
                output += dict[c];
            }
            return output;
        }
    }
}
