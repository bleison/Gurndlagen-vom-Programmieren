namespace Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            int jahr;
            string input = "";
            do
            {
                do
                {
                    Console.Write("Eingabe Jahr (q to Quit): ");
                    input = Console.ReadLine();
                } while (!(Int32.TryParse(input, out jahr)) && !(input.ToLower() == "q"));

                if (input.ToLower() != "q")
                {
                    if (jahr % 4 == 0 && jahr % 100 != 0 || jahr % 400 == 0)
                    {
                        Console.WriteLine($"Das Jahr {jahr} ist ein Schaltjahr.");
                    }
                    else
                    {
                        Console.WriteLine($"Das Jahr {jahr} ist KEIN Schaltjahr.");
                    }
                }
            } while (!(input.ToLower() == "q"));

        }
    }
}
