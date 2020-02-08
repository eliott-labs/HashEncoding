using System;
using System.Security.Cryptography;
using System.Text;


namespace HashEncoding
{
    class Program
    {
        static void Main(string[] args)
        {


            a();



        }
        static void a()
        {
            Console.Clear();
            Console.WriteLine("Input the word ->");
            string word = Console.ReadLine();
            using (SHA512 sha512Hash = SHA512.Create())
            {
                
                byte[] sourceBytes = Encoding.UTF8.GetBytes(word);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                Console.WriteLine("The SHA512 hash of " + word + " is: " + hash);
                Console.WriteLine("Copied to clipboard");
                
                Console.ReadKey();
                    
                    a();
                
            }

        }

    }
}
