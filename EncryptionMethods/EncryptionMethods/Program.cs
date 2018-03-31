using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Ciphers();
        }

        private static void Ciphers()
        {
            ConsoleKeyInfo cki, cki1;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите шифр:\n 1 - Шифр Цезаря\n 2 - Аффинный шифр\n 3 - Шифр Виженера\n esc - Выйти");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\nВыберите действие:\n 1 - Зашифровать сообщение\n " +
                        "2 - Расшифровать сообщение\n 3 - Дешифровать сообщение");
                    cki1 = Console.ReadKey();
                    if (cki1.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        CaesarEncrypt();
                        Console.ReadKey();
                    }
                    if (cki1.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        CaesarDecrypt();
                        Console.ReadKey();
                    }
                    if (cki1.Key == ConsoleKey.D3)
                    {
                        Console.Clear();
                        CaesarHack();
                        Console.ReadKey();
                    }
                }

                if (cki.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("\nВыберите действие:\n 1 - Зашифровать сообщение\n 2 - Расшифровать сообщение\n");
                    cki1 = Console.ReadKey();
                    if (cki1.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        AffineEncrypt();
                        Console.ReadKey();
                    }
                    if (cki1.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        AffineDecrypt();
                        Console.ReadKey();
                    }
                }

                if (cki.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("\nВыберите действие:\n 1 - Зашифровать сообщение\n 2 - Расшифровать сообщение\n");
                    cki1 = Console.ReadKey();
                    if (cki1.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        VigenereEncrypt();
                        Console.ReadKey();
                    }
                    if (cki1.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        VigenereDecrypt();
                        Console.ReadKey();
                    }
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private static void CaesarEncrypt()
        {
            Console.WriteLine("Input your message to encrypt (in English and without punctuation)");
            string message = Console.ReadLine().ToLower();
            message = message.Replace(" ", string.Empty);
            Console.WriteLine("Input key");
            int key = int.Parse(Console.ReadLine());
            var Caesar1 = new CaesarCipher(key);
            Console.WriteLine(Caesar1.EncryptMessage(message));
        }

        private static void CaesarDecrypt()
        {
            Console.WriteLine("Input your message to decrypt");
            string message = Console.ReadLine();
            Console.WriteLine("Input key");
            int key = int.Parse(Console.ReadLine());
            var Caesar2 = new CaesarCipher(key);
            Console.WriteLine(Caesar2.DecryptMessage(message));
        }

        private static void CaesarHack()
        {
            Console.WriteLine("Input your message to hack");
            string message = Console.ReadLine();
            Console.WriteLine("Variants:");
            CaesarCipher.HackMessage(message);
        }

        private static void AffineEncrypt()
        {
            Console.WriteLine("Input your message to encrypt (in English and without punctuation)");
            string message = Console.ReadLine().ToLower();
            message = message.Replace(" ", string.Empty);
            Console.WriteLine("Input key a (must be relatively prime to the volume of the alphabet)");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input key b");
            int b = int.Parse(Console.ReadLine());
            var Affine1 = new AffineCipher(a, b);
            Console.WriteLine(Affine1.EncryptMessage(message));
        }

        private static void AffineDecrypt()
        {
            Console.WriteLine("Input your message to decrypt");
            string message = Console.ReadLine();
            Console.WriteLine("Input key a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input key b");
            int b = int.Parse(Console.ReadLine());

            var Affine2 = new AffineCipher(a, b);

            Console.WriteLine(Affine2.DecryptMessage(message));
        }

        private static void VigenereEncrypt()
        {
            Console.WriteLine("Input your message to encrypt (in English and without punctuation)");
            string message = Console.ReadLine().ToLower();
            message = message.Replace(" ", string.Empty);
            Console.WriteLine("Input key");
            string key = Console.ReadLine();
            var Vigenere1 = new VigenereChiper(key);
            Console.WriteLine(Vigenere1.EncryptMessage(message));
        }

        private static void VigenereDecrypt()
        {
            Console.WriteLine("Input your message to decrypt");
            string message = Console.ReadLine();
            Console.WriteLine("Input key");
            string key = Console.ReadLine();
            var Vigenere1 = new VigenereChiper(key);
            Console.WriteLine(Vigenere1.DecryptMessage(message));

        }

    }
}
