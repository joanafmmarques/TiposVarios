using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Um tab\t e um copyright\u00A9";
            string c = @"Nao e’ um codigo Unicode \u1234, nao e’ nova linha \n";
            Console.WriteLine(s);
            Console.WriteLine(c);
        }
    }
}
