namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            ItemsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            CustomerComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            AmountLabel = new Label();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            AddToCartButton = new Button();
            CartListBox = new ListBox();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(18, 41);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(339, 424);
            ItemsListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nekst Semi Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 1;
            label1.Text = "Items";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nekst Semi Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(404, 46);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 2;
            label2.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(548, 41);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(416, 28);
            CustomerComboBox.TabIndex = 3;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nekst Semi Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(404, 126);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 5;
            label3.Text = "Cart:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Nekst Semi Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(893, 340);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 6;
            label4.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Nekst Semi Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(829, 371);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(135, 41);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "4 999.9";
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CreateOrderButton.Location = new Point(547, 415);
            CreateOrderButton.MaximumSize = new Size(135, 0);
            CreateOrderButton.MinimumSize = new Size(100, 0);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(135, 46);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(688, 415);
            RemoveItemButton.MaximumSize = new Size(135, 0);
            RemoveItemButton.MinimumSize = new Size(100, 0);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(135, 46);
            RemoveItemButton.TabIndex = 9;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ClearCartButton.Location = new Point(829, 415);
            ClearCartButton.MaximumSize = new Size(135, 0);
            ClearCartButton.MinimumSize = new Size(100, 0);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(135, 46);
            ClearCartButton.TabIndex = 10;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(18, 486);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(125, 60);
            AddToCartButton.TabIndex = 11;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(404, 147);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(560, 164);
            CartListBox.TabIndex = 12;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartListBox);
            Controls.Add(AddToCartButton);
            Controls.Add(ClearCartButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(AmountLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CustomerComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ItemsListBox);
            Name = "CartsTab";
            Size = new Size(1016, 558);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ItemsListBox;
        private Label label1;
        private Label label2;
        private ComboBox CustomerComboBox;
        private Label label3;
        private Label label4;
        private Label AmountLabel;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private Button AddToCartButton;
        private ListBox CartListBox;
    }
}
