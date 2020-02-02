using System;

namespace CalorieCalculatorCS
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Zadejte vaší váhu v KG:");

            string vahaRead = Console.ReadLine();
            int vahaConvert = Int32.Parse(vahaRead);

            Console.WriteLine("Zadejte vaší výšku v CM:");

            string vyskaRead = Console.ReadLine();
            int vyskaConvert = Int32.Parse(vyskaRead);

            Console.WriteLine("Zadejte váš věk:");

            string vekRead = Console.ReadLine();
            int vekConvert = Int32.Parse(vekRead);

            Console.WriteLine("Jste žena (true) nebo muž? (false):");

            string pohlavi = Console.ReadLine().ToLower();

            bool pohlaviBool = bool.Parse(pohlavi);

            Calculation(vahaConvert, vyskaConvert, vekConvert, pohlaviBool); // Calculation of a result.

            // Prevents program to close himself.
            Console.Read();
        }

        public static void Calculation(int vaha, int vyska, int vek, bool pohlavi) {

            // Calculation of raw calories
            double rawCal = 0;

            if (pohlavi)
            {
                rawCal = ((10 * vaha) + (6.25 * vyska) - (5 * vek)) - 161;
            }
            else
            {
                rawCal = ((10 * vaha) + (6.25 * vyska) - (5 * vek)) + 5;
            }

            // Calculation to KiloJ...
            double rawKJ = rawCal * 4.184;

            // Rounding final numbers.
            double cal = Math.Round(rawCal);
            int calFinal = Convert.ToInt32(cal);

            double kj = Math.Round(rawKJ);
            int kjFinal = Convert.ToInt32(kj);

            // Printing how much calories and KJ is recommended to eat.
            Console.WriteLine("Doporučený denní příjem je: {0} cal. Převedeno na KJ: {1}.", calFinal, kjFinal);
        }
    }
}