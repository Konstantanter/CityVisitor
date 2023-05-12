namespace CityForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция обновления списка регионов
        /// </summary>
        void UpdateComboBox()
        {
            string fileName = CityLibrary.GeneralData.RegionFile;
            if (System.IO.File.Exists(fileName))
            {
                List<string> ListRegs = CityLibrary.Serializer.LoadListFromXml<string>(fileName);
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
    }
}