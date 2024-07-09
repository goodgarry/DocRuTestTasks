using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task1
    {

        public static void Test()
        {
            Console.WriteLine("\nЗапуск первого задания\n");
            Console.WriteLine(SumOfDigits(16));  //  7
            Console.WriteLine(SumOfDigits(942)); // 6
            Console.WriteLine(SumOfDigits(132189)); //  6
            Console.WriteLine(SumOfDigits(35444)); //  2
            Console.WriteLine(SumOfDigits(132183)); //  9
            try
            {
                Console.WriteLine(SumOfDigits(-5)); //  Exception - не натуральное число
            }
            catch (Exception ex) 
            { 
                Console.WriteLine($"Поймано исключение: {ex.Message}"); 
            }
        }

        static int SumOfDigits(int n)
        {
            if (n < 0) throw new Exception("Число не является натуральным");
            if (n < 10) return n;
            else
            {
                var sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return SumOfDigits(sum);
            }
        }
    }
}
