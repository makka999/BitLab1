using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtiLab1
{
    internal class Function
    {
        public static string Encrypt(char[] textToEncrypt, char[] alphabet, int key)
        {
            int alphabetLenght = alphabet.Length;
            int length = textToEncrypt.Length;
            char[] encryptedChar = new char[length];
            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                if (!(textToEncrypt[i] == ' '))
                {
                    var letter = textToEncrypt[i];
                    int index = Array.IndexOf(alphabet, letter);
                    int newIndex = (key + index) % alphabetLenght;
                    if (newIndex < 0) newIndex = alphabetLenght + newIndex;
                    char newLetter = alphabet[newIndex];
                    encryptedChar[i] = newLetter;
                }
                else encryptedChar[i] = textToEncrypt[i];
            }

            string encrypToText = String.Join("", encryptedChar);
            return encrypToText;
        }

        public static string UnEncrypt (char[] textToEncrypt, char[] alphabet, int key)
        {
            return Encrypt(textToEncrypt, alphabet, key * -1);
        }

    }
}
