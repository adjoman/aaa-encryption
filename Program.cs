using System;
using AAA.Helpers;

namespace AAAEncryptionExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // this key can be anything the company wants
            string encryptionKey = "99fa50c4-54d3-47c3-afc7-ec1a050a4fd4";

            // what this program does
            // 1. Grabs the company key -- should be store somewhere safe -- config file, etc
            // 2. uses that key to encrypt a string -- the string in this example is hello-world
            // 3. decrypts the key to reveal the plain text string

            string stringToEncrypt = "Hello World";
            string encryptedString = stringToEncrypt.Encrypt(encryptionKey);
            string decryptedString = encryptedString.Decrypt(encryptionKey);

            Console.WriteLine("Encrypted Key: " + encryptedString);
            Console.WriteLine("Decrypting....");
            Console.WriteLine("Decrypted String: " + decryptedString);
        }
    }
}
