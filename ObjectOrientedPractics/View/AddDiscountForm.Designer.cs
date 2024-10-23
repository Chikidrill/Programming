using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ObjectOrientedPractics.View
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddPercentDiscountTableLayoutPanel = new TableLayoutPanel();
            PercentDiscountLabel = new Label();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            OkButton = new Button();
            CancelButton = new Button();
            AddPercentDiscountTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddPercentDiscountTableLayoutPanel
            // 
            AddPercentDiscountTableLayoutPanel.ColumnCount = 4;
            AddPercentDiscountTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            AddPercentDiscountTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.54485F));
            AddPercentDiscountTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7275753F));
            AddPercentDiscountTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7275753F));
            AddPercentDiscountTableLayoutPanel.Controls.Add(PercentDiscountLabel, 0, 0);
            AddPercentDiscountTableLayoutPanel.Controls.Add(CategoryLabel, 0, 1);
            AddPercentDiscountTableLayoutPanel.Controls.Add(CategoryComboBox, 1, 1);
            AddPercentDiscountTableLayoutPanel.Controls.Add(OkButton, 2, 2);
            AddPercentDiscountTableLayoutPanel.Controls.Add(CancelButton, 3, 2);
            AddPercentDiscountTableLayoutPanel.Dock = DockStyle.Fill;
            AddPercentDiscountTableLayoutPanel.Location = new Point(0, 0);
            AddPercentDiscountTableLayoutPanel.Name = "AddPercentDiscountTableLayoutPanel";
            AddPercentDiscountTableLayoutPanel.RowCount = 3;
            AddPercentDiscountTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            AddPercentDiscountTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            AddPercentDiscountTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            AddPercentDiscountTableLayoutPanel.Size = new Size(382, 107);
            AddPercentDiscountTableLayoutPanel.TabIndex = 0;
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            AddPercentDiscountTableLayoutPanel.SetColumnSpan(PercentDiscountLabel, 4);
            PercentDiscountLabel.Dock = DockStyle.Bottom;
            PercentDiscountLabel.Location = new Point(3, 11);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(376, 20);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Dock = DockStyle.Fill;
            CategoryLabel.Location = new Point(0, 31);
            CategoryLabel.Margin = new Padding(0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(75, 28);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            CategoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CategoryComboBox
            // 
            AddPercentDiscountTableLayoutPanel.SetColumnSpan(CategoryComboBox, 3);
            CategoryComboBox.Dock = DockStyle.Fill;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(75, 31);
            CategoryComboBox.Margin = new Padding(0, 0, 3, 0);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(304, 28);
            CategoryComboBox.TabIndex = 2;
            // 
            // OkButton
            // 
            OkButton.Dock = DockStyle.Fill;
            OkButton.Location = new Point(190, 62);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(91, 42);
            OkButton.TabIndex = 3;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.Location = new Point(287, 62);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(92, 42);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddDiscountForm
            // 
            this.Load += new System.EventHandler(this.AddDiscountForm_Load);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 107);
            Controls.Add(AddPercentDiscountTableLayoutPanel);
            Name = "AddDiscountForm";
            Text = "Add Discount";
            AddPercentDiscountTableLayoutPanel.ResumeLayout(false);
            AddPercentDiscountTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel AddPercentDiscountTableLayoutPanel;
        private Label PercentDiscountLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Button OkButton;
        new private Button CancelButton;
    }
}