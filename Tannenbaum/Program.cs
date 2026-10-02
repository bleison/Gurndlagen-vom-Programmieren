namespace Tannenbaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoeheKrone = 8;
            int hoeheStamm = 3;
            int breiteStamm = 3;

            ZeichneKrone(hoeheKrone);
            ZeichneStamm(hoeheKrone, breiteStamm, hoeheStamm);
        }
        static void ZeichneStamm(int kronenHoehe, int stammBreite, int stammHoehe)
        {

            for (int i = 0; i < stammHoehe; i++)
            {
                int leer = kronenHoehe - 1 - stammBreite / 2;
                int sterne = stammBreite;

                ZeichneZeile(leer, sterne);
            }
        }

        static void ZeichneKrone(int hoehe)
        {
            int leer = hoehe - 1;
            int sterne = 1;

            for (int i = 0; i < hoehe; i++)
            {
                ZeichneZeile(leer, sterne);
                leer -= 1;
                sterne += 2;
            }
        }


        static void ZeichneZeile(int anzahlLeer, int anzahlSterne)
        {
            for (int i = 0; i < anzahlLeer; i++)
                Console.Write(" ");

            for (int i = 0; i < anzahlSterne; i++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}
