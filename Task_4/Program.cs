using System;
using System.Xml.Linq;

namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            string path = "contact.xml";
            Contact contact = CreateContact();
            SaveContact(contact, path);
            
            Console.ReadKey();
        }

        /// <summary>
        /// Создание контакта
        /// </summary>
        /// <returns></returns>
        static Contact CreateContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Введите Ф.И.О.");
            contact.Name = InputString();

            Console.WriteLine("Введите название улицы");
            contact.Street = InputString();

            Console.WriteLine("Введите номер дома");
            contact.HouseNumber = InputInteger();

            Console.WriteLine("Введите номер квартиры");
            contact.FlatNumber = InputInteger();

            Console.WriteLine("Введите номер мобильного телефона");
            contact.MobilePhone = InputString();

            Console.WriteLine("Введите номер домашнего телефона");
            contact.FlatPhone = InputString();

            return contact;
        }

        /// <summary>
        /// Создание структуры XElement и сохранение файла
        /// </summary>
        /// <param name="contact"></param>
        static void SaveContact(Contact contact, string path)
        {
            XElement Person = new XElement("Person");
            XAttribute Name = new XAttribute("name", contact.Name);

            XElement Address = new XElement("Address");
            XElement Phones = new XElement("Phones");

            XElement Street = new XElement("Street", contact.Street);
            XElement HouseNumber = new XElement("HouseNumber", contact.HouseNumber);
            XElement FlatNumber = new XElement("FlatNumber", contact.FlatNumber);
            XElement MobilePhone = new XElement("MobilePhone", contact.MobilePhone);
            XElement FlatPhone = new XElement("FlatPhone", contact.FlatPhone);

            Person.Add(Name);
            Person.Add(Address);
            Person.Add(Phones);

            Address.Add(Street);
            Address.Add(HouseNumber);
            Address.Add(FlatNumber);

            Phones.Add(MobilePhone);
            Phones.Add(FlatPhone);

            Person.Save(path);
        }

        /// <summary>
        /// Проверка ввода строки
        /// </summary>
        /// <returns></returns>
        static string InputString()
        {
            while (true)
            {
                string input = Console.ReadLine().Trim();

                if (input != "")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Поле не может быть пустым");
                }
            }
        }

        /// <summary>
        /// Проверка ввода числа
        /// </summary>
        /// <returns></returns>
        static int InputInteger()
        {
            while (true)
            {
                string input = Console.ReadLine().Trim();
                int returnInteger;

                if (Int32.TryParse(input, out returnInteger))
                {
                    return returnInteger;
                }
                else
                {
                    Console.WriteLine("Введите число");
                }
            }
        }
    }
}
