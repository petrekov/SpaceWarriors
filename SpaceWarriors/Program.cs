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
            Console.WriteLine("zadejte 3. cislo");
            int cisloC = int.Parse(Console.ReadLine());
            Console.WriteLine("ZADEJTE 4. cislo");
            int cisloD = int.Parse(Console.ReadLine());
            Console.WriteLine("neotravuj už");
            int vysledek = cisloA + cisloB + cisloC + cisloD ;
            Console.WriteLine("vysledek je " + vysledek.ToString());

            Console.ReadLine();
        }
    }
}
