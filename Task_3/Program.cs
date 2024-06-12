using System;
using System.Collections.Generic;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            HashSet<int> setInteger = new HashSet<int>();

            while (true)
            {
                int input = InputInteger();

                if(!setInteger.Add(input))
                {
                    Console.WriteLine("Число вводилось ранее");
                }
                else
                {
                    Console.WriteLine("Число успешно сохранено");
                }
            }
        }

        /// <summary>
        /// Проверка ввода числа
        /// </summary>
        /// <returns> Число </returns>
        static int InputInteger()
        {
            Console.WriteLine("\nВведите число");

            while (true)
            {
                int inputInteger = 0;
                string input = Console.ReadLine().Trim();

                if (Int32.TryParse(input, out inputInteger))
                {
                    return inputInteger;
                }
                else 
                {
                    Console.WriteLine("Попробуйте еще раз");
                }
            }
        }
    }
}
