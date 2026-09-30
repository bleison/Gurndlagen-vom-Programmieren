namespace Verbotene_Wörtetr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dein Kommentar:");
            string kommentar = Console.ReadLine();

            string[] verboten = { "arschloch", "schnudergoof", "saucheib", "hurensohn", "scheisse", "payas", "schafsekkel", "sauhund", "urchig" };
            bool valid = false;
            for (int i = 0; i < verboten.Length; i++)
            {
                if (kommentar.Contains(verboten[i], StringComparison.OrdinalIgnoreCase))
                {
                    valid = true;
                }
            }
            if (valid)
            {
                Console.WriteLine("Du habasch! :)");
            }
            else
            {
                Console.WriteLine("Danke für deinen Kommentar! :)");
            }
        }
    }
}
