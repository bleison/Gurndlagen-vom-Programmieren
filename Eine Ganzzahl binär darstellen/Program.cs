using System.Dynamic;
using System.Linq.Expressions;

namespace Eine_Ganzzahl_binär_darstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wert;
            string bin = "";
            int n = Convert.ToInt32(Console.ReadLine());
            do 
            {
                int rest = n % 2;
                bin = rest + bin;
                wert = n / 2;
                n = wert;

            } while (n != 0);
            Console.WriteLine(bin);


        }
    }
}
