namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ClearButton = new Button();
            label2 = new Label();
            label1 = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            FullNameLabel = new Label();
            idLabel = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClearButton.Location = new Point(259, 478);
            ClearButton.MaximumSize = new Size(125, 50);
            ClearButton.MinimumSize = new Size(60, 30);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(122, 50);
            ClearButton.TabIndex = 35;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(423, 1);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 34;
            label2.Text = "Selected Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 33;
            label1.Text = "Customer";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(131, 478);
            RemoveButton.MaximumSize = new Size(125, 50);
            RemoveButton.MinimumSize = new Size(60, 30);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(122, 50);
            RemoveButton.TabIndex = 32;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(3, 478);
            AddButton.MaximumSize = new Size(125, 50);
            AddButton.MinimumSize = new Size(60, 30);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(122, 50);
            AddButton.TabIndex = 31;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(3, 24);
            CustomersListBox.MaximumSize = new Size(450, 444);
            CustomersListBox.MinimumSize = new Size(300, 380);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(378, 444);
            CustomersListBox.TabIndex = 30;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged_1;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(507, 61);
            FullNameTextBox.MinimumSize = new Size(120, 30);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(507, 30);
            FullNameTextBox.TabIndex = 26;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(507, 24);
            IdTextBox.MinimumSize = new Size(120, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(231, 30);
            IdTextBox.TabIndex = 24;
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(424, 71);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(76, 20);
            FullNameLabel.TabIndex = 23;
            FullNameLabel.Text = "Full name:";
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(424, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 20);
            idLabel.TabIndex = 22;
            idLabel.Text = "Id:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(CustomersListBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(FullNameLabel);
            Controls.Add(idLabel);
            Name = "CustomersTab";
            Size = new Size(1059, 549);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Label label2;
        private Label label1;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox CustomersListBox;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private Label FullNameLabel;
        private Label idLabel;
    }
}
