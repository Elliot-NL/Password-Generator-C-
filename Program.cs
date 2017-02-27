using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___Random_Password_Generator
{
    class Program
    {
        static string generatePswd(int length)
        {
            const string validChars =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder red = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                red.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return red.ToString();
        }

        static void Main(string[] args)
        {
            int length = 8;

            string pass = generatePswd(length);
            Console.Write(length);
            Console.ReadLine();
        }
    }
}
