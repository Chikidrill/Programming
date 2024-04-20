namespace Programming.View.Panels
{
    partial class SeasonControl
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
            SeasonGroupBox = new GroupBox();
            seasonbtn = new Button();
            SeasonCombobox = new ComboBox();
            ChSeasonLabel = new Label();
            SeasonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(seasonbtn);
            SeasonGroupBox.Controls.Add(SeasonCombobox);
            SeasonGroupBox.Controls.Add(ChSeasonLabel);
            SeasonGroupBox.Dock = DockStyle.Fill;
            SeasonGroupBox.Location = new Point(0, 0);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(422, 222);
            SeasonGroupBox.TabIndex = 7;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // seasonbtn
            // 
            seasonbtn.Location = new Point(193, 59);
            seasonbtn.Name = "seasonbtn";
            seasonbtn.Size = new Size(94, 29);
            seasonbtn.TabIndex = 2;
            seasonbtn.Text = "Go!";
            seasonbtn.UseVisualStyleBackColor = true;
            seasonbtn.Click += seasonbtn_Click;
            // 
            // SeasonCombobox
            // 
            SeasonCombobox.FormattingEnabled = true;
            SeasonCombobox.Location = new Point(6, 59);
            SeasonCombobox.Name = "SeasonCombobox";
            SeasonCombobox.Size = new Size(168, 28);
            SeasonCombobox.TabIndex = 1;
            // 
            // ChSeasonLabel
            // 
            ChSeasonLabel.AutoSize = true;
            ChSeasonLabel.Location = new Point(6, 36);
            ChSeasonLabel.Name = "ChSeasonLabel";
            ChSeasonLabel.Size = new Size(110, 20);
            ChSeasonLabel.TabIndex = 0;
            ChSeasonLabel.Text = "Choose season:";
            // 
            // SeasonControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonGroupBox);
            Name = "SeasonControl";
            Size = new Size(422, 222);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonGroupBox;
        private Button seasonbtn;
        private ComboBox SeasonCombobox;
        private Label ChSeasonLabel;
    }
}
