namespace Programming.View.Panels
{
    partial class RectangleCollisionControl
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
            CanvaLengthTxtBox = new TextBox();
            CanvaWidthTxtBox = new TextBox();
            CanvaYTxtBox = new TextBox();
            CanvaXTxtBox = new TextBox();
            CanvaIdTxtBox = new TextBox();
            CanvaLengthLabel = new Label();
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
            SuspendLayout();
            // 
            // CanvaLengthTxtBox
            // 
            CanvaLengthTxtBox.Location = new Point(147, 482);
            CanvaLengthTxtBox.Name = "CanvaLengthTxtBox";
            CanvaLengthTxtBox.Size = new Size(125, 27);
            CanvaLengthTxtBox.TabIndex = 31;
            CanvaLengthTxtBox.TextChanged += CanvaLengthTxtBox_TextChanged;
            // 
            // CanvaWidthTxtBox
            // 
            CanvaWidthTxtBox.Location = new Point(147, 449);
            CanvaWidthTxtBox.Name = "CanvaWidthTxtBox";
            CanvaWidthTxtBox.Size = new Size(125, 27);
            CanvaWidthTxtBox.TabIndex = 30;
            CanvaWidthTxtBox.TextChanged += CanvaWidthTxtBox_TextChanged;
            // 
            // CanvaYTxtBox
            // 
            CanvaYTxtBox.Location = new Point(147, 416);
            CanvaYTxtBox.Name = "CanvaYTxtBox";
            CanvaYTxtBox.Size = new Size(125, 27);
            CanvaYTxtBox.TabIndex = 29;
            // 
            // CanvaXTxtBox
            // 
            CanvaXTxtBox.Location = new Point(147, 383);
            CanvaXTxtBox.Name = "CanvaXTxtBox";
            CanvaXTxtBox.Size = new Size(125, 27);
            CanvaXTxtBox.TabIndex = 28;
            // 
            // CanvaIdTxtBox
            // 
            CanvaIdTxtBox.Location = new Point(147, 350);
            CanvaIdTxtBox.Name = "CanvaIdTxtBox";
            CanvaIdTxtBox.ReadOnly = true;
            CanvaIdTxtBox.Size = new Size(125, 27);
            CanvaIdTxtBox.TabIndex = 27;
            // 
            // CanvaLengthLabel
            // 
            CanvaLengthLabel.AutoSize = true;
            CanvaLengthLabel.Location = new Point(89, 485);
            CanvaLengthLabel.Name = "CanvaLengthLabel";
            CanvaLengthLabel.Size = new Size(57, 20);
            CanvaLengthLabel.TabIndex = 26;
            CanvaLengthLabel.Text = "Length:";
            // 
            // CanvaWidthLabel
            // 
            CanvaWidthLabel.AutoSize = true;
            CanvaWidthLabel.Location = new Point(93, 452);
            CanvaWidthLabel.Name = "CanvaWidthLabel";
            CanvaWidthLabel.Size = new Size(52, 20);
            CanvaWidthLabel.TabIndex = 25;
            CanvaWidthLabel.Text = "Width:";
            // 
            // CanvaYLabel
            // 
            CanvaYLabel.AutoSize = true;
            CanvaYLabel.Location = new Point(49, 419);
            CanvaYLabel.Name = "CanvaYLabel";
            CanvaYLabel.Size = new Size(96, 20);
            CanvaYLabel.TabIndex = 24;
            CanvaYLabel.Text = "Y coordinate:";
            // 
            // CanvaXLabel
            // 
            CanvaXLabel.AutoSize = true;
            CanvaXLabel.Location = new Point(49, 386);
            CanvaXLabel.Name = "CanvaXLabel";
            CanvaXLabel.Size = new Size(97, 20);
            CanvaXLabel.TabIndex = 23;
            CanvaXLabel.Text = "X coordinate:";
            // 
            // CanvaIdLabel
            // 
            CanvaIdLabel.AutoSize = true;
            CanvaIdLabel.Location = new Point(121, 353);
            CanvaIdLabel.Name = "CanvaIdLabel";
            CanvaIdLabel.Size = new Size(25, 20);
            CanvaIdLabel.TabIndex = 22;
            CanvaIdLabel.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 311);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 21;
            label3.Text = "Selected rectangle:";
            // 
            // DelRecButton
            // 
            DelRecButton.FlatStyle = FlatStyle.Flat;
            DelRecButton.Location = new Point(209, 256);
            DelRecButton.Name = "DelRecButton";
            DelRecButton.Size = new Size(144, 29);
            DelRecButton.TabIndex = 20;
            DelRecButton.Text = "Delete rectangle";
            DelRecButton.UseVisualStyleBackColor = true;
            DelRecButton.Click += DelRecButton_Click;
            // 
            // AddRecButton
            // 
            AddRecButton.FlatStyle = FlatStyle.Flat;
            AddRecButton.Location = new Point(11, 256);
            AddRecButton.Name = "AddRecButton";
            AddRecButton.Size = new Size(144, 29);
            AddRecButton.TabIndex = 19;
            AddRecButton.Text = "Add rectangle";
            AddRecButton.UseVisualStyleBackColor = true;
            AddRecButton.Click += AddRecButton_Click;
            // 
            // CanvaRectListBox
            // 
            CanvaRectListBox.FormattingEnabled = true;
            CanvaRectListBox.ItemHeight = 20;
            CanvaRectListBox.Location = new Point(11, 32);
            CanvaRectListBox.Name = "CanvaRectListBox";
            CanvaRectListBox.Size = new Size(342, 204);
            CanvaRectListBox.TabIndex = 18;
            CanvaRectListBox.SelectedIndexChanged += CanvaRectListBox_SelectedIndexChanged;
            // 
            // rectLabel
            // 
            rectLabel.AutoSize = true;
            rectLabel.Location = new Point(11, 9);
            rectLabel.Name = "rectLabel";
            rectLabel.Size = new Size(84, 20);
            rectLabel.TabIndex = 17;
            rectLabel.Text = "Rectangles:";
            // 
            // CanvaRectPanel
            // 
            CanvaRectPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CanvaRectPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvaRectPanel.Location = new Point(359, 9);
            CanvaRectPanel.Name = "CanvaRectPanel";
            CanvaRectPanel.Size = new Size(428, 537);
            CanvaRectPanel.TabIndex = 16;
            // 
            // RectangleCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CanvaLengthTxtBox);
            Controls.Add(CanvaWidthTxtBox);
            Controls.Add(CanvaYTxtBox);
            Controls.Add(CanvaXTxtBox);
            Controls.Add(CanvaIdTxtBox);
            Controls.Add(CanvaLengthLabel);
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
            Name = "RectangleCollisionControl";
            Size = new Size(798, 554);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CanvaLengthTxtBox;
        private TextBox CanvaWidthTxtBox;
        private TextBox CanvaYTxtBox;
        private TextBox CanvaXTxtBox;
        private TextBox CanvaIdTxtBox;
        private Label CanvaLengthLabel;
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
    }
}
