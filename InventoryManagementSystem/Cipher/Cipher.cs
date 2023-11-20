using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Cipher
    {
        private const int key = 3;
        char alphabet;
        public string Encode(string plaintext)
        {
            string ciphertext = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                alphabet = plaintext[i];
                if (alphabet >= 'a' && alphabet <= 'z')
                {
                    alphabet = (char)(alphabet + key);
                    if (alphabet > 'z')
                    {
                        alphabet = (char)(alphabet + 'a' - 'z' - 1);
                    }
                    ciphertext += alphabet;
                }
                else if (alphabet >= 'A' && alphabet <= 'Z')
                {
                    alphabet = (char)(alphabet + key);
                    if (alphabet > 'Z')
                    {
                        alphabet = (char)(alphabet + 'A' - 'Z' - 1);
                    }
                    ciphertext += alphabet;
                }
                else
                {
                    ciphertext += alphabet;
                }
            }
            return ciphertext;
        }
        public string Decode(string ciphertext)
        {
            string plaintext = "";
            for (int i = 0; i < ciphertext.Length; i++)
            {
                alphabet = ciphertext[i];
                if (alphabet >= 'a' && alphabet <= 'z')
                {
                    alphabet = (char)(alphabet - key);
                    if (alphabet < 'a')
                    {
                        alphabet = (char)(alphabet - 'a' + 'z' + 1);
                    }
                    plaintext += alphabet;
                }
                else if (alphabet >= 'A' && alphabet <= 'Z')
                {
                    alphabet = (char)(alphabet - key);
                    if (alphabet < 'A')
                    {
                        alphabet = (char)(alphabet - 'A' + 'Z' + 1);
                    }
                    plaintext += alphabet;
                }
                else
                {
                    plaintext += alphabet;
                }
            }
            return plaintext;
        }
    }
}
