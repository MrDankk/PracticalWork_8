using System;
using System.Collections.Generic;


namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            int listCount = 100,
                randomTo = 0,
                randomFrom = 101,
                removeTo = 25, 
                removeFrom = 50;

            List<int> rundomNubmerList = new List<int>();
            CollectionFilling(rundomNubmerList,listCount,randomTo,randomFrom);

            Console.WriteLine("Изначальный набор чисел:\n");
            Print(rundomNubmerList);

            RemoveInteger(rundomNubmerList,removeTo,removeFrom);

            Console.WriteLine($"\n\n После удаления диапазона чисел от {removeTo} до {removeFrom}:\n");
            Print(rundomNubmerList);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполнение коллекции
        /// </summary>
        /// <param name="list">Коллекция</param>
        /// <param name="count">Количесво элементов</param>
        /// <param name="randomTo">Нижняя границы чисел</param>
        /// <param name="randomFrom">Верхняя граница чисел</param>
        static void CollectionFilling(List<int> list,int count,int randomTo,int randomFrom)
        {
            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                int randNumber = rand.Next(randomTo, randomFrom);
                list.Add(randNumber);
            }
        }

        /// <summary>
        /// Удаление диапозона чисел
        /// </summary>
        /// <param name="list">Коллекция</param>
        /// <param name="removeTo">Нижний диапозон</param>
        /// <param name="removeFrom">Верхний диапозон</param>
        static void RemoveInteger(List<int> list, int removeTo, int removeFrom)
        {
            List<int> toRemoveList = new List<int>();

            for (int i = removeTo; i <= removeFrom; i++)
            {
                toRemoveList.Add(i);
            }

            list.RemoveAll(x => toRemoveList.Contains(x));
        }

        /// <summary>
        /// Вывод коллекции в консоль
        /// </summary>
        /// <param name="list">Коллекция</param>
        static void Print(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
