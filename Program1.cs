using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVerifier
{
    public class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine(checkPassword("Abc@123dcjdc!@#$", 10));
            Console.ReadLine();
        }
        static bool checkPassword(string input, int minimum)
        {
            bool num = false;
            bool upp = false;
            bool low = false;
            bool spec = false;
            char currentChar;
            if (!(input.Length >= minimum))
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                currentChar = input[i];
                if (char.IsDigit(currentChar))
                {
                    num = true;
                }
                else if (char.IsUpper(currentChar))
                {
                    upp = true;
                }
                else if (char.IsLower(currentChar))
                {
                    low = true;
                }
                else if (!char.IsLetterOrDigit(currentChar))
                {
                    spec = true;
                }
                if (num && upp && low && spec)
                {
                    return true;
                }
            }
            return false;
        }
    }
}