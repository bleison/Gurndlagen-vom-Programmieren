namespace Eine_Diagonale_Linie_zeichnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            Console.Write("Deine Eingabe: ");
              
            int groesse = int.Parse(Console.ReadLine());
            string[,] sterne = new string[groesse, groesse];

            for (int i = 0; i < groesse; i++)
            {
                for (int j = 0; j < groesse; j++)
                {
                    sterne[i, j] = "*";
                }
            }

            for (int i = 0; i < groesse; i++)
            {
                for (int j = 0; j < groesse; j++)
                {
                    if (i == j)
                    {
                        sterne[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < groesse; i++)
            {
                for (int j = 0; j < groesse; j++)
                {
                    Console.Write(sterne[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
