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
            Model.Address address1 = new Model.Address();
            OrdersDataGridView = new DataGridView();
            addressControl1 = new Controls.AddressControl();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            OrderIdTextBox = new TextBox();
            OrderCreationTimeTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Location = new Point(16, 32);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(417, 509);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.CellClick += OrdersDataGridView_CellClick;
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 0;
            address1.Street = "";
            addressControl1.Address = address1;
            addressControl1.Location = new Point(439, 178);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(637, 267);
            addressControl1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(439, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Selected Order:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 48);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 4;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 84);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 5;
            label4.Text = "Created:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 122);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Status";
            // 
            // OrderIdTextBox
            // 
            OrderIdTextBox.Location = new Point(529, 45);
            OrderIdTextBox.Name = "OrderIdTextBox";
            OrderIdTextBox.ReadOnly = true;
            OrderIdTextBox.Size = new Size(200, 27);
            OrderIdTextBox.TabIndex = 7;
            // 
            // OrderCreationTimeTextBox
            // 
            OrderCreationTimeTextBox.Location = new Point(529, 81);
            OrderCreationTimeTextBox.Name = "OrderCreationTimeTextBox";
            OrderCreationTimeTextBox.ReadOnly = true;
            OrderCreationTimeTextBox.Size = new Size(200, 27);
            OrderCreationTimeTextBox.TabIndex = 8;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(529, 114);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(200, 28);
            StatusComboBox.TabIndex = 9;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StatusComboBox);
            Controls.Add(OrderCreationTimeTextBox);
            Controls.Add(OrderIdTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addressControl1);
            Controls.Add(OrdersDataGridView);
            Name = "OrdersTab";
            Size = new Size(1095, 569);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrdersDataGridView;
        private Controls.AddressControl addressControl1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox OrderIdTextBox;
        private TextBox OrderCreationTimeTextBox;
        private ComboBox StatusComboBox;
    }
}
