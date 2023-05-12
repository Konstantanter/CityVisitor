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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(391, 35);
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
            textRegName.Size = new Size(160, 29);
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
            comboRegs.Location = new Point(205, 107);
            comboRegs.Name = "comboRegs";
            comboRegs.Size = new Size(294, 29);
            comboRegs.TabIndex = 3;
            // 
            // labelRegs
            // 
            labelRegs.AutoSize = true;
            labelRegs.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegs.Location = new Point(41, 110);
            labelRegs.Name = "labelRegs";
            labelRegs.Size = new Size(154, 21);
            labelRegs.TabIndex = 4;
            labelRegs.Text = "Выберите регион:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRegs);
            Controls.Add(comboRegs);
            Controls.Add(label1);
            Controls.Add(textRegName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textRegName;
        private Label label1;
        private ComboBox comboRegs;
        private Label labelRegs;
    }
}