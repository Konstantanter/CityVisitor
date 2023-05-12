using System.Collections.Generic;

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
        public void AddRegion()
        {
            System.IO.Directory.CreateDirectory(GeneralData.PathRegion + NameRegion);
            Serializer.SaveElem(GeneralData.RegionFile, NameRegion);
        }
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="nameReg">Имя региона</param>
        public Region(string nameReg)
        {
            NameRegion = nameReg;
        }
    }
}
