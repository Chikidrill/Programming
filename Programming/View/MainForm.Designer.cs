namespace Programming
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            SeasonGroupBox = new GroupBox();
            seasonbtn = new Button();
            SeasonCombobox = new ComboBox();
            ChSeasonLabel = new Label();
            WDParsingGroupBox = new GroupBox();
            OutputParseLabel = new Label();
            ParseValuetxtbox = new TextBox();
            ParseButton = new Button();
            ParseLabel = new Label();
            IntValueLabel = new Label();
            intvaluetxtbox = new TextBox();
            ValueLabel = new Label();
            EnumLabel = new Label();
            ValueListBox = new ListBox();
            EnumsListBox = new ListBox();
            EnumsGroupBox = new GroupBox();
            intvallabel = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WDParsingGroupBox.SuspendLayout();
            EnumsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 584);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SeasonGroupBox);
            tabPage1.Controls.Add(WDParsingGroupBox);
            tabPage1.Controls.Add(IntValueLabel);
            tabPage1.Controls.Add(intvaluetxtbox);
            tabPage1.Controls.Add(ValueLabel);
            tabPage1.Controls.Add(EnumLabel);
            tabPage1.Controls.Add(ValueListBox);
            tabPage1.Controls.Add(EnumsListBox);
            tabPage1.Controls.Add(EnumsGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 551);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(seasonbtn);
            SeasonGroupBox.Controls.Add(SeasonCombobox);
            SeasonGroupBox.Controls.Add(ChSeasonLabel);
            SeasonGroupBox.Location = new Point(421, 367);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(363, 176);
            SeasonGroupBox.TabIndex = 6;
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
            // WDParsingGroupBox
            // 
            WDParsingGroupBox.Controls.Add(OutputParseLabel);
            WDParsingGroupBox.Controls.Add(ParseValuetxtbox);
            WDParsingGroupBox.Controls.Add(ParseButton);
            WDParsingGroupBox.Controls.Add(ParseLabel);
            WDParsingGroupBox.Location = new Point(8, 367);
            WDParsingGroupBox.Name = "WDParsingGroupBox";
            WDParsingGroupBox.Size = new Size(407, 176);
            WDParsingGroupBox.TabIndex = 0;
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
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(452, 44);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(136, 20);
            IntValueLabel.TabIndex = 5;
            IntValueLabel.Text = "Enter integer value:";
            // 
            // intvaluetxtbox
            // 
            intvaluetxtbox.Location = new Point(452, 67);
            intvaluetxtbox.Name = "intvaluetxtbox";
            intvaluetxtbox.Size = new Size(136, 27);
            intvaluetxtbox.TabIndex = 4;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(252, 44);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(100, 20);
            ValueLabel.TabIndex = 3;
            ValueLabel.Text = "Choose value:";
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(28, 44);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(149, 20);
            EnumLabel.TabIndex = 2;
            EnumLabel.Text = "Choose enumeration:";
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.ItemHeight = 20;
            ValueListBox.Location = new Point(252, 67);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Size = new Size(163, 264);
            ValueListBox.TabIndex = 1;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Education Form", "Genre", "Manufacturers", "Season", "Weekday" });
            EnumsListBox.Location = new Point(28, 67);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(163, 264);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumsGroupBox
            // 
            EnumsGroupBox.Controls.Add(intvallabel);
            EnumsGroupBox.Location = new Point(8, 6);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(776, 355);
            EnumsGroupBox.TabIndex = 1;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            // 
            // intvallabel
            // 
            intvallabel.AutoSize = true;
            intvallabel.Location = new Point(444, 100);
            intvallabel.Name = "intvallabel";
            intvallabel.Size = new Size(100, 20);
            intvallabel.TabIndex = 7;
            intvallabel.Text = "Choose value:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming ver. 0.2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            WDParsingGroupBox.ResumeLayout(false);
            WDParsingGroupBox.PerformLayout();
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBox2;
        private ListBox EnumsListBox;
        private ListBox ValueListBox;
        private Label ValueLabel;
        private Label EnumLabel;
        private Label IntValueLabel;
        private TextBox intvaluetxtbox;
        private GroupBox WDParsingGroupBox;
        private Label ParseLabel;
        private GroupBox EnumsGroupBox;
        private Button ParseButton;
        private TextBox ParseValuetxtbox;
        private Label OutputParseLabel;
        private GroupBox SeasonGroupBox;
        private Label ChSeasonLabel;
        private Button seasonbtn;
        private ComboBox SeasonCombobox;
        private Label intvallabel;
    }
}