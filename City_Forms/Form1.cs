using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Список регионов
        /// </summary>
        public List<string> ListRegs = new List<string>();
        /// <summary>
        /// Функция обновления списка регионов
        /// </summary>
        void UpdateComboBox()
        {
            string fileName = CityLibrary.GeneralData.RegionFile;
            if (System.IO.File.Exists(fileName))
            {
                ListRegs = CityLibrary.Serializer.LoadListFromXml<string>(fileName);
                comboRegs.Items.Clear();
                comboRegs.Text = "";
                comboRegs.Items.AddRange(ListRegs.ToArray());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CityLibrary.Region region = new CityLibrary.Region(textRegName.Text);
            region.AddRegion();
            UpdateComboBox();
            MessageBox.Show("Магия успешна");
            textRegName.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComboBox();
            
        }

        private void comboRegs_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboRegs.SelectionLength = 0;
            labelCityName.Visible = true;
            textCityName.Visible = true;
            buttonCityAdd.Visible = true;


        }

        private void comboRegs_TextChanged(object sender, EventArgs e)
        {
            if (comboRegs.Text == "")
            {
                labelCityName.Visible = false;
                textCityName.Visible = false;
                buttonCityAdd.Visible = false;
                comboRegs.SelectedIndex = -1;
            }

        }
       
        private void buttonCityAdd_Click(object sender, EventArgs e)
        {
            int regIndex = comboRegs.SelectedIndex;
            comboRegs.Text = "";
            if (regIndex != -1)
            {
                string selectedRegName = ListRegs[regIndex];

                string nameCity = textCityName.Text;
                if (nameCity != "")
                {
                    CityLibrary.Region region = new CityLibrary.Region(selectedRegName);
                    region.AddCity(nameCity);
                    CityLibrary.DataBase dataBase= new CityLibrary.DataBase();
                    dataBase.AddCityFromBD(selectedRegName, nameCity);
                    MessageBox.Show("Город успешно добавлен");
                    textCityName.Text = "";
                }
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            comboRegs.SelectionLength = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CityLibrary.City city = new CityLibrary.City("Республика Адыгея", "Майкоп");
            city.AddGerb(@"C:\Users\BRONUF\Desktop\Ждун.jpg");
            MessageBox.Show("герб добавлен");
        }


    }
}
