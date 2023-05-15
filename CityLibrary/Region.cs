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
        /// <summary>
        /// Функция регистрации города в регионе
        /// </summary>
        /// <param name="NameCity">Имя города</param>
        public void AddCity(string NameCity)
        {
            string pathDirRegion = GeneralData.PathRegion + NameRegion + "\\";
            System.IO.Directory.CreateDirectory(pathDirRegion + NameCity);
            City city = new City();
            city.PathCityFile = pathDirRegion + NameCity + $"\\Dat_{NameCity}.okn";
            city.NameCity = NameCity;
            city.NameReg = NameRegion;
            city.CreateCity();
            Serializer.SaveElem(pathDirRegion + "\\City.okn", NameCity);

        }
    }
}
