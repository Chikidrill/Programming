namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            nameLabel = new Label();
            NameTextBox = new RichTextBox();
            descriptionLabel = new Label();
            CostTextBox = new TextBox();
            DescriptionTextBox = new RichTextBox();
            IdTextBox = new TextBox();
            costLabel = new Label();
            idLabel = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            ClearButton = new Button();
            label3 = new Label();
            CategoryComboBox = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(8, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(8, 32);
            NameTextBox.MaximumSize = new Size(0, 420);
            NameTextBox.MinimumSize = new Size(270, 40);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(388, 102);
            NameTextBox.TabIndex = 14;
            NameTextBox.Text = "";
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(8, 153);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Description:";
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.Location = new Point(95, 71);
            CostTextBox.MinimumSize = new Size(120, 30);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(233, 30);
            CostTextBox.TabIndex = 12;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(8, 176);
            DescriptionTextBox.MaximumSize = new Size(0, 420);
            DescriptionTextBox.MinimumSize = new Size(270, 40);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(388, 153);
            DescriptionTextBox.TabIndex = 11;
            DescriptionTextBox.Text = "";
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(95, 31);
            IdTextBox.MinimumSize = new Size(120, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(233, 30);
            IdTextBox.TabIndex = 10;
            // 
            // costLabel
            // 
            costLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            costLabel.AutoSize = true;
            costLabel.Location = new Point(4, 81);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(41, 20);
            costLabel.TabIndex = 9;
            costLabel.Text = "Cost:";
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(4, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 20);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id:";
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(134, 400);
            RemoveButton.MaximumSize = new Size(125, 50);
            RemoveButton.MinimumSize = new Size(60, 30);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(125, 50);
            RemoveButton.TabIndex = 18;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(4, 400);
            AddButton.MaximumSize = new Size(125, 50);
            AddButton.MinimumSize = new Size(60, 30);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(125, 50);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 30);
            ItemsListBox.MinimumSize = new Size(300, 380);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(387, 364);
            ItemsListBox.TabIndex = 16;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 19;
            label1.Text = "Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 20;
            label2.Text = "Selected item";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(265, 400);
            ClearButton.MaximumSize = new Size(125, 50);
            ClearButton.MinimumSize = new Size(60, 30);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(125, 50);
            ClearButton.TabIndex = 21;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 121);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 22;
            label3.Text = "Category: ";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(95, 113);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(233, 28);
            CategoryComboBox.TabIndex = 23;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(RemoveButton);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 521);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(idLabel);
            panel2.Controls.Add(CategoryComboBox);
            panel2.Controls.Add(costLabel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(CostTextBox);
            panel2.Location = new Point(434, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 162);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(nameLabel);
            panel3.Controls.Add(NameTextBox);
            panel3.Controls.Add(descriptionLabel);
            panel3.Controls.Add(DescriptionTextBox);
            panel3.Location = new Point(432, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(518, 353);
            panel3.TabIndex = 26;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ItemsTab";
            Size = new Size(990, 571);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label nameLabel;
        private RichTextBox NameTextBox;
        private Label descriptionLabel;
        private TextBox CostTextBox;
        private RichTextBox DescriptionTextBox;
        private TextBox IdTextBox;
        private Label costLabel;
        private Label idLabel;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private Label label1;
        private Label label2;
        private Button ClearButton;
        private Label label3;
        private ComboBox CategoryComboBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
