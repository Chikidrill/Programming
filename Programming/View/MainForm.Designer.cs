﻿namespace Programming
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
            rectanglesTab = new TabPage();
            rectangleCollisionControl1 = new View.Panels.RectangleCollisionControl();
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
            tabPage1 = new TabPage();
            seasonControl1 = new View.Panels.SeasonControl();
            weekdaysControl1 = new View.Panels.WeekdaysControl();
            enumerationsControl1 = new View.Panels.EnumerationsControl();
            tabControl1 = new TabControl();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            rectanglesTab.SuspendLayout();
            classespage.SuspendLayout();
            filmgroupbox.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // rectanglesTab
            // 
            rectanglesTab.Controls.Add(rectangleCollisionControl1);
            rectanglesTab.Location = new Point(4, 29);
            rectanglesTab.Name = "rectanglesTab";
            rectanglesTab.Padding = new Padding(3);
            rectanglesTab.Size = new Size(792, 551);
            rectanglesTab.TabIndex = 2;
            rectanglesTab.Text = "Rectangles";
            rectanglesTab.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            rectangleCollisionControl1.Dock = DockStyle.Fill;
            rectangleCollisionControl1.Location = new Point(3, 3);
            rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            rectangleCollisionControl1.Size = new Size(786, 545);
            rectangleCollisionControl1.TabIndex = 0;
            // 
            // classespage
            // 
            classespage.Controls.Add(rectanglesControl1);
            classespage.Controls.Add(filmgroupbox);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(seasonControl1);
            tabPage1.Controls.Add(weekdaysControl1);
            tabPage1.Controls.Add(enumerationsControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 551);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // seasonControl1
            // 
            seasonControl1.Location = new Point(419, 367);
            seasonControl1.Name = "seasonControl1";
            seasonControl1.Size = new Size(365, 176);
            seasonControl1.TabIndex = 9;
            // 
            // weekdaysControl1
            // 
            weekdaysControl1.Location = new Point(8, 367);
            weekdaysControl1.Name = "weekdaysControl1";
            weekdaysControl1.Size = new Size(405, 176);
            weekdaysControl1.TabIndex = 8;
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.BackColor = Color.Transparent;
            enumerationsControl1.Location = new Point(8, 8);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(776, 353);
            enumerationsControl1.TabIndex = 7;
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
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(8, 26);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(376, 459);
            rectanglesControl1.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming ver. 0.2";
            rectanglesTab.ResumeLayout(false);
            classespage.ResumeLayout(false);
            filmgroupbox.ResumeLayout(false);
            filmgroupbox.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox2;
        private TabPage rectanglesTab;
        private TabPage classespage;
        private GroupBox filmgroupbox;
        private TextBox ratingtxtbox;
        private Label ratinglabel;
        private Label genrelabel;
        private TextBox genretxtbox;
        private Button buttonfilms;
        private ListBox films_listbox;
        private TextBox releaseyeartxtbox;
        private TextBox durationminutestxtbox;
        private TextBox titletxtbox;
        private Label titlelabel;
        private Label durationlabel;
        private Label yearlabel;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private View.Panels.RectangleCollisionControl rectangleCollisionControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private View.Panels.WeekdaysControl weekdaysControl1;
        private View.Panels.SeasonControl seasonControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
    }
}