using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CityLibrary
{
    /// <summary>
    /// Класс для сериализации данных
    /// </summary>
    public static class Serializer
    {

        #region Сериализация и десериализация списка объектов
        public static void SaveElem<T>(String FileName, T SerializableObjects)
        {

            List<T> list = new List<T>();
            if (System.IO.File.Exists(FileName))
            {
                list = LoadListFromXml<T>(FileName);

            }
            else
            {
                //System.IO.Directory.CreateDirectory(System.IO.)
            }
            using (FileStream fs = File.Open(FileName, FileMode.OpenOrCreate))
            {
                list.Add(SerializableObjects);

                XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
                formatter.Serialize(fs, list);

            }

        }
        public static T LoadFromXml<T>(String fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
        public static void SaveToXml<T>(String FileName, T SerializableObject)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter textWriter = new StreamWriter(FileName))
            {
                serializer.Serialize(textWriter, SerializableObject);
            }
        }
        public static List<T> LoadListFromXml<T>(string fileName)
        {
            try
            {
                if (System.IO.File.Exists(fileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<T>));

                    using (XmlReader reader = XmlReader.Create(fileName))
                    {
                        return (List<T>)ser.Deserialize(reader);
                    }
                }

            }
            catch (Exception)
            {

            }
            return null;
        }
       
        #endregion
    }
}
