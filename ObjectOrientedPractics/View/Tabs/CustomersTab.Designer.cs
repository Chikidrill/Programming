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
            panel1 = new Panel();
            panel2 = new Panel();
            isPriorityCheckBox = new CheckBox();
            DiscountsListBox = new ListBox();
            AddDiscountButton = new Button();
            RemoveDiscountButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClearButton.Location = new Point(274, 465);
            ClearButton.MinimumSize = new Size(60, 30);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(125, 51);
            ClearButton.TabIndex = 35;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 34;
            label2.Text = "Selected Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 33;
            label1.Text = "Customer";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(143, 465);
            RemoveButton.MinimumSize = new Size(60, 30);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(125, 51);
            RemoveButton.TabIndex = 32;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(12, 465);
            AddButton.MinimumSize = new Size(60, 30);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(125, 51);
            AddButton.TabIndex = 31;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(12, 32);
            CustomersListBox.MaximumSize = new Size(1000, 600);
            CustomersListBox.MinimumSize = new Size(300, 380);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(387, 424);
            CustomersListBox.TabIndex = 30;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged_1;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(87, 60);
            FullNameTextBox.MinimumSize = new Size(120, 30);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(503, 30);
            FullNameTextBox.TabIndex = 26;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(87, 23);
            IdTextBox.MinimumSize = new Size(120, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(503, 30);
            IdTextBox.TabIndex = 24;
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(4, 70);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(76, 20);
            FullNameLabel.TabIndex = 23;
            FullNameLabel.Text = "Full name:";
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(4, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 20);
            idLabel.TabIndex = 22;
            idLabel.Text = "Id:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(CustomersListBox);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(RemoveButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 556);
            panel1.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(isPriorityCheckBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(idLabel);
            panel2.Controls.Add(FullNameLabel);
            panel2.Controls.Add(FullNameTextBox);
            panel2.Controls.Add(IdTextBox);
            panel2.Location = new Point(424, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 125);
            panel2.TabIndex = 37;
            // 
            // isPriorityCheckBox
            // 
            isPriorityCheckBox.AutoSize = true;
            isPriorityCheckBox.Location = new Point(8, 99);
            isPriorityCheckBox.Name = "isPriorityCheckBox";
            isPriorityCheckBox.Size = new Size(92, 24);
            isPriorityCheckBox.TabIndex = 35;
            isPriorityCheckBox.Text = "Is Priority";
            isPriorityCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.Location = new Point(442, 435);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(294, 124);
            DiscountsListBox.TabIndex = 38;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Location = new Point(824, 430);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(109, 42);
            AddDiscountButton.TabIndex = 39;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Location = new Point(824, 490);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(109, 44);
            RemoveDiscountButton.TabIndex = 40;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RemoveDiscountButton);
            Controls.Add(AddDiscountButton);
            Controls.Add(DiscountsListBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomersTab";
            Size = new Size(1155, 758);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private CheckBox isPriorityCheckBox;
        private ListBox DiscountsListBox;
        private Button AddDiscountButton;
        private Button RemoveDiscountButton;
    }
}
