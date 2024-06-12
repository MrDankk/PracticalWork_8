using System;

namespace Task_4
{
    struct Contact
    {
        /// <summary>
        /// Ф.И.О.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Название улицы
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// НомерДома
        /// </summary>
        public int HouseNumber { get; set; }

        /// <summary>
        /// Номер Квартиры
        /// </summary>
        public int FlatNumber {  get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Домашний телефон
        /// </summary>
        public string FlatPhone { get; set; }
    }
}
