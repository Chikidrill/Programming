namespace Programming.View.Panels
{
    partial class WeekdaysControl
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
            WDParsingGroupBox = new GroupBox();
            OutputParseLabel = new Label();
            ParseValuetxtbox = new TextBox();
            ParseButton = new Button();
            ParseLabel = new Label();
            WDParsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // WDParsingGroupBox
            // 
            WDParsingGroupBox.Controls.Add(OutputParseLabel);
            WDParsingGroupBox.Controls.Add(ParseValuetxtbox);
            WDParsingGroupBox.Controls.Add(ParseButton);
            WDParsingGroupBox.Controls.Add(ParseLabel);
            WDParsingGroupBox.Dock = DockStyle.Fill;
            WDParsingGroupBox.Location = new Point(0, 0);
            WDParsingGroupBox.Name = "WDParsingGroupBox";
            WDParsingGroupBox.Size = new Size(464, 226);
            WDParsingGroupBox.TabIndex = 1;
            WDParsingGroupBox.TabStop = false;
            WDParsingGroupBox.Text = "Weekday Parsing";
            // 
            // OutputParseLabel
            // 
            OutputParseLabel.AutoSize = true;
            OutputParseLabel.Location = new Point(6, 99);
            OutputParseLabel.Name = "OutputParseLabel";
            OutputParseLabel.Size = new Size(50, 20);
            OutputParseLabel.TabIndex = 9;
            OutputParseLabel.Text = "label1";
            // 
            // ParseValuetxtbox
            // 
            ParseValuetxtbox.Location = new Point(6, 59);
            ParseValuetxtbox.Name = "ParseValuetxtbox";
            ParseValuetxtbox.Size = new Size(228, 27);
            ParseValuetxtbox.TabIndex = 8;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(273, 59);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 7;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParseLabel
            // 
            ParseLabel.AutoSize = true;
            ParseLabel.Location = new Point(6, 36);
            ParseLabel.Name = "ParseLabel";
            ParseLabel.Size = new Size(158, 20);
            ParseLabel.TabIndex = 0;
            ParseLabel.Text = "Type value for parsing:";
            // 
            // WeekdaysControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WDParsingGroupBox);
            Name = "WeekdaysControl";
            Size = new Size(464, 226);
            WDParsingGroupBox.ResumeLayout(false);
            WDParsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WDParsingGroupBox;
        private Label OutputParseLabel;
        private TextBox ParseValuetxtbox;
        private Button ParseButton;
        private Label ParseLabel;
    }
}
