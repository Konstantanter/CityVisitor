using System;

namespace CityLibrary
{
    [Serializable]
    /// <summary>
    /// Класс описывающий город
    /// </summary>
    public class City
    {
        /// <summary>
        /// Имя города
        /// </summary>
        public string NameCity { get; set; }
        /// <summary>
        /// Краткая справка
        /// </summary>
        public string ShortReference { get; set; }
        /// <summary>
        /// Герб города
        /// </summary>
        public string PathGerb { get; set; }
        /// <summary>
        /// Дата посещения
        /// </summary>
        public string DatVis { get; set; }
        //Материалы
        //Сувенир
        /// <summary>
        /// Посещен город или нет
        /// </summary>
        public bool IsVisited { get; private set; }
        /// <summary>
        /// Функция установки посещения города
        /// </summary>
        public void VisitedCity()
        {
            IsVisited = true;
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public City()
        {
            NameCity = "";
            ShortReference = "";
            DatVis = "";
            IsVisited = false;
        }
    }
}
