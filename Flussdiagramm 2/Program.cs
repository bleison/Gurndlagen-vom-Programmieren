namespace Flussdiagramm_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            string kilometereingabe = Console.ReadLine();
            decimal kilometer = Convert.ToInt32(kilometereingabe);
            if (kilometer > 42)
            {
                Console.WriteLine("Du schaffst das nicht!");
            }
            else
            {
                decimal runde = 0.4m;
                decimal n = kilometer * runde;

                Console.WriteLine($"Das sind {n} Runden. Bereit für den Lauf?");
                Console.WriteLine("JA [j] NEIN [n]");
                string auswahl = Console.ReadLine();
                int i = 1;

                if (auswahl == "j")
                {
                    
                    if (i <= n)
                    {
                        do
                        {
                            Console.WriteLine($"Du läufst Runde {i}");
                            i++;
                        } while (i <= n);
                    }
                }
                if (i == n) {
                    Console.WriteLine("Du hast es geschafft!");
                }
                if (auswahl == "n")
                {
                    Console.WriteLine("Ende");
                }

            }
        }
    }
}
