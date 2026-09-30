using System;

namespace Quersumme_berechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Zahl: ");
            if (int.TryParse(Console.ReadLine(), out int zahl))
            {
                int quersumme = BerechneQuersumme(zahl);
                Console.WriteLine(quersumme);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }

        }
        static int BerechneQuersumme(int zahl)
        {
            zahl = Math.Abs(zahl);
            int sum = 0;

            while (zahl > 0)
            {
                sum += zahl % 10;
                zahl /= 10;
            }

            return sum;
        }

    }
}