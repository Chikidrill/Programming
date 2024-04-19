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
            classespage = new TabPage();
            filmgroupbox = new GroupBox();
            ratingtxtbox = new TextBox();
            ratinglabel = new Label();
            genrelabel = new Label();
            genretxtbox = new TextBox();
            buttonfilms = new Button();
            films_listbox = new ListBox();
            releaseyeartxtbox = new TextBox();
            durationminutestxtbox = new TextBox();
            titletxtbox = new TextBox();
            titlelabel = new Label();
            durationlabel = new Label();
            yearlabel = new Label();
            rectgroupbox = new GroupBox();
            idtxtbox = new TextBox();
            idlabel = new Label();
            label2 = new Label();
            xcenterlabel = new Label();
            ycentertxtbox = new TextBox();
            xcentertxtbox = new TextBox();
            findbtn = new Button();
            rectangle_listbox = new ListBox();
            colortxtbox = new TextBox();
            widthtxtbox = new TextBox();
            lengthtxtbox = new TextBox();
            lengthlabel = new Label();
            widthlabel = new Label();
            label1 = new Label();
            rectanglesTab = new TabPage();
            CanvaLengthTxtBox = new TextBox();
            CanvaWidthTxtBox = new TextBox();
            CanvaYTxtBox = new TextBox();
            CanvaXTxtBox = new TextBox();
            CanvaIdTxtBox = new TextBox();
            CanvaLengthLabel = new Label();
            CanvaWidthLabel = new Label();
            CanvaYLabel = new Label();
            CanvaXLabel = new Label();
            CanvaIdLabel = new Label();
            label3 = new Label();
            DelRecButton = new Button();
            AddRecButton = new Button();
            CanvaRectListBox = new ListBox();
            rectLabel = new Label();
            CanvaRectPanel = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WDParsingGroupBox.SuspendLayout();
            classespage.SuspendLayout();
            filmgroupbox.SuspendLayout();
            rectgroupbox.SuspendLayout();
            rectanglesTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(classespage);
            tabControl1.Controls.Add(rectanglesTab);
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
            ValueListBox.SelectedIndexChanged += ValueListBox_SelectedIndexChanged_1;
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
            EnumsGroupBox.Location = new Point(8, 6);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(776, 355);
            EnumsGroupBox.TabIndex = 1;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            // 
            // classespage
            // 
            classespage.Controls.Add(filmgroupbox);
            classespage.Controls.Add(rectgroupbox);
            classespage.Location = new Point(4, 29);
            classespage.Name = "classespage";
            classespage.Padding = new Padding(3);
            classespage.Size = new Size(792, 551);
            classespage.TabIndex = 1;
            classespage.Text = "Classes";
            classespage.UseVisualStyleBackColor = true;
            // 
            // filmgroupbox
            // 
            filmgroupbox.Controls.Add(ratingtxtbox);
            filmgroupbox.Controls.Add(ratinglabel);
            filmgroupbox.Controls.Add(genrelabel);
            filmgroupbox.Controls.Add(genretxtbox);
            filmgroupbox.Controls.Add(buttonfilms);
            filmgroupbox.Controls.Add(films_listbox);
            filmgroupbox.Controls.Add(releaseyeartxtbox);
            filmgroupbox.Controls.Add(durationminutestxtbox);
            filmgroupbox.Controls.Add(titletxtbox);
            filmgroupbox.Controls.Add(titlelabel);
            filmgroupbox.Controls.Add(durationlabel);
            filmgroupbox.Controls.Add(yearlabel);
            filmgroupbox.Location = new Point(402, 26);
            filmgroupbox.Name = "filmgroupbox";
            filmgroupbox.Size = new Size(364, 459);
            filmgroupbox.TabIndex = 9;
            filmgroupbox.TabStop = false;
            filmgroupbox.Text = "Movie";
            // 
            // ratingtxtbox
            // 
            ratingtxtbox.Location = new Point(199, 266);
            ratingtxtbox.Name = "ratingtxtbox";
            ratingtxtbox.Size = new Size(125, 27);
            ratingtxtbox.TabIndex = 12;
            ratingtxtbox.TextChanged += ratingtxtbox_TextChanged_1;
            // 
            // ratinglabel
            // 
            ratinglabel.AutoSize = true;
            ratinglabel.Location = new Point(199, 243);
            ratinglabel.Name = "ratinglabel";
            ratinglabel.Size = new Size(55, 20);
            ratinglabel.TabIndex = 11;
            ratinglabel.Text = "Rating:";
            // 
            // genrelabel
            // 
            genrelabel.AutoSize = true;
            genrelabel.Location = new Point(199, 190);
            genrelabel.Name = "genrelabel";
            genrelabel.Size = new Size(51, 20);
            genrelabel.TabIndex = 10;
            genrelabel.Text = "Genre:";
            // 
            // genretxtbox
            // 
            genretxtbox.Location = new Point(199, 213);
            genretxtbox.Name = "genretxtbox";
            genretxtbox.Size = new Size(125, 27);
            genretxtbox.TabIndex = 9;
            genretxtbox.TextChanged += genretxtbox_TextChanged_1;
            // 
            // buttonfilms
            // 
            buttonfilms.Location = new Point(199, 346);
            buttonfilms.Name = "buttonfilms";
            buttonfilms.Size = new Size(125, 29);
            buttonfilms.TabIndex = 8;
            buttonfilms.Text = "Find";
            buttonfilms.UseVisualStyleBackColor = true;
            buttonfilms.Click += buttonfilms_Click_1;
            // 
            // films_listbox
            // 
            films_listbox.FormattingEnabled = true;
            films_listbox.ItemHeight = 20;
            films_listbox.Location = new Point(18, 31);
            films_listbox.Name = "films_listbox";
            films_listbox.Size = new Size(150, 344);
            films_listbox.TabIndex = 7;
            films_listbox.SelectedIndexChanged += films_listbox_SelectedIndexChanged;
            // 
            // releaseyeartxtbox
            // 
            releaseyeartxtbox.Location = new Point(199, 160);
            releaseyeartxtbox.Name = "releaseyeartxtbox";
            releaseyeartxtbox.Size = new Size(125, 27);
            releaseyeartxtbox.TabIndex = 6;
            releaseyeartxtbox.TextChanged += releaseyeartxtbox_TextChanged_1;
            // 
            // durationminutestxtbox
            // 
            durationminutestxtbox.Location = new Point(199, 107);
            durationminutestxtbox.Name = "durationminutestxtbox";
            durationminutestxtbox.Size = new Size(125, 27);
            durationminutestxtbox.TabIndex = 5;
            durationminutestxtbox.TextChanged += durationminutestxtbox_TextChanged_1;
            // 
            // titletxtbox
            // 
            titletxtbox.Location = new Point(199, 54);
            titletxtbox.Name = "titletxtbox";
            titletxtbox.Size = new Size(125, 27);
            titletxtbox.TabIndex = 4;
            titletxtbox.TextChanged += titletxtbox_TextChanged_1;
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            titlelabel.Location = new Point(199, 31);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(41, 20);
            titlelabel.TabIndex = 2;
            titlelabel.Text = "Title:";
            // 
            // durationlabel
            // 
            durationlabel.AutoSize = true;
            durationlabel.Location = new Point(199, 84);
            durationlabel.Name = "durationlabel";
            durationlabel.Size = new Size(142, 20);
            durationlabel.TabIndex = 1;
            durationlabel.Text = "Duration in minutes:";
            // 
            // yearlabel
            // 
            yearlabel.AutoSize = true;
            yearlabel.Location = new Point(199, 137);
            yearlabel.Name = "yearlabel";
            yearlabel.Size = new Size(113, 20);
            yearlabel.TabIndex = 0;
            yearlabel.Text = "Year of Release:";
            // 
            // rectgroupbox
            // 
            rectgroupbox.Controls.Add(idtxtbox);
            rectgroupbox.Controls.Add(idlabel);
            rectgroupbox.Controls.Add(label2);
            rectgroupbox.Controls.Add(xcenterlabel);
            rectgroupbox.Controls.Add(ycentertxtbox);
            rectgroupbox.Controls.Add(xcentertxtbox);
            rectgroupbox.Controls.Add(findbtn);
            rectgroupbox.Controls.Add(rectangle_listbox);
            rectgroupbox.Controls.Add(colortxtbox);
            rectgroupbox.Controls.Add(widthtxtbox);
            rectgroupbox.Controls.Add(lengthtxtbox);
            rectgroupbox.Controls.Add(lengthlabel);
            rectgroupbox.Controls.Add(widthlabel);
            rectgroupbox.Controls.Add(label1);
            rectgroupbox.Location = new Point(18, 26);
            rectgroupbox.Name = "rectgroupbox";
            rectgroupbox.Size = new Size(364, 459);
            rectgroupbox.TabIndex = 0;
            rectgroupbox.TabStop = false;
            rectgroupbox.Text = "Rectangle";
            // 
            // idtxtbox
            // 
            idtxtbox.Location = new Point(203, 54);
            idtxtbox.Name = "idtxtbox";
            idtxtbox.ReadOnly = true;
            idtxtbox.Size = new Size(125, 27);
            idtxtbox.TabIndex = 14;
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(203, 31);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(25, 20);
            idlabel.TabIndex = 13;
            idlabel.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 309);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 12;
            label2.Text = "Y-cord of center";
            // 
            // xcenterlabel
            // 
            xcenterlabel.AutoSize = true;
            xcenterlabel.Location = new Point(203, 256);
            xcenterlabel.Name = "xcenterlabel";
            xcenterlabel.Size = new Size(117, 20);
            xcenterlabel.TabIndex = 11;
            xcenterlabel.Text = "X-cord of center";
            // 
            // ycentertxtbox
            // 
            ycentertxtbox.Location = new Point(203, 332);
            ycentertxtbox.Name = "ycentertxtbox";
            ycentertxtbox.ReadOnly = true;
            ycentertxtbox.Size = new Size(125, 27);
            ycentertxtbox.TabIndex = 10;
            // 
            // xcentertxtbox
            // 
            xcentertxtbox.Location = new Point(203, 279);
            xcentertxtbox.Name = "xcentertxtbox";
            xcentertxtbox.ReadOnly = true;
            xcentertxtbox.Size = new Size(125, 27);
            xcentertxtbox.TabIndex = 9;
            // 
            // findbtn
            // 
            findbtn.Location = new Point(203, 378);
            findbtn.Name = "findbtn";
            findbtn.Size = new Size(125, 29);
            findbtn.TabIndex = 8;
            findbtn.Text = "Find";
            findbtn.UseVisualStyleBackColor = true;
            findbtn.Click += findbtn_Click;
            // 
            // rectangle_listbox
            // 
            rectangle_listbox.FormattingEnabled = true;
            rectangle_listbox.ItemHeight = 20;
            rectangle_listbox.Location = new Point(18, 31);
            rectangle_listbox.Name = "rectangle_listbox";
            rectangle_listbox.Size = new Size(150, 344);
            rectangle_listbox.TabIndex = 7;
            rectangle_listbox.SelectedIndexChanged += rectangle_listbox_SelectedIndexChanged_1;
            // 
            // colortxtbox
            // 
            colortxtbox.Location = new Point(203, 216);
            colortxtbox.Name = "colortxtbox";
            colortxtbox.Size = new Size(125, 27);
            colortxtbox.TabIndex = 6;
            // 
            // widthtxtbox
            // 
            widthtxtbox.Location = new Point(203, 163);
            widthtxtbox.Name = "widthtxtbox";
            widthtxtbox.Size = new Size(125, 27);
            widthtxtbox.TabIndex = 5;
            widthtxtbox.TextChanged += widthtxtbox_TextChanged_1;
            // 
            // lengthtxtbox
            // 
            lengthtxtbox.Location = new Point(203, 110);
            lengthtxtbox.Name = "lengthtxtbox";
            lengthtxtbox.Size = new Size(125, 27);
            lengthtxtbox.TabIndex = 4;
            lengthtxtbox.TextChanged += lengthtxtbox_TextChanged_1;
            // 
            // lengthlabel
            // 
            lengthlabel.AutoSize = true;
            lengthlabel.Location = new Point(203, 87);
            lengthlabel.Name = "lengthlabel";
            lengthlabel.Size = new Size(57, 20);
            lengthlabel.TabIndex = 2;
            lengthlabel.Text = "Length:";
            // 
            // widthlabel
            // 
            widthlabel.AutoSize = true;
            widthlabel.Location = new Point(203, 140);
            widthlabel.Name = "widthlabel";
            widthlabel.Size = new Size(52, 20);
            widthlabel.TabIndex = 1;
            widthlabel.Text = "Width:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 193);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Color:";
            // 
            // rectanglesTab
            // 
            rectanglesTab.Controls.Add(CanvaLengthTxtBox);
            rectanglesTab.Controls.Add(CanvaWidthTxtBox);
            rectanglesTab.Controls.Add(CanvaYTxtBox);
            rectanglesTab.Controls.Add(CanvaXTxtBox);
            rectanglesTab.Controls.Add(CanvaIdTxtBox);
            rectanglesTab.Controls.Add(CanvaLengthLabel);
            rectanglesTab.Controls.Add(CanvaWidthLabel);
            rectanglesTab.Controls.Add(CanvaYLabel);
            rectanglesTab.Controls.Add(CanvaXLabel);
            rectanglesTab.Controls.Add(CanvaIdLabel);
            rectanglesTab.Controls.Add(label3);
            rectanglesTab.Controls.Add(DelRecButton);
            rectanglesTab.Controls.Add(AddRecButton);
            rectanglesTab.Controls.Add(CanvaRectListBox);
            rectanglesTab.Controls.Add(rectLabel);
            rectanglesTab.Controls.Add(CanvaRectPanel);
            rectanglesTab.Location = new Point(4, 29);
            rectanglesTab.Name = "rectanglesTab";
            rectanglesTab.Padding = new Padding(3);
            rectanglesTab.Size = new Size(792, 551);
            rectanglesTab.TabIndex = 2;
            rectanglesTab.Text = "Rectangles";
            rectanglesTab.UseVisualStyleBackColor = true;
            // 
            // CanvaLengthTxtBox
            // 
            CanvaLengthTxtBox.Location = new Point(144, 479);
            CanvaLengthTxtBox.Name = "CanvaLengthTxtBox";
            CanvaLengthTxtBox.Size = new Size(125, 27);
            CanvaLengthTxtBox.TabIndex = 15;
            CanvaLengthTxtBox.TextChanged += CanvaLengthTxtBox_TextChanged;
            // 
            // CanvaWidthTxtBox
            // 
            CanvaWidthTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CanvaWidthTxtBox.Location = new Point(144, 446);
            CanvaWidthTxtBox.Name = "CanvaWidthTxtBox";
            CanvaWidthTxtBox.Size = new Size(125, 27);
            CanvaWidthTxtBox.TabIndex = 14;
            CanvaWidthTxtBox.TextChanged += CanvaWidthTxtBox_TextChanged;
            // 
            // CanvaYTxtBox
            // 
            CanvaYTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CanvaYTxtBox.Location = new Point(144, 413);
            CanvaYTxtBox.Name = "CanvaYTxtBox";
            CanvaYTxtBox.Size = new Size(125, 27);
            CanvaYTxtBox.TabIndex = 13;
            // 
            // CanvaXTxtBox
            // 
            CanvaXTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CanvaXTxtBox.Location = new Point(144, 380);
            CanvaXTxtBox.Name = "CanvaXTxtBox";
            CanvaXTxtBox.Size = new Size(125, 27);
            CanvaXTxtBox.TabIndex = 12;
            // 
            // CanvaIdTxtBox
            // 
            CanvaIdTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CanvaIdTxtBox.Location = new Point(144, 347);
            CanvaIdTxtBox.Name = "CanvaIdTxtBox";
            CanvaIdTxtBox.ReadOnly = true;
            CanvaIdTxtBox.Size = new Size(125, 27);
            CanvaIdTxtBox.TabIndex = 11;
            // 
            // CanvaLengthLabel
            // 
            CanvaLengthLabel.AutoSize = true;
            CanvaLengthLabel.Location = new Point(86, 482);
            CanvaLengthLabel.Name = "CanvaLengthLabel";
            CanvaLengthLabel.Size = new Size(57, 20);
            CanvaLengthLabel.TabIndex = 10;
            CanvaLengthLabel.Text = "Length:";
            // 
            // CanvaWidthLabel
            // 
            CanvaWidthLabel.AutoSize = true;
            CanvaWidthLabel.Location = new Point(90, 449);
            CanvaWidthLabel.Name = "CanvaWidthLabel";
            CanvaWidthLabel.Size = new Size(52, 20);
            CanvaWidthLabel.TabIndex = 9;
            CanvaWidthLabel.Text = "Width:";
            // 
            // CanvaYLabel
            // 
            CanvaYLabel.AutoSize = true;
            CanvaYLabel.Location = new Point(46, 416);
            CanvaYLabel.Name = "CanvaYLabel";
            CanvaYLabel.Size = new Size(96, 20);
            CanvaYLabel.TabIndex = 8;
            CanvaYLabel.Text = "Y coordinate:";
            // 
            // CanvaXLabel
            // 
            CanvaXLabel.AutoSize = true;
            CanvaXLabel.Location = new Point(46, 383);
            CanvaXLabel.Name = "CanvaXLabel";
            CanvaXLabel.Size = new Size(97, 20);
            CanvaXLabel.TabIndex = 7;
            CanvaXLabel.Text = "X coordinate:";
            // 
            // CanvaIdLabel
            // 
            CanvaIdLabel.AutoSize = true;
            CanvaIdLabel.Location = new Point(118, 350);
            CanvaIdLabel.Name = "CanvaIdLabel";
            CanvaIdLabel.Size = new Size(25, 20);
            CanvaIdLabel.TabIndex = 6;
            CanvaIdLabel.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 308);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 5;
            label3.Text = "Selected rectangle:";
            // 
            // DelRecButton
            // 
            DelRecButton.FlatStyle = FlatStyle.Flat;
            DelRecButton.Location = new Point(206, 253);
            DelRecButton.Name = "DelRecButton";
            DelRecButton.Size = new Size(144, 29);
            DelRecButton.TabIndex = 4;
            DelRecButton.Text = "Delete rectangle";
            DelRecButton.UseVisualStyleBackColor = true;
            DelRecButton.Click += DelRecButton_Click;
            // 
            // AddRecButton
            // 
            AddRecButton.FlatStyle = FlatStyle.Flat;
            AddRecButton.Location = new Point(8, 253);
            AddRecButton.Name = "AddRecButton";
            AddRecButton.Size = new Size(144, 29);
            AddRecButton.TabIndex = 3;
            AddRecButton.Text = "Add rectangle";
            AddRecButton.UseVisualStyleBackColor = true;
            AddRecButton.Click += AddRecButton_Click;
            // 
            // CanvaRectListBox
            // 
            CanvaRectListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CanvaRectListBox.FormattingEnabled = true;
            CanvaRectListBox.ItemHeight = 20;
            CanvaRectListBox.Location = new Point(8, 29);
            CanvaRectListBox.Name = "CanvaRectListBox";
            CanvaRectListBox.Size = new Size(342, 204);
            CanvaRectListBox.TabIndex = 2;
            CanvaRectListBox.SelectedIndexChanged += CanvaRectListBox_SelectedIndexChanged;
            // 
            // rectLabel
            // 
            rectLabel.AutoSize = true;
            rectLabel.Location = new Point(8, 6);
            rectLabel.Name = "rectLabel";
            rectLabel.Size = new Size(84, 20);
            rectLabel.TabIndex = 1;
            rectLabel.Text = "Rectangles:";
            // 
            // CanvaRectPanel
            // 
            CanvaRectPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CanvaRectPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvaRectPanel.Location = new Point(356, 6);
            CanvaRectPanel.Name = "CanvaRectPanel";
            CanvaRectPanel.Size = new Size(428, 537);
            CanvaRectPanel.TabIndex = 0;
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
            classespage.ResumeLayout(false);
            filmgroupbox.ResumeLayout(false);
            filmgroupbox.PerformLayout();
            rectgroupbox.ResumeLayout(false);
            rectgroupbox.PerformLayout();
            rectanglesTab.ResumeLayout(false);
            rectanglesTab.PerformLayout();
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
        private TabPage classespage;
        private GroupBox rectgroupbox;
        private TextBox lengthtxtbox;
        private Label lengthlabel;
        private Label widthlabel;
        private Label label1;
        private TextBox colortxtbox;
        private TextBox widthtxtbox;
        private Button findbtn;
        private ListBox rectangle_listbox;
        private GroupBox filmgroupbox;
        private Button buttonfilms;
        private ListBox films_listbox;
        private TextBox releaseyeartxtbox;
        private TextBox durationminutestxtbox;
        private TextBox titletxtbox;
        private Label titlelabel;
        private Label durationlabel;
        private Label yearlabel;
        private TextBox genretxtbox;
        private Label genrelabel;
        private Label ratinglabel;
        private TextBox ratingtxtbox;
        private Label xcenterlabel;
        private TextBox ycentertxtbox;
        private TextBox xcentertxtbox;
        private Label label2;
        private TextBox idtxtbox;
        private Label idlabel;
        private TabPage rectanglesTab;
        private Panel CanvaRectPanel;
        private ListBox CanvaRectListBox;
        private Label rectLabel;
        private Button AddRecButton;
        private Label CanvaLengthLabel;
        private Label CanvaWidthLabel;
        private Label CanvaYLabel;
        private Label CanvaXLabel;
        private Label CanvaIdLabel;
        private Label label3;
        private Button DelRecButton;
        private TextBox CanvaLengthTxtBox;
        private TextBox CanvaWidthTxtBox;
        private TextBox CanvaYTxtBox;
        private TextBox CanvaXTxtBox;
        private TextBox CanvaIdTxtBox;
    }
}