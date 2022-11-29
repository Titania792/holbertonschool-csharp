using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            for (int i = 97; i <= 122; i++)
                str = str+Convert.ToChar(i);
            Console.WriteLine(str);
        }
    }
}
