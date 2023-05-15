using System.Drawing;
using System.Windows.Forms;

namespace City_Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.textRegName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRegs = new System.Windows.Forms.ComboBox();
            this.labelRegs = new System.Windows.Forms.Label();
            this.pictCity = new System.Windows.Forms.PictureBox();
            this.buttonCityAdd = new System.Windows.Forms.Button();
            this.textCityName = new System.Windows.Forms.TextBox();
            this.labelCityName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictCity)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить регион";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textRegName
            // 
            this.textRegName.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textRegName.Location = new System.Drawing.Point(174, 33);
            this.textRegName.Name = "textRegName";
            this.textRegName.Size = new System.Drawing.Size(378, 29);
            this.textRegName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя региона";
            // 
            // comboRegs
            // 
            this.comboRegs.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.comboRegs.FormattingEnabled = true;
            this.comboRegs.Location = new System.Drawing.Point(174, 81);
            this.comboRegs.Name = "comboRegs";
            this.comboRegs.Size = new System.Drawing.Size(502, 29);
            this.comboRegs.TabIndex = 3;
            this.comboRegs.SelectedIndexChanged += new System.EventHandler(this.comboRegs_SelectedIndexChanged);
            this.comboRegs.TextChanged += new System.EventHandler(this.comboRegs_TextChanged);
            // 
            // labelRegs
            // 
            this.labelRegs.AutoSize = true;
            this.labelRegs.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelRegs.Location = new System.Drawing.Point(13, 84);
            this.labelRegs.Name = "labelRegs";
            this.labelRegs.Size = new System.Drawing.Size(154, 21);
            this.labelRegs.TabIndex = 4;
            this.labelRegs.Text = "Выберите регион:";
            // 
            // pictCity
            // 
            this.pictCity.Location = new System.Drawing.Point(641, 160);
            this.pictCity.Name = "pictCity";
            this.pictCity.Size = new System.Drawing.Size(21, 9);
            this.pictCity.TabIndex = 7;
            this.pictCity.TabStop = false;
            this.pictCity.Visible = false;
            // 
            // buttonCityAdd
            // 
            this.buttonCityAdd.Location = new System.Drawing.Point(556, 126);
            this.buttonCityAdd.Name = "buttonCityAdd";
            this.buttonCityAdd.Size = new System.Drawing.Size(119, 29);
            this.buttonCityAdd.TabIndex = 6;
            this.buttonCityAdd.Text = "Добавить город";
            this.buttonCityAdd.UseVisualStyleBackColor = true;
            this.buttonCityAdd.Visible = false;
            this.buttonCityAdd.Click += new System.EventHandler(this.buttonCityAdd_Click);
            // 
            // textCityName
            // 
            this.textCityName.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textCityName.Location = new System.Drawing.Point(173, 126);
            this.textCityName.Name = "textCityName";
            this.textCityName.Size = new System.Drawing.Size(379, 29);
            this.textCityName.TabIndex = 6;
            this.textCityName.Visible = false;
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelCityName.Location = new System.Drawing.Point(52, 128);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(108, 21);
            this.labelCityName.TabIndex = 5;
            this.labelCityName.Text = "Имя города:";
            this.labelCityName.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить герб";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictCity);
            this.Controls.Add(this.buttonCityAdd);
            this.Controls.Add(this.textCityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.textRegName);
            this.Controls.Add(this.comboRegs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRegs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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