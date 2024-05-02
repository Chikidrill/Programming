namespace ProgrammingIndividualTask
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
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(28, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 444);
            listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(376, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 211);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected song";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 57);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Song name:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 123);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Duration (sec):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 153);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Genre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(315, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(151, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(315, 27);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(376, 268);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 2;
            button1.Text = "Add Song";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(694, 268);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 3;
            button2.Text = "Delete Song";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(898, 523);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Individual Task";
          //  Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}