namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            IndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            label5 = new Label();
            StreetTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            BuildingTextBox = new TextBox();
            ApartsTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(14, 57);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Post Index:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(14, 101);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Country:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(350, 101);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "City:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IndexTextBox.Location = new Point(108, 54);
            IndexTextBox.MinimumSize = new Size(100, 20);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(137, 27);
            IndexTextBox.TabIndex = 4;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CountryTextBox.Location = new Point(108, 98);
            CountryTextBox.MinimumSize = new Size(200, 20);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(208, 27);
            CountryTextBox.TabIndex = 5;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Location = new Point(393, 98);
            CityTextBox.MinimumSize = new Size(200, 20);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(255, 27);
            CityTextBox.TabIndex = 6;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(14, 155);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 7;
            label5.Text = "Street:";
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(108, 152);
            StreetTextBox.MinimumSize = new Size(500, 20);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(540, 27);
            StreetTextBox.TabIndex = 8;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(14, 207);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Building:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(304, 203);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 10;
            label7.Text = "Apartment:";
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BuildingTextBox.Location = new Point(108, 200);
            BuildingTextBox.MinimumSize = new Size(150, 20);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(190, 27);
            BuildingTextBox.TabIndex = 11;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartsTextBox
            // 
            ApartsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApartsTextBox.Location = new Point(393, 200);
            ApartsTextBox.MinimumSize = new Size(200, 20);
            ApartsTextBox.Name = "ApartsTextBox";
            ApartsTextBox.Size = new Size(255, 27);
            ApartsTextBox.TabIndex = 12;
            ApartsTextBox.TextChanged += ApartsTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartsTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(StreetTextBox);
            Controls.Add(label5);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(IndexTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddressControl";
            Size = new Size(673, 254);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox IndexTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private Label label5;
        private TextBox StreetTextBox;
        private Label label6;
        private Label label7;
        private TextBox BuildingTextBox;
        private TextBox ApartsTextBox;
    }
}
