using System;
using System.Collections.Generic;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> UsersColletion = new Dictionary<string, string>();

            MenuSelection(UsersColletion);
        }

        /// <summary>
        /// Управление меню выбора
        /// </summary>
        /// <param name="UsersColletion">Словарь пользователей</param>
        static void MenuSelection(Dictionary<string, string> UsersColletion)
        {
            bool menuActive = true;
            
            while (menuActive)
            {
                Console.Clear();
                Console.WriteLine("1. Добавить пользователя" +
                              "\n2. Найти пользователя" +
                              "\n0. Выход");

                string input = Console.ReadLine().Trim();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        NewUser(UsersColletion);
                        break;
                    case "2":
                        Console.Clear();
                        FindUser(UsersColletion);
                        break;
                    case "0":
                        menuActive = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }
            }
        }

        /// <summary>
        /// Добавление нового пользователя
        /// </summary>
        /// <param name="dictionary">Словарь пользователей</param>
        static void NewUser(Dictionary<string, string> dictionary)
        {
            while(true)
            {
                Console.WriteLine("Введите номер телефона:");
                string phone = Console.ReadLine().Trim();

                if (dictionary.ContainsKey(phone))
                {
                    Console.WriteLine("Такой номер уже зарегистрирован");
                }
                else
                {
                    Console.WriteLine("Введите Ф.И.О.:");
                    string fullName = Console.ReadLine().Trim();

                    dictionary.Add(phone, fullName);

                    Console.WriteLine("\nПользователь добавлен.");
                    Console.ReadKey();
                    break;
                }
            }
        }

        /// <summary>
        /// Поиск пользователя по номеру телефона
        /// </summary>
        /// <param name="dictionary">Словарь пользователей</param>
        static void FindUser(Dictionary<string, string> dictionary)
        {
            Console.WriteLine("Введите номер телефона:");
            string phone = Console.ReadLine().Trim();

            if (dictionary.TryGetValue(phone, out string fullName))
            {
                Console.WriteLine($"Владелец: {fullName}");
            }
            else
            {
                Console.WriteLine("Такой номер не зарегистрирован");
            }

            Console.ReadKey();
        }
    }
}
