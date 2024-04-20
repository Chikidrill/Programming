namespace Programming.View.Panels
{
    partial class FilmsControl
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
            filmgroupbox.SuspendLayout();
            SuspendLayout();
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
            filmgroupbox.Dock = DockStyle.Fill;
            filmgroupbox.Location = new Point(0, 0);
            filmgroupbox.Name = "filmgroupbox";
            filmgroupbox.Size = new Size(381, 478);
            filmgroupbox.TabIndex = 10;
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
            // FilmsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(filmgroupbox);
            Name = "FilmsControl";
            Size = new Size(381, 478);
            filmgroupbox.ResumeLayout(false);
            filmgroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
    }
}
