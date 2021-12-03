using System;

namespace SpaceWarriors
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("zadejte 1. cislo");
            int cisloA = int.Parse(Console.ReadLine());
            Console.WriteLine("zadejte 2. cislo");
            int cisloB = int.Parse(Console.ReadLine());
            int vysledek = cisloA + cisloB;
            Console.WriteLine("vysledek je " + vysledek.ToString());

            Console.ReadLine();
        }
    }
}
