using System.Collections.Generic;


namespace Tasks
{
    public class Task2
    {
        public static void Test()
        {
            Console.WriteLine("\nЗапуск второго задания\n");
            Console.WriteLine(PrintDictionary(CointsCounter(56)));       // {'Nickels': 1, 'Pennies': 1, 'Dimes': 0, 'Quarters': 2}
            Console.WriteLine(PrintDictionary(CointsCounter(-435)));     // {'Nickels': 0, 'Pennies': 0, 'Dimes': 0, 'Quarters': 0}
            Console.WriteLine(PrintDictionary(CointsCounter(4.935)));    // {'Nickels': 0, 'Pennies': 4, 'Dimes': 0, 'Quarters': 0}
        }

        static Dictionary<string, int> CointsCounter(double cents)
        {
            // Словарь для хранения количества каждой монеты
            Dictionary<string, int> coinCount = new Dictionary<string, int>
            {
                { "Pennies", 0 },
                { "Nickels", 0 },
                { "Dimes", 0 },
                { "Quarters", 0 }
             };

            var totalCents = (int)Math.Floor(cents);

            // Если значение меньше или равно нулю, возвращаем словарь со всеми нулями
            if (totalCents <= 0)
            {
                return coinCount;
            }



            // Определяем количество каждого типа монет
            coinCount["Quarters"] = totalCents / 25;
            totalCents %= 25;

            coinCount["Dimes"] = totalCents / 10;
            totalCents %= 10;

            coinCount["Nickels"] = totalCents / 5;
            totalCents %= 5;

            coinCount["Pennies"] = totalCents;

            return coinCount;
        }

        public static string PrintDictionary(Dictionary<string, int> dict)
        {
            return $"{{'Nickels': {dict["Nickels"]}, 'Pennies': {dict["Pennies"]}, 'Dimes': {dict["Dimes"]}, 'Quarters': {dict["Quarters"]}}}";
        }
    }
}
