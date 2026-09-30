namespace Durch_3_oder_5_teilbare_Zahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zahlen von 1 - 30 die durch 3 und/oder 5 teilbar sind.");
            for (int i = 1; i <= 30; i++)
            { 

    
                if (i % 3 == 0 || i % 5 == 0)
                {

                    if (i == 30)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }
                }


            }
        }
    }
}
