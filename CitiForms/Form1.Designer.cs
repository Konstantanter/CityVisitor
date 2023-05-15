namespace CityForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textRegName = new TextBox();
            label1 = new Label();
            comboRegs = new ComboBox();
            labelRegs = new Label();
            pictCity = new PictureBox();
            buttonCityAdd = new Button();
            textCityName = new TextBox();
            labelCityName = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictCity).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(649, 35);
            button1.Name = "button1";
            button1.Size = new Size(139, 34);
            button1.TabIndex = 0;
            button1.Text = "Добавить регион";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textRegName
            // 
            textRegName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textRegName.Location = new Point(203, 38);
            textRegName.Name = "textRegName";
            textRegName.Size = new Size(440, 29);
            textRegName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 41);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 2;
            label1.Text = "Имя региона";
            // 
            // comboRegs
            // 
            comboRegs.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboRegs.FormattingEnabled = true;
            comboRegs.Location = new Point(203, 94);
            comboRegs.Name = "comboRegs";
            comboRegs.Size = new Size(585, 29);
            comboRegs.TabIndex = 3;
            comboRegs.SelectedIndexChanged += comboRegs_SelectedIndexChanged;
            comboRegs.TextChanged += comboRegs_TextChanged;
            // 
            // labelRegs
            // 
            labelRegs.AutoSize = true;
            labelRegs.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegs.Location = new Point(15, 97);
            labelRegs.Name = "labelRegs";
            labelRegs.Size = new Size(154, 21);
            labelRegs.TabIndex = 4;
            labelRegs.Text = "Выберите регион:";
            // 
            // pictCity
            // 
            pictCity.Location = new Point(748, 185);
            pictCity.Name = "pictCity";
            pictCity.Size = new Size(24, 10);
            pictCity.TabIndex = 7;
            pictCity.TabStop = false;
            pictCity.Visible = false;
            // 
            // buttonCityAdd
            // 
            buttonCityAdd.Location = new Point(649, 143);
            buttonCityAdd.Name = "buttonCityAdd";
            buttonCityAdd.Size = new Size(139, 34);
            buttonCityAdd.TabIndex = 6;
            buttonCityAdd.Text = "Добавить город";
            buttonCityAdd.UseVisualStyleBackColor = true;
            buttonCityAdd.Visible = false;
            buttonCityAdd.Click += buttonCityAdd_Click;
            // 
            // textCityName
            // 
            textCityName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textCityName.Location = new Point(202, 145);
            textCityName.Name = "textCityName";
            textCityName.Size = new Size(441, 29);
            textCityName.TabIndex = 6;
            textCityName.Visible = false;
            // 
            // labelCityName
            // 
            labelCityName.AutoSize = true;
            labelCityName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCityName.Location = new Point(61, 148);
            labelCityName.Name = "labelCityName";
            labelCityName.Size = new Size(108, 21);
            labelCityName.TabIndex = 5;
            labelCityName.Text = "Имя города:";
            labelCityName.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(47, 341);
            button2.Name = "button2";
            button2.Size = new Size(163, 37);
            button2.TabIndex = 8;
            button2.Text = "Добавить герб";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(pictCity);
            Controls.Add(buttonCityAdd);
            Controls.Add(textCityName);
            Controls.Add(label1);
            Controls.Add(labelCityName);
            Controls.Add(textRegName);
            Controls.Add(comboRegs);
            Controls.Add(button1);
            Controls.Add(labelRegs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)pictCity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textRegName;
        private Label label1;
        private ComboBox comboRegs;
        private Label labelRegs;
        private Button buttonCityAdd;
        private TextBox textCityName;
        private Label labelCityName;
        private PictureBox pictCity;
        private Button button2;
    }
}