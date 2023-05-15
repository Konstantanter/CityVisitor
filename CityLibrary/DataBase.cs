using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrary
{

    /// <summary>
    /// Класс для управления базой данных
    /// </summary>
    public partial class DataBase
    {

        public DataBase()
        {

            // OpenConnection();
        }
        /// <summary>
        /// Строка подключения к БД
        /// </summary>
        /// Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="{System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)}\UsersBase.mdf";Integrated Security=True
        /// Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\KOBRA\Desktop\приеры оих работ\SkyNet\GUI_V_2\UsersBase.mdf";Integrated Security=True;Connect Timeout=30
        public static string srt = @"C:\Users\BRONUF\Desktop\CityDataBase.mdf";
        //public static string srt = $"{System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)}\\UsersBase.mdf";
        public SqlConnection sqlConnection;
        //System.IO.Path.GetNA
        /// <summary>
        /// Открытие Соединения
        /// </summary>
        public async void OpenConnection()
        {

            await Task.Run(() =>
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {

                    //sqlConnection.
                    sqlConnection.Open();
                }
            });
        }
        /// <summary>
        /// Функция регистрации города в базе данных
        /// </summary>
        /// <param name="Namereg">Имя региона</param>
        /// <param name="CityName">Имя города</param>
        public void AddCityFromBD(string Namereg,string CityName)
        {
            using (SqlConnection conn = getConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    string pathDirRegion = GeneralData.PathRegion + Namereg + "\\";
                    string PathCityFile = pathDirRegion + $"\\Dat_{CityName}.okn";
                    comm.Connection = conn;
                    comm.CommandText = $"SET ANSI_WARNINGS OFF;\nINSERT INTO [dbo].[City] (NameReg, NameCity, PathData, Visited) VALUES (N'{Namereg}',N'{CityName}', N'{PathCityFile}',N'false')\nSET ANSI_WARNINGS ON;";
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    comm.ExecuteNonQuery();

                }
            }
                
            
        }
        /// <summary>
        /// Закрытие Соединения
        /// </summary>
        public async void CloseConnection()
        {
            await Task.Run(() =>
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            });
        }
        public SqlConnection getConnection()
        {
            //string str = ;


            return new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={srt};Integrated Security=True;Connect Timeout=30");
        }
    }
}
