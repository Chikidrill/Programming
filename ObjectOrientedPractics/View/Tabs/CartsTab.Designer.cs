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
            panel1 = new Panel();
            Discounts = new Label();
            DiscountCheckedListBox = new CheckedListBox();
            TotalAmountLabel = new Label();
            DiscountAmountLabel = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 24);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(339, 464);
            ItemsListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nekst Semi Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 3);
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
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 2;
            label2.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(157, 58);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(508, 28);
            CustomerComboBox.TabIndex = 3;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nekst Semi Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(15, 114);
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
            label4.Location = new Point(583, 352);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 6;
            label4.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Nekst Semi Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(561, 370);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(78, 24);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "4 999.9";
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CreateOrderButton.Location = new Point(15, 352);
            CreateOrderButton.MaximumSize = new Size(135, 0);
            CreateOrderButton.MinimumSize = new Size(100, 0);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(134, 53);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(156, 352);
            RemoveItemButton.MaximumSize = new Size(135, 0);
            RemoveItemButton.MinimumSize = new Size(100, 0);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(134, 53);
            RemoveItemButton.TabIndex = 9;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ClearCartButton.Location = new Point(297, 352);
            ClearCartButton.MaximumSize = new Size(135, 0);
            ClearCartButton.MinimumSize = new Size(100, 0);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(134, 53);
            ClearCartButton.TabIndex = 10;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(3, 494);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(125, 78);
            AddToCartButton.TabIndex = 11;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(15, 135);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(650, 204);
            CartListBox.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CartListBox);
            panel1.Controls.Add(CustomerComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AmountLabel);
            panel1.Controls.Add(CreateOrderButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ClearCartButton);
            panel1.Controls.Add(RemoveItemButton);
            panel1.Location = new Point(390, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 453);
            panel1.TabIndex = 13;
            // 
            // Discounts
            // 
            Discounts.AutoSize = true;
            Discounts.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Discounts.Location = new Point(5, 20);
            Discounts.Name = "Discounts";
            Discounts.Size = new Size(75, 20);
            Discounts.TabIndex = 14;
            Discounts.Text = "Discounts";
            // 
            // DiscountCheckedListBox
            // 
            DiscountCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountCheckedListBox.FormattingEnabled = true;
            DiscountCheckedListBox.Location = new Point(5, 47);
            DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            DiscountCheckedListBox.Size = new Size(311, 114);
            DiscountCheckedListBox.TabIndex = 15;
            DiscountCheckedListBox.ItemCheck += DiscountCheckedListBox_ItemCheck;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Location = new Point(437, 81);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(50, 20);
            TotalAmountLabel.TabIndex = 16;
            TotalAmountLabel.Text = "label5";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Location = new Point(437, 47);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(50, 20);
            DiscountAmountLabel.TabIndex = 17;
            DiscountAmountLabel.Text = "label5";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(DiscountAmountLabel);
            panel2.Controls.Add(TotalAmountLabel);
            panel2.Controls.Add(DiscountCheckedListBox);
            panel2.Controls.Add(Discounts);
            panel2.Location = new Point(390, 462);
            panel2.Name = "panel2";
            panel2.Size = new Size(667, 189);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(AddToCartButton);
            panel3.Controls.Add(ItemsListBox);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 648);
            panel3.TabIndex = 19;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CartsTab";
            Size = new Size(1134, 695);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label Discounts;
        private CheckedListBox DiscountCheckedListBox;
        private Label TotalAmountLabel;
        private Label DiscountAmountLabel;
        private Panel panel2;
        private Panel panel3;
    }
}
