namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            itemsPage = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            customersPage = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            cartsPage = new TabPage();
            OrdersPage = new TabPage();
            tabControl1.SuspendLayout();
            itemsPage.SuspendLayout();
            customersPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(itemsPage);
            tabControl1.Controls.Add(customersPage);
            tabControl1.Controls.Add(cartsPage);
            tabControl1.Controls.Add(OrdersPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1137, 711);
            tabControl1.TabIndex = 0;
            // 
            // itemsPage
            // 
            itemsPage.Controls.Add(itemsTab1);
            itemsPage.Location = new Point(4, 29);
            itemsPage.Name = "itemsPage";
            itemsPage.Padding = new Padding(3);
            itemsPage.Size = new Size(1129, 678);
            itemsPage.TabIndex = 0;
            itemsPage.Text = "Items";
            itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1123, 672);
            itemsTab1.TabIndex = 0;
            // 
            // customersPage
            // 
            customersPage.Controls.Add(customersTab1);
            customersPage.Location = new Point(4, 29);
            customersPage.Name = "customersPage";
            customersPage.Padding = new Padding(3);
            customersPage.Size = new Size(1129, 606);
            customersPage.TabIndex = 1;
            customersPage.Text = "Customers";
            customersPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(1123, 600);
            customersTab1.TabIndex = 0;
            // 
            // cartsPage
            // 
            cartsPage.Location = new Point(4, 29);
            cartsPage.Name = "cartsPage";
            cartsPage.Padding = new Padding(3);
            cartsPage.Size = new Size(1129, 606);
            cartsPage.TabIndex = 2;
            cartsPage.Text = "Carts";
            cartsPage.UseVisualStyleBackColor = true;
            // 
            // OrdersPage
            // 
            OrdersPage.Location = new Point(4, 29);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Padding = new Padding(3);
            OrdersPage.Size = new Size(1129, 606);
            OrdersPage.TabIndex = 3;
            OrdersPage.Text = "Orders";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 711);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            itemsPage.ResumeLayout(false);
            customersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage itemsPage;
        private TabPage customersPage;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage cartsPage;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage OrdersPage;
    }
}
