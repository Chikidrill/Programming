namespace ProgrammingIndividualTask
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
            songControlPanel1 = new View.Panels.SongControlPanel();
            SuspendLayout();
            // 
            // songControlPanel1
            // 
            songControlPanel1.Dock = DockStyle.Fill;
            songControlPanel1.Location = new Point(0, 0);
            songControlPanel1.Name = "songControlPanel1";
            songControlPanel1.Size = new Size(898, 523);
            songControlPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(898, 523);
            Controls.Add(songControlPanel1);
            MinimumSize = new Size(750, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Song List";
            ResumeLayout(false);
        }

        #endregion

        private View.Panels.SongControlPanel songControlPanel1;
    }
}