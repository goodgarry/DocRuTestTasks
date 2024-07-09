using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task4
    {
        public static void Test()
        {
            Console.WriteLine("\nЗапуск четвертого задания\n");

            Console.WriteLine(PyramideRowCalculate(1)); // 1
            Console.WriteLine(PyramideRowCalculate(2)); // 8
            Console.WriteLine(PyramideRowCalculate(3)); // 27
            Console.WriteLine(PyramideRowCalculate(4)); // 60
            Console.WriteLine(PyramideRowCalculate(5)); // 105
        }
        static int PyramideRowCalculate(int rowIndex)
        {
            // Вычисляем начальное число строки
            var startNumber = 1 + (rowIndex - 1) * rowIndex;

            // Суммируем все числа в строке
            var sum = 0;
            for (var i = 0; i < rowIndex; i++)
            {
                sum += startNumber + (i * 2);
            }

            return sum;
        }
    }
}
