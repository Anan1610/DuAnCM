namespace GUI_QLVT
{
    partial class frmCho
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
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(-1, 850);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1268, 46);
            progressBar.TabIndex = 0;
            // 
            // frmCho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1264, 961);
            Controls.Add(progressBar);
            Name = "frmCho";
            Text = "frmCho";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
    }
}