namespace Monatsnamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl eingeben: ");
            string zahl = Console.ReadLine();
            int monatszahl = Convert.ToInt32(zahl);

            if ( monatszahl == 1) 
            {
                Console.WriteLine("Monat: Januar");
            }
            if (monatszahl == 2)
            {
                Console.WriteLine("Monat: Februar");
            }

            if (monatszahl == 3)
            {
                Console.WriteLine("Monat: März");
            }
            if (monatszahl == 4)
            {
                Console.WriteLine("Monat: April");
            }

            if (monatszahl == 5)
            {
                Console.WriteLine("Monat: Mai");
            }
            if (monatszahl == 6)
            {
                Console.WriteLine("Monat: Juni");
            }

            if (monatszahl == 7)
            {
                Console.WriteLine("Monat: Juli");
            }
            if (monatszahl == 8)
            {
                Console.WriteLine("Monat: August");
            }
            if (monatszahl == 9)
            {
                Console.WriteLine("Monat: September");
            }
            if (monatszahl == 10)
            {
                Console.WriteLine("Monat: Oktober");
            }

            if (monatszahl == 11)
            {
                Console.WriteLine("Monat: November");
            }
            if (monatszahl == 12)
            {
                Console.WriteLine("Monat: Dezember");

            }
            
            if(monatszahl >= 12)
            {
                Console.WriteLine("Dieser Monat existiert nicht!");
            }
            if (monatszahl < 1)
            {
                Console.WriteLine("Dieser Monat existiert nicht!");
            }
        }
    }
}