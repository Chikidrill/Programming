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
            rectanglesTab = new TabPage();
            rectangleCollisionControl1 = new View.Panels.RectangleCollisionControl();
            classespage = new TabPage();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            tabPage1 = new TabPage();
            seasonControl1 = new View.Panels.SeasonControl();
            weekdaysControl1 = new View.Panels.WeekdaysControl();
            enumerationsControl1 = new View.Panels.EnumerationsControl();
            tabControl1 = new TabControl();
            filmsControl1 = new View.Panels.FilmsControl();
            rectanglesTab.SuspendLayout();
            classespage.SuspendLayout();
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
            classespage.Controls.Add(filmsControl1);
            classespage.Controls.Add(rectanglesControl1);
            classespage.Location = new Point(4, 29);
            classespage.Name = "classespage";
            classespage.Padding = new Padding(3);
            classespage.Size = new Size(792, 551);
            classespage.TabIndex = 1;
            classespage.Text = "Classes";
            classespage.UseVisualStyleBackColor = true;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(8, 26);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(376, 459);
            rectanglesControl1.TabIndex = 10;
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
            // filmsControl1
            // 
            filmsControl1.Location = new Point(403, 26);
            filmsControl1.Name = "filmsControl1";
            filmsControl1.Size = new Size(383, 459);
            filmsControl1.TabIndex = 11;
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
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage rectanglesTab;
        private TabPage classespage;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private View.Panels.RectangleCollisionControl rectangleCollisionControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private View.Panels.WeekdaysControl weekdaysControl1;
        private View.Panels.SeasonControl seasonControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.FilmsControl filmsControl1;
    }
}