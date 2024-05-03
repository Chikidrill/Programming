namespace ProgrammingIndividualTask.View.Panels
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Size = new Size(485, 199);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected song";
            // 
            // GenreComboBox
            // 
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(151, 153);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(315, 28);
            GenreComboBox.TabIndex = 7;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(151, 120);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(315, 27);
            DurationTextBox.TabIndex = 6;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // ArtistNameTextBox
            // 
            ArtistNameTextBox.Location = new Point(151, 87);
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
            label4.Location = new Point(7, 156);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Genre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 123);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Duration (sec):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 90);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Artist name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 57);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Song name:";
            // 
            // DelSongButton
            // 
            DelSongButton.Location = new Point(660, 264);
            DelSongButton.Name = "DelSongButton";
            DelSongButton.Size = new Size(169, 29);
            DelSongButton.TabIndex = 6;
            DelSongButton.Text = "Delete Song";
            DelSongButton.UseVisualStyleBackColor = true;
            DelSongButton.Click += DelSongButton_Click;
            // 
            // AddSongButton
            // 
            AddSongButton.Location = new Point(342, 264);
            AddSongButton.Name = "AddSongButton";
            AddSongButton.Size = new Size(169, 29);
            AddSongButton.TabIndex = 5;
            AddSongButton.Text = "Add Song";
            AddSongButton.UseVisualStyleBackColor = true;
            AddSongButton.Click += AddSongButton_Click;
            // 
            // SongsListBox
            // 
            SongsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SongsListBox.FormattingEnabled = true;
            SongsListBox.ItemHeight = 20;
            SongsListBox.Location = new Point(18, 22);
            SongsListBox.Name = "SongsListBox";
            SongsListBox.Size = new Size(300, 444);
            SongsListBox.TabIndex = 4;
            SongsListBox.Click += SongsListBox_Click;
            SongsListBox.SelectedIndexChanged += SongsListBox_SelectedIndexChanged;
            // 
            // SongControlPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
