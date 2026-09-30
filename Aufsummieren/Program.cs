namespace Aufsummieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            int[] num;
            do
            {
                string eingabe = Console.ReadLine();
                string[] eingabeArray = eingabe.Split(',');
                num = new int[eingabeArray.Length];
                valid = false;
                for (int i = 0; i < eingabeArray.Length; i++)
                {
                    if (int.TryParse(eingabeArray[i], out num[i]))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Du Habasch, ich benötige eine Zahl! :)");
                        valid = true;

                    }
                }
            } while (valid);
            PrintArray(SumUp(num));
        }
        static int[] SumUp(int[] numbers)
        {
            int sum = 0;
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                result[i] = sum;
            }
            return result;
        }

        static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                if (i == numbers.Length - 1)
                {
                    Console.Write($"[{i}] -> {numbers[i]}");
                }
                else
                {
                    Console.Write($"[{i}] -> {numbers[i]}, ");
                }
            }
        }

         
    }
}
