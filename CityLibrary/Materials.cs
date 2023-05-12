using System;
using System.Collections.Generic;
using System.Text;

namespace CityLibrary
{
    [Serializable]

    /// <summary>
    /// Класс для описания материалов
    /// </summary>
    public class Materials
    {
        /// <summary>
        /// Путь к материалу
        /// </summary>
        public string PathMaterial { get; set; }
        /// <summary>
        /// Перечисление типов материалов
        /// </summary>
        public enum TypesMaterial
        {
            /// <summary>
            /// Фото
            /// </summary>
            Photo,
            /// <summary>
            /// Видео
            /// </summary>
            Video,
        };
        public Materials()
        {

        }
    }
}
