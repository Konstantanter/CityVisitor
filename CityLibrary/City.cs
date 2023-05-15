using System;
using System.Collections.Generic;
using System.Globalization;
namespace CityLibrary
{
    [Serializable]
    /// <summary>
    /// Класс описывающий город
    /// </summary>
    public class City
    {
        /// <summary>
        /// Имя региона
        /// </summary>
        public string NameReg { get; set; }
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
        public bool IsVisited { get;  set; }
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
        public City(string nameReg, string nameCity)
        {
            NameCity = nameCity;
            NameReg = nameReg;
            string pathDirRegion = GeneralData.PathRegion + NameReg + "\\";
            PathCityFile = pathDirRegion + NameCity + $"\\Dat_{NameCity}.okn";
        }
        public string PathCityFile { get; set; }
        public void CreateCity()
        {
            Serializer.SaveToXml(PathCityFile, this);
        }

        public void AddGerb(string pathGerb)
        {
            string dirCity = System.IO.Path.GetDirectoryName(PathCityFile);
            string destName = $"{dirCity}\\Gerb{System.IO.Path.GetExtension(pathGerb)}";
            System.IO.File.Copy(pathGerb, destName);
            City city = Serializer.LoadFromXml<City>(dirCity + $"\\Dat_{NameCity}.okn");
            city.PathGerb = destName;

            Serializer.SaveToXml(dirCity + $"\\Dat_{NameCity}.okn", city);
        }
    }
}
