namespace Durch_Quersumme_teilbare_Zahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Zahl1:");
            if (int.TryParse(Console.ReadLine(), out int zahl1))
            {
                Console.WriteLine("Zahl2:");
                if (int.TryParse(Console.ReadLine(), out int zahl2))
                {
                    BerechneQuersumme(zahl1, zahl2);
                }
            }
           



        }
        static void BerechneQuersumme(int zahl1, int zahl2)
        {
            int sum = 0;
            int currentNum = zahl1;
            while (currentNum !<= zahl2)
            { 
                int calcNum = currentNum;

                while (calcNum != 0)
                {
                    sum += calcNum % 10;
                    calcNum /= 10;
                }

                if ((currentNum % sum) == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{currentNum} \t {sum} \t {(currentNum / sum)}");
                }
                currentNum++;
                sum = 0;
            }
        }
    }
}
