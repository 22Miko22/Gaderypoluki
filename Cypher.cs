using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfry
{
     class Cypher
    {
        public static string Gaderypoluki(string text)
        {
            
            text = text.ToUpper().Replace(" ", "");
            char[] charArray = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in charArray)
            {
                
                int charValue = (int)c;
                
                charValue += 3;
                
                if (charValue > 90)
                {
                    
                    charValue -= 26;
                }
                
                char result = (char)charValue;
                
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
