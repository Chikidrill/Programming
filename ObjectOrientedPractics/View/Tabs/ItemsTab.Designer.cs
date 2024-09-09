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
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(434, 117);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(433, 140);
            NameTextBox.MaximumSize = new Size(0, 120);
            NameTextBox.MinimumSize = new Size(270, 40);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(591, 120);
            NameTextBox.TabIndex = 14;
            NameTextBox.Text = "";
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(434, 263);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Description:";
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.Location = new Point(499, 66);
            CostTextBox.MinimumSize = new Size(120, 30);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(231, 30);
            CostTextBox.TabIndex = 12;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(433, 286);
            DescriptionTextBox.MaximumSize = new Size(0, 120);
            DescriptionTextBox.MinimumSize = new Size(270, 40);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(591, 120);
            DescriptionTextBox.TabIndex = 11;
            DescriptionTextBox.Text = "";
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(499, 26);
            IdTextBox.MinimumSize = new Size(120, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(231, 30);
            IdTextBox.TabIndex = 10;
            // 
            // costLabel
            // 
            costLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            costLabel.AutoSize = true;
            costLabel.Location = new Point(434, 73);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(41, 20);
            costLabel.TabIndex = 9;
            costLabel.Text = "Cost:";
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(434, 33);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 20);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id:";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(141, 480);
            RemoveButton.MaximumSize = new Size(125, 50);
            RemoveButton.MinimumSize = new Size(60, 30);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(122, 50);
            RemoveButton.TabIndex = 18;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(13, 480);
            AddButton.MaximumSize = new Size(125, 50);
            AddButton.MinimumSize = new Size(60, 30);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(122, 50);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(13, 26);
            ItemsListBox.MaximumSize = new Size(450, 444);
            ItemsListBox.MinimumSize = new Size(300, 380);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(378, 444);
            ItemsListBox.TabIndex = 16;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 3);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 19;
            label1.Text = "Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(433, 3);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 20;
            label2.Text = "Items";
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClearButton.Location = new Point(269, 480);
            ClearButton.MaximumSize = new Size(125, 50);
            ClearButton.MinimumSize = new Size(60, 30);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(122, 50);
            ClearButton.TabIndex = 21;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ItemsListBox);
            Controls.Add(nameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(CostTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(costLabel);
            Controls.Add(idLabel);
            Name = "ItemsTab";
            Size = new Size(1059, 549);
            ResumeLayout(false);
            PerformLayout();
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
    }
}
