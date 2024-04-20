namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            rectgroupbox.SuspendLayout();
            SuspendLayout();
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
            rectgroupbox.Dock = DockStyle.Fill;
            rectgroupbox.Location = new Point(0, 0);
            rectgroupbox.Name = "rectgroupbox";
            rectgroupbox.Size = new Size(381, 508);
            rectgroupbox.TabIndex = 1;
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
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rectgroupbox);
            Name = "RectanglesControl";
            Size = new Size(381, 508);
            rectgroupbox.ResumeLayout(false);
            rectgroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox rectgroupbox;
        private TextBox idtxtbox;
        private Label idlabel;
        private Label label2;
        private Label xcenterlabel;
        private TextBox ycentertxtbox;
        private TextBox xcentertxtbox;
        private Button findbtn;
        private ListBox rectangle_listbox;
        private TextBox colortxtbox;
        private TextBox widthtxtbox;
        private TextBox lengthtxtbox;
        private Label lengthlabel;
        private Label widthlabel;
        private Label label1;
    }
}
