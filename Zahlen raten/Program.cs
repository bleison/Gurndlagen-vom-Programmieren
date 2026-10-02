using System.Numerics;

namespace Zahlen_raten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deine Zahl (1..100):");
            int eingabe = int.Parse(Console.ReadLine());

            Random random = new Random();
            int zufall = random.Next(1, 101);
            int versuche = 0;
            do
            {
                versuche++;
                if (eingabe < zufall)
                {
                    Console.WriteLine("Die Zahl ist zu klein! Nächster Versuch:");
                    eingabe = int.Parse(Console.ReadLine());
                }
                if (eingabe > zufall)
                {
                    Console.WriteLine("Die Zahl ist zu gross! Nächster Versuch:");
                    eingabe = int.Parse(Console.ReadLine());
                }
                if (eingabe == zufall)
                {
                    Console.WriteLine($"Die Zahl stimmt! Du hast total {versuche} Versuche benötigt. Noch einmal spielen? [y/n]");
                    string antwort = Console.ReadLine();
                    if (antwort == "y" || antwort == "Y")
                    {
                        Console.WriteLine("Deine Zahl (1..100):");
                        eingabe = int.Parse(Console.ReadLine());
                        zufall = random.Next(1, 101);
                        versuche = 0;
                    }
                    if (antwort == "n" || antwort == "N")
                    {
                        Console.WriteLine("Danke fürs Spielen!");
                    }
                }
            } while (eingabe != zufall);

        }
    }
}
