using System;
using System.Collections.Generic;
using System.Text;

namespace CityLibrary
{
    /// <summary>
    /// Класс для описания региона
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Имя региона
        /// </summary>
        string NameRegion { get; set; }
        /// <summary>
        /// Список городов
        /// </summary>
        public List<City> ListCity { get; set; }
        /// <summary>
        /// Регистрация региона
        /// </summary>
        /// <param name="NameRegion">Имя региона (Наприемр: Республика Адыгея)</param>
        public void AddRegion(string NameRegion)
        {
            System.IO.Directory.CreateDirectory(GeneralData.PathRegion + NameRegion);
            Serializer.SaveElem(GeneralData.PathRegion, NameRegion);
        }
    }
}
