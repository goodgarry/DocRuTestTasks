using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Tasks
{
    public class Task5
    {
        public static void Test()
        {
            Console.WriteLine("\nЗапуск пятого задания\n");
            Console.WriteLine(ReturnFive1());
            Console.WriteLine(ReturnFive2());
            Console.WriteLine(ReturnFive3());
            Console.WriteLine(ReturnFive4());
            Console.WriteLine(ReturnFive5());
            Console.WriteLine(ReturnFive6());
            Console.WriteLine(ReturnFive7());
        }
        static int ReturnFive1()
        {
            return "ДокРу".Length;
        }
        enum Counter
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five
        }
        static int ReturnFive2()
        {
            return (int)Counter.Five;
        }

        static int ReturnFive3()
        {
            return Regex.Matches("mmmmm", "m").Count;
        }
        static int ReturnFive4()
        {
            return TimeSpan.FromMinutes(5).Minutes;
        }

        static int ReturnFive5()
        {
            var twenty_one = Math.ScaleB(Math.E, (int)Math.PI);
            var e_square = Math.Pow(Math.E, Math.E);
            var sixteen = (int)Math.Ceiling(e_square);
            return (int)twenty_one%sixteen;
        }
        static int ReturnFive6()
        {
            var five = Math.Round(Math.Sqrt(Math.Pow(Math.E, Math.PI)));
            return (int)five;
        }
        static int ReturnFive7()
        {
            return '';
        }
    }
}
