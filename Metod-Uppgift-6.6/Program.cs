using System;

namespace Uppgift_6_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv in en sträng");
            Caps(Console.ReadLine());
        }
        static void Caps(string sträng)
        {
            string[] str = sträng.Split(' ');

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0) str[i] = str[i].ToUpper();
            }

            sträng = string.Join(" ", str);

            Console.WriteLine(sträng);
        }
    }
}