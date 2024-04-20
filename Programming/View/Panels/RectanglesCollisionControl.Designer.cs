namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            CanvaWidthTxtBox = new TextBox();
            CanvaYTxtBox = new TextBox();
            CanvaXTxtBox = new TextBox();
            CanvaIdTxtBox = new TextBox();
            CanvaWidthLabel = new Label();
            CanvaYLabel = new Label();
            CanvaXLabel = new Label();
            CanvaIdLabel = new Label();
            label3 = new Label();
            DelRecButton = new Button();
            AddRecButton = new Button();
            CanvaRectListBox = new ListBox();
            rectLabel = new Label();
            CanvaRectPanel = new Panel();
            CanvaLengthTxtBox = new TextBox();
            CanvaLengthLabel = new Label();
            SuspendLayout();
            // 
            // CanvaWidthTxtBox
            // 
            CanvaWidthTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CanvaWidthTxtBox.Location = new Point(157, 446);
            CanvaWidthTxtBox.Name = "CanvaWidthTxtBox";
            CanvaWidthTxtBox.Size = new Size(125, 27);
            CanvaWidthTxtBox.TabIndex = 28;
            CanvaWidthTxtBox.TextChanged += CanvaWidthTxtBox_TextChanged;
            // 
            // CanvaYTxtBox
            // 
            CanvaYTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CanvaYTxtBox.Location = new Point(157, 413);
            CanvaYTxtBox.Name = "CanvaYTxtBox";
            CanvaYTxtBox.Size = new Size(125, 27);
            CanvaYTxtBox.TabIndex = 27;
            // 
            // CanvaXTxtBox
            // 
            CanvaXTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CanvaXTxtBox.Location = new Point(157, 380);
            CanvaXTxtBox.Name = "CanvaXTxtBox";
            CanvaXTxtBox.Size = new Size(125, 27);
            CanvaXTxtBox.TabIndex = 26;
            // 
            // CanvaIdTxtBox
            // 
            CanvaIdTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CanvaIdTxtBox.Location = new Point(157, 347);
            CanvaIdTxtBox.Name = "CanvaIdTxtBox";
            CanvaIdTxtBox.ReadOnly = true;
            CanvaIdTxtBox.Size = new Size(125, 27);
            CanvaIdTxtBox.TabIndex = 25;
            // 
            // CanvaWidthLabel
            // 
            CanvaWidthLabel.AutoSize = true;
            CanvaWidthLabel.Location = new Point(103, 449);
            CanvaWidthLabel.Name = "CanvaWidthLabel";
            CanvaWidthLabel.Size = new Size(52, 20);
            CanvaWidthLabel.TabIndex = 24;
            CanvaWidthLabel.Text = "Width:";
            // 
            // CanvaYLabel
            // 
            CanvaYLabel.AutoSize = true;
            CanvaYLabel.Location = new Point(59, 416);
            CanvaYLabel.Name = "CanvaYLabel";
            CanvaYLabel.Size = new Size(96, 20);
            CanvaYLabel.TabIndex = 23;
            CanvaYLabel.Text = "Y coordinate:";
            // 
            // CanvaXLabel
            // 
            CanvaXLabel.AutoSize = true;
            CanvaXLabel.Location = new Point(59, 383);
            CanvaXLabel.Name = "CanvaXLabel";
            CanvaXLabel.Size = new Size(97, 20);
            CanvaXLabel.TabIndex = 22;
            CanvaXLabel.Text = "X coordinate:";
            // 
            // CanvaIdLabel
            // 
            CanvaIdLabel.AutoSize = true;
            CanvaIdLabel.Location = new Point(131, 350);
            CanvaIdLabel.Name = "CanvaIdLabel";
            CanvaIdLabel.Size = new Size(25, 20);
            CanvaIdLabel.TabIndex = 21;
            CanvaIdLabel.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 308);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 20;
            label3.Text = "Selected rectangle:";
            // 
            // DelRecButton
            // 
            DelRecButton.FlatStyle = FlatStyle.Flat;
            DelRecButton.Location = new Point(219, 253);
            DelRecButton.Name = "DelRecButton";
            DelRecButton.Size = new Size(144, 29);
            DelRecButton.TabIndex = 19;
            DelRecButton.Text = "Delete rectangle";
            DelRecButton.UseVisualStyleBackColor = true;
            DelRecButton.Click += DelRecButton_Click;
            // 
            // AddRecButton
            // 
            AddRecButton.FlatStyle = FlatStyle.Flat;
            AddRecButton.Location = new Point(21, 253);
            AddRecButton.Name = "AddRecButton";
            AddRecButton.Size = new Size(144, 29);
            AddRecButton.TabIndex = 18;
            AddRecButton.Text = "Add rectangle";
            AddRecButton.UseVisualStyleBackColor = true;
            AddRecButton.Click += AddRecButton_Click;
            // 
            // CanvaRectListBox
            // 
            CanvaRectListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CanvaRectListBox.FormattingEnabled = true;
            CanvaRectListBox.ItemHeight = 20;
            CanvaRectListBox.Location = new Point(21, 29);
            CanvaRectListBox.Name = "CanvaRectListBox";
            CanvaRectListBox.Size = new Size(342, 204);
            CanvaRectListBox.TabIndex = 17;
            CanvaRectListBox.SelectedIndexChanged += CanvaRectListBox_SelectedIndexChanged;
            // 
            // rectLabel
            // 
            rectLabel.AutoSize = true;
            rectLabel.Location = new Point(21, 6);
            rectLabel.Name = "rectLabel";
            rectLabel.Size = new Size(84, 20);
            rectLabel.TabIndex = 16;
            rectLabel.Text = "Rectangles:";
            // 
            // CanvaRectPanel
            // 
            CanvaRectPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CanvaRectPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvaRectPanel.Location = new Point(369, 6);
            CanvaRectPanel.Name = "CanvaRectPanel";
            CanvaRectPanel.Size = new Size(428, 537);
            CanvaRectPanel.TabIndex = 15;
            // 
            // CanvaLengthTxtBox
            // 
            CanvaLengthTxtBox.Location = new Point(157, 479);
            CanvaLengthTxtBox.Name = "CanvaLengthTxtBox";
            CanvaLengthTxtBox.Size = new Size(125, 27);
            CanvaLengthTxtBox.TabIndex = 30;
            CanvaLengthTxtBox.TextChanged += CanvaLengthTxtBox_TextChanged;
            // 
            // CanvaLengthLabel
            // 
            CanvaLengthLabel.AutoSize = true;
            CanvaLengthLabel.Location = new Point(99, 482);
            CanvaLengthLabel.Name = "CanvaLengthLabel";
            CanvaLengthLabel.Size = new Size(57, 20);
            CanvaLengthLabel.TabIndex = 29;
            CanvaLengthLabel.Text = "Length:";
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CanvaLengthTxtBox);
            Controls.Add(CanvaLengthLabel);
            Controls.Add(CanvaWidthTxtBox);
            Controls.Add(CanvaYTxtBox);
            Controls.Add(CanvaXTxtBox);
            Controls.Add(CanvaIdTxtBox);
            Controls.Add(CanvaWidthLabel);
            Controls.Add(CanvaYLabel);
            Controls.Add(CanvaXLabel);
            Controls.Add(CanvaIdLabel);
            Controls.Add(label3);
            Controls.Add(DelRecButton);
            Controls.Add(AddRecButton);
            Controls.Add(CanvaRectListBox);
            Controls.Add(rectLabel);
            Controls.Add(CanvaRectPanel);
            Name = "RectanglesCollisionControl";
            Size = new Size(819, 548);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CanvaWidthTxtBox;
        private TextBox CanvaYTxtBox;
        private TextBox CanvaXTxtBox;
        private TextBox CanvaIdTxtBox;
        private Label CanvaWidthLabel;
        private Label CanvaYLabel;
        private Label CanvaXLabel;
        private Label CanvaIdLabel;
        private Label label3;
        private Button DelRecButton;
        private Button AddRecButton;
        private ListBox CanvaRectListBox;
        private Label rectLabel;
        private Panel CanvaRectPanel;
        private TextBox CanvaLengthTxtBox;
        private Label CanvaLengthLabel;
    }
}
