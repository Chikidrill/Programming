namespace Programming.View.Panels
{
    partial class EnumerationsControl
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
            IntValueLabel = new Label();
            intvaluetxtbox = new TextBox();
            ValueLabel = new Label();
            EnumLabel = new Label();
            ValueListBox = new ListBox();
            EnumsListBox = new ListBox();
            EnumsGroupBox = new GroupBox();
            SuspendLayout();
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(448, 50);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(136, 20);
            IntValueLabel.TabIndex = 12;
            IntValueLabel.Text = "Enter integer value:";
            // 
            // intvaluetxtbox
            // 
            intvaluetxtbox.Location = new Point(448, 73);
            intvaluetxtbox.Name = "intvaluetxtbox";
            intvaluetxtbox.Size = new Size(136, 27);
            intvaluetxtbox.TabIndex = 11;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(248, 50);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(100, 20);
            ValueLabel.TabIndex = 10;
            ValueLabel.Text = "Choose value:";
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(24, 50);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(149, 20);
            EnumLabel.TabIndex = 9;
            EnumLabel.Text = "Choose enumeration:";
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.ItemHeight = 20;
            ValueListBox.Location = new Point(248, 73);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Size = new Size(163, 264);
            ValueListBox.TabIndex = 7;
            ValueListBox.SelectedIndexChanged += ValueListBox_SelectedIndexChanged_1;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Education Form", "Genre", "Manufacturers", "Season", "Weekday" });
            EnumsListBox.Location = new Point(24, 73);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(163, 264);
            EnumsListBox.TabIndex = 6;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumsGroupBox
            // 
            EnumsGroupBox.Dock = DockStyle.Fill;
            EnumsGroupBox.Location = new Point(0, 0);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(785, 358);
            EnumsGroupBox.TabIndex = 8;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            EnumsGroupBox.Enter += EnumsGroupBox_Enter;
            // 
            // EnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(IntValueLabel);
            Controls.Add(intvaluetxtbox);
            Controls.Add(ValueLabel);
            Controls.Add(EnumLabel);
            Controls.Add(ValueListBox);
            Controls.Add(EnumsListBox);
            Controls.Add(EnumsGroupBox);
            Name = "EnumerationsControl";
            Size = new Size(785, 358);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IntValueLabel;
        private TextBox intvaluetxtbox;
        private Label ValueLabel;
        private Label EnumLabel;
        private ListBox ValueListBox;
        private ListBox EnumsListBox;
        private GroupBox EnumsGroupBox;
    }
}
