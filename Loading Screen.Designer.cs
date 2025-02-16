namespace WinFormsApp1
{
    partial class Loading_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Screen));
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            Loading_progress = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 16.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(195, 42);
            label1.Name = "label1";
            label1.Size = new Size(83, 34);
            label1.TabIndex = 0;
            label1.Text = "DICE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 16.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(284, 42);
            label2.Name = "label2";
            label2.Size = new Size(90, 34);
            label2.TabIndex = 1;
            label2.Text = "DUEL";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 292);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(537, 21);
            progressBar1.TabIndex = 2;
            // 
            // Loading_progress
            // 
            Loading_progress.AutoSize = true;
            Loading_progress.BackColor = Color.Transparent;
            Loading_progress.ForeColor = SystemColors.ButtonHighlight;
            Loading_progress.Location = new Point(12, 269);
            Loading_progress.Name = "Loading_progress";
            Loading_progress.Size = new Size(29, 20);
            Loading_progress.TabIndex = 3;
            Loading_progress.Text = "0%";
            // 
            // Loading_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(561, 325);
            Controls.Add(Loading_progress);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Loading_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dice Duel";
            Load += Loading_Screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private Label Loading_progress;
    }
}