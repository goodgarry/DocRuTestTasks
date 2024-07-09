using System.Linq;


/*
 * 3. Напишите функцию, которая может принимать любое неотрицательное целое число в качестве аргумента 
 * и возвращать его вместе с цифрами в порядке убывания. 
 * Переставьте цифры так, чтобы на выходе создать максимально возможное число.
 *
 * Пример: 	my_function(42145) 🡪 54421
*/


namespace Tasks
{
    public class Task3
    {
        public static void Test()
        {
            Console.WriteLine("\nЗапуск третьего задания\n");
            Console.WriteLine(DescendingOrderSort(42145));  // 54421
            Console.WriteLine(DescendingOrderSort(145263)); // 654321
            Console.WriteLine(DescendingOrderSort(123456789)); // 987654321
            Console.WriteLine(DescendingOrderSort(0)); // 0
            try
            {
                Console.WriteLine(DescendingOrderSort(-12345));
            }
            catch (Exception ex)
            {
            
                Console.WriteLine($"Поймано исключение: {ex.Message}");
             
            }
        }


        static int DescendingOrderSort(int num)
        {
            if (num < 0) throw new Exception("Число меньше нуля");


            // Превращаем в строку
            char[] digits = num.ToString().ToCharArray();

            // Сортируем в порядке убывания
            var sortedDigits = digits.OrderByDescending(d => d).ToArray();

            // Преобразуем обратно в строку, а затем в целое число
            var sortedNumberString = new string(sortedDigits);
            var sortedNumber = int.Parse(sortedNumberString);

            return sortedNumber;
        }
    }
}

