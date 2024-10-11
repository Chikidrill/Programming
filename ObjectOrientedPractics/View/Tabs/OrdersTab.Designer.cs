namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            OrdersDataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            OrderIdTextBox = new TextBox();
            OrderCreationTimeTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            label6 = new Label();
            OrderItemsRichTextBox = new RichTextBox();
            totalAmountLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            delivTimePanel = new Panel();
            label8 = new Label();
            delivTimeComboBox = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            delivTimePanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Location = new Point(14, 33);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(417, 605);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.CellClick += OrdersDataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Selected Order:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 39);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 4;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 75);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 5;
            label4.Text = "Created:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 113);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Status";
            // 
            // OrderIdTextBox
            // 
            OrderIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderIdTextBox.Location = new Point(93, 36);
            OrderIdTextBox.Name = "OrderIdTextBox";
            OrderIdTextBox.ReadOnly = true;
            OrderIdTextBox.Size = new Size(175, 27);
            OrderIdTextBox.TabIndex = 7;
            // 
            // OrderCreationTimeTextBox
            // 
            OrderCreationTimeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderCreationTimeTextBox.Location = new Point(93, 72);
            OrderCreationTimeTextBox.Name = "OrderCreationTimeTextBox";
            OrderCreationTimeTextBox.ReadOnly = true;
            OrderCreationTimeTextBox.Size = new Size(175, 27);
            OrderCreationTimeTextBox.TabIndex = 8;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(93, 105);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(175, 28);
            StatusComboBox.TabIndex = 9;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 11;
            label6.Text = "Order items:";
            // 
            // OrderItemsRichTextBox
            // 
            OrderItemsRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsRichTextBox.Location = new Point(0, 36);
            OrderItemsRichTextBox.Name = "OrderItemsRichTextBox";
            OrderItemsRichTextBox.ReadOnly = true;
            OrderItemsRichTextBox.Size = new Size(638, 125);
            OrderItemsRichTextBox.TabIndex = 12;
            OrderItemsRichTextBox.Text = "";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalAmountLabel.Location = new Point(0, 182);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(86, 41);
            totalAmountLabel.TabIndex = 14;
            totalAmountLabel.Text = "4999";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(totalAmountLabel);
            panel1.Controls.Add(OrderItemsRichTextBox);
            panel1.Location = new Point(454, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 244);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(StatusComboBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(OrderCreationTimeTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(OrderIdTextBox);
            panel2.Location = new Point(454, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 150);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(OrdersDataGridView);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 659);
            panel3.TabIndex = 17;
            // 
            // delivTimePanel
            // 
            delivTimePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            delivTimePanel.Controls.Add(label8);
            delivTimePanel.Controls.Add(delivTimeComboBox);
            delivTimePanel.Controls.Add(label7);
            delivTimePanel.Location = new Point(755, 9);
            delivTimePanel.Name = "delivTimePanel";
            delivTimePanel.Size = new Size(337, 150);
            delivTimePanel.TabIndex = 18;
            delivTimePanel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 43);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 10;
            label8.Text = "Delivery Time:";
            // 
            // delivTimeComboBox
            // 
            delivTimeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            delivTimeComboBox.FormattingEnabled = true;
            delivTimeComboBox.Location = new Point(112, 40);
            delivTimeComboBox.Name = "delivTimeComboBox";
            delivTimeComboBox.Size = new Size(222, 28);
            delivTimeComboBox.TabIndex = 20;
            delivTimeComboBox.SelectedIndexChanged += delivTimeComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 19;
            label7.Text = "Priority Options:";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(delivTimePanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrdersTab";
            Size = new Size(1095, 665);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            delivTimePanel.ResumeLayout(false);
            delivTimePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OrdersDataGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox OrderIdTextBox;
        private TextBox OrderCreationTimeTextBox;
        private ComboBox StatusComboBox;
        private Label label6;
        private RichTextBox OrderItemsRichTextBox;
        private Label totalAmountLabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel delivTimePanel;
        private Label label8;
        private ComboBox delivTimeComboBox;
        private Label label7;
    }
}
