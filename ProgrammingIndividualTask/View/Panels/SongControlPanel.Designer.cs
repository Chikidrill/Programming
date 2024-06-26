﻿namespace ProgrammingIndividualTask.View.Panels
{
    partial class SongControlPanel
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
            groupBox1 = new GroupBox();
            GenreErrorlabel = new Label();
            DurationErrorlabel = new Label();
            ArtistNameErrorlabel = new Label();
            SongNameErrorlabel = new Label();
            GenreComboBox = new ComboBox();
            DurationTextBox = new TextBox();
            ArtistNameTextBox = new TextBox();
            SongNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DelSongButton = new Button();
            AddSongButton = new Button();
            SongsListBox = new ListBox();
            ClearSelectedButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(GenreErrorlabel);
            groupBox1.Controls.Add(DurationErrorlabel);
            groupBox1.Controls.Add(ArtistNameErrorlabel);
            groupBox1.Controls.Add(SongNameErrorlabel);
            groupBox1.Controls.Add(GenreComboBox);
            groupBox1.Controls.Add(DurationTextBox);
            groupBox1.Controls.Add(ArtistNameTextBox);
            groupBox1.Controls.Add(SongNameTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(344, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 278);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected song";
            // 
            // GenreErrorlabel
            // 
            GenreErrorlabel.AutoSize = true;
            GenreErrorlabel.BackColor = Color.Transparent;
            GenreErrorlabel.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            GenreErrorlabel.ForeColor = Color.Red;
            GenreErrorlabel.Location = new Point(153, 242);
            GenreErrorlabel.MaximumSize = new Size(330, 0);
            GenreErrorlabel.Name = "GenreErrorlabel";
            GenreErrorlabel.Size = new Size(30, 12);
            GenreErrorlabel.TabIndex = 11;
            GenreErrorlabel.Text = "label5";
            // 
            // DurationErrorlabel
            // 
            DurationErrorlabel.AutoSize = true;
            DurationErrorlabel.BackColor = Color.Transparent;
            DurationErrorlabel.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            DurationErrorlabel.ForeColor = Color.Red;
            DurationErrorlabel.Location = new Point(153, 188);
            DurationErrorlabel.MaximumSize = new Size(330, 0);
            DurationErrorlabel.Name = "DurationErrorlabel";
            DurationErrorlabel.Size = new Size(30, 12);
            DurationErrorlabel.TabIndex = 10;
            DurationErrorlabel.Text = "label5";
            // 
            // ArtistNameErrorlabel
            // 
            ArtistNameErrorlabel.AutoSize = true;
            ArtistNameErrorlabel.BackColor = Color.Transparent;
            ArtistNameErrorlabel.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            ArtistNameErrorlabel.ForeColor = Color.Red;
            ArtistNameErrorlabel.Location = new Point(153, 135);
            ArtistNameErrorlabel.MaximumSize = new Size(330, 0);
            ArtistNameErrorlabel.Name = "ArtistNameErrorlabel";
            ArtistNameErrorlabel.Size = new Size(30, 12);
            ArtistNameErrorlabel.TabIndex = 9;
            ArtistNameErrorlabel.Text = "label5";
            // 
            // SongNameErrorlabel
            // 
            SongNameErrorlabel.AutoSize = true;
            SongNameErrorlabel.BackColor = Color.Transparent;
            SongNameErrorlabel.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            SongNameErrorlabel.ForeColor = Color.Red;
            SongNameErrorlabel.Location = new Point(153, 82);
            SongNameErrorlabel.MaximumSize = new Size(330, 0);
            SongNameErrorlabel.Name = "SongNameErrorlabel";
            SongNameErrorlabel.Size = new Size(30, 12);
            SongNameErrorlabel.TabIndex = 8;
            SongNameErrorlabel.Text = "label5";
            // 
            // GenreComboBox
            // 
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(153, 211);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(315, 28);
            GenreComboBox.TabIndex = 7;
            GenreComboBox.SelectedIndexChanged += GenreComboBox_SelectedIndexChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(153, 158);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(315, 27);
            DurationTextBox.TabIndex = 6;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // ArtistNameTextBox
            // 
            ArtistNameTextBox.Location = new Point(153, 105);
            ArtistNameTextBox.Name = "ArtistNameTextBox";
            ArtistNameTextBox.Size = new Size(315, 27);
            ArtistNameTextBox.TabIndex = 5;
            ArtistNameTextBox.TextChanged += ArtistNameTextBox_TextChanged;
            // 
            // SongNameTextBox
            // 
            SongNameTextBox.Location = new Point(151, 54);
            SongNameTextBox.Name = "SongNameTextBox";
            SongNameTextBox.Size = new Size(315, 27);
            SongNameTextBox.TabIndex = 4;
            SongNameTextBox.TextChanged += SongNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 214);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Genre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 161);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Duration (sec):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Artist name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 57);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Song name:";
            // 
            // DelSongButton
            // 
            DelSongButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DelSongButton.Location = new Point(699, 329);
            DelSongButton.Name = "DelSongButton";
            DelSongButton.Size = new Size(130, 29);
            DelSongButton.TabIndex = 6;
            DelSongButton.Text = "Delete Song";
            DelSongButton.UseVisualStyleBackColor = true;
            DelSongButton.Click += DelSongButton_Click;
            // 
            // AddSongButton
            // 
            AddSongButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddSongButton.Location = new Point(344, 329);
            AddSongButton.Name = "AddSongButton";
            AddSongButton.Size = new Size(130, 29);
            AddSongButton.TabIndex = 5;
            AddSongButton.Text = "Add Song";
            AddSongButton.UseVisualStyleBackColor = true;
            AddSongButton.Click += AddSongButton_Click;
            // 
            // SongsListBox
            // 
            SongsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SongsListBox.FormattingEnabled = true;
            SongsListBox.ItemHeight = 20;
            SongsListBox.Location = new Point(18, 22);
            SongsListBox.Name = "SongsListBox";
            SongsListBox.Size = new Size(300, 444);
            SongsListBox.TabIndex = 4;
            SongsListBox.SelectedIndexChanged += SongsListBox_SelectedIndexChanged;
            // 
            // ClearSelectedButton
            // 
            ClearSelectedButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearSelectedButton.Location = new Point(522, 329);
            ClearSelectedButton.Name = "ClearSelectedButton";
            ClearSelectedButton.Size = new Size(130, 29);
            ClearSelectedButton.TabIndex = 7;
            ClearSelectedButton.Text = "Clear Selected";
            ClearSelectedButton.UseVisualStyleBackColor = true;
            ClearSelectedButton.Click += ClearSelectedButton_Click;
            // 
            // SongControlPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearSelectedButton);
            Controls.Add(DelSongButton);
            Controls.Add(AddSongButton);
            Controls.Add(SongsListBox);
            Controls.Add(groupBox1);
            Name = "SongControlPanel";
            Size = new Size(866, 484);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox DurationTextBox;
        private TextBox ArtistNameTextBox;
        private TextBox SongNameTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox GenreComboBox;
        private Button DelSongButton;
        private Button AddSongButton;
        private ListBox SongsListBox;
        private Button ClearSelectedButton;
        private VScrollBar vScrollBar1;
        private Label GenreErrorlabel;
        private Label DurationErrorlabel;
        private Label ArtistNameErrorlabel;
        private Label SongNameErrorlabel;
    }
}
