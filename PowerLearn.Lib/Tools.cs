using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLearn
{
    public static class Tools
    {
        public static string GetName()
        {
            string result;
            Console.Write("Як тебе звати?: ");
            result = Console.ReadLine();
            return result;
        }

        public static int GetBirthYear(string name)
        {
            int result = -1;
            Console.Write($"Привіт, {name}. В якому році ти народився?: ");
            var input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input ))
            {
                int year;
                if (int.TryParse(input, out  year))
                {
                    result = year;
                    break;
                }
                var fg = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Рік має містити тільки цифри!");
                Console.ForegroundColor = fg;
                Console.Write("Введіть рік народження ще раз: ");
                input = Console.ReadLine();
            }

            return result;
        }



    }
}
