using System;
using System.Collections.Generic;


namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            int listCount = 100,
                randomFrom = 0,
                randomTo = 101,
                removeFrom = 25, 
                removeTo = 50;

            List<int> rundomNubmerList = new List<int>();
            CollectionFilling(rundomNubmerList,listCount, randomFrom, randomTo);

            Console.WriteLine("Изначальный набор чисел:\n");
            Print(rundomNubmerList);

            RemoveInteger(rundomNubmerList, removeFrom, removeTo);

            Console.WriteLine($"\n\n После удаления диапазона чисел от {removeFrom} до {removeTo}:\n");
            Print(rundomNubmerList);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполнение коллекции
        /// </summary>
        /// <param name="list">Коллекция</param>
        /// <param name="count">Количесво элементов</param>
        /// <param name="randomFrom">Нижняя границы чисел</param>
        /// <param name="randomTo">Верхняя граница чисел</param>
        static void CollectionFilling(List<int> list,int count, int randomFrom, int randomTo)
        {
            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                int randNumber = rand.Next(randomFrom, randomTo);
                list.Add(randNumber);
            }
        }

        /// <summary>
        /// Удаление диапозона чисел
        /// </summary>
        /// <param name="list">Коллекция</param>
        /// <param name="removeFrom">Нижний диапозон</param>
        /// /// <param name="removeTo">Верхний диапозон</param>
        static void RemoveInteger(List<int> list, int removeFrom, int removeTo)
        {
            List<int> toRemoveList = new List<int>();

            for (int i = removeFrom; i <= removeTo; i++)
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
