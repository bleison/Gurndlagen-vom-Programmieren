namespace Kleines_1x1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kleines 1x1");
            for (int i = 1; i <= 10; i++)
            { 
                for (int n = 1; n <= 10; n++)
                {
                    Console.Write($"{i * n} \t");
                }
                Console.WriteLine();
            }

        }
    }
}
