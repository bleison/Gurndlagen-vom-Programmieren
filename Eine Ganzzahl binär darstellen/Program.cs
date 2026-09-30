namespace Eine_Ganzzahl_binär_darstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ganzzahlige Dezimalzahl (q to Quit)");
            string dezimal = Console.ReadLine();
            
            int zahl = Convert.ToInt32(dezimal);

            string binar = Convert.ToString(zahl, 2);

            Console.WriteLine("Binär: " + binar);
        }
    }
}
