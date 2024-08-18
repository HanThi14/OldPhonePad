using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePad
{
    public static class HandlingOldPhonePad
    {
        public static String OldPhonePad(string input)
        {
            
            Dictionary<char, string> keypad = new Dictionary<char, string>()
            {
                {'1', "&'("},   
                {'2', "ABC"},
                {'3', "DEF"},
                {'4', "GHI"},
                {'5', "JKL"},
                {'6', "MNO"},
                {'7', "PQRS"},
                {'8', "TUV"},
                {'9', "WXYZ"},
                {'0', " "},
            };       


            StringBuilder sb = new StringBuilder();          

            if(input.Contains('#'))
            {
                int index = 0;
                while (index < input.Length)
                {
                    char currentKey = input[index];

                    if (currentKey == '#')
                    {
                        break; // End of input
                    }
                    else if (currentKey == '*')
                    {
                        // Handle backspace
                        if (sb.Length > 0)
                        {
                            sb.Length--;
                        }
                        index++;
                        continue;
                    }
                    else if (keypad.ContainsKey(currentKey))
                    {
                        int count = 1;                      
                        while (index + 1 < input.Length && input[index] == input[index + 1] && input[index + 1] != ' ')
                        {
                            count++;
                            index++;
                        }                       
                        string letters = keypad[currentKey];
                        char selectedChar = letters[(count - 1) % letters.Length];
                        sb.Append(selectedChar);
                    }
                    index++;
                }
            }
            else
            {
                sb.Append("Invalid input. Please end the input with '#'.");
            }

            return sb.ToString();
        }
    }
}
