using System;
using System.Collections.Generic;
using System.Text;

namespace CityLibrary
{
    /// <summary>
    /// Класс предназнчен для создания и хранения основных данных требуемых для хранения и считывания информации
    /// </summary>
    public class GeneralData
    {
        /// <summary>
        /// путь к рабочему столу
        /// </summary>
        public static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        /// <summary>
        /// Путь к основной папке
        /// </summary>
        public static string MainPath { get; private set; } = DesktopPath + "\\CITY\\";
        /// <summary>
        /// Путь хранения региона 
        /// </summary>
        public static string PathRegion { get; private set; } = MainPath + "Region\\";
        /// <summary>
        /// Файл для хранения региона
        /// </summary>
        public static string RegionFile { get; private set; } = PathRegion + "Region.okn";
        /// <summary>
        /// Констаруктор по умолчанию
        /// </summary>
        public GeneralData()
        {
            //Создаём директорую
            System.IO.Directory.CreateDirectory(MainPath);

        }
    }
}
