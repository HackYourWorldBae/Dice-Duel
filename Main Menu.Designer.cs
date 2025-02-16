namespace WinFormsApp1
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            Title = new Label();
            Title_two = new Label();
            Play_Game = new Button();
            Quit = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Showcard Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.DarkRed;
            Title.Location = new Point(236, 62);
            Title.Name = "Title";
            Title.Size = new Size(227, 52);
            Title.TabIndex = 0;
            Title.Text = "DICE DUEL";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title_two
            // 
            Title_two.AutoSize = true;
            Title_two.BackColor = Color.Transparent;
            Title_two.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title_two.ForeColor = Color.DarkCyan;
            Title_two.Location = new Point(226, 120);
            Title_two.Name = "Title_two";
            Title_two.Size = new Size(248, 23);
            Title_two.TabIndex = 1;
            Title_two.Text = "THE BATTLE OF CHAMPIONS";
            Title_two.Click += label2_Click;
            // 
            // Play_Game
            // 
            Play_Game.BackColor = Color.DarkCyan;
            Play_Game.BackgroundImageLayout = ImageLayout.Stretch;
            Play_Game.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Play_Game.ForeColor = SystemColors.ButtonHighlight;
            Play_Game.Location = new Point(213, 482);
            Play_Game.Name = "Play_Game";
            Play_Game.Size = new Size(134, 59);
            Play_Game.TabIndex = 2;
            Play_Game.Text = "PLAY";
            Play_Game.UseVisualStyleBackColor = false;
            Play_Game.Click += Two_Player_mode_Click;
            // 
            // Quit
            // 
            Quit.BackColor = Color.OrangeRed;
            Quit.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quit.ForeColor = SystemColors.ButtonHighlight;
            Quit.Location = new Point(353, 482);
            Quit.Name = "Quit";
            Quit.Size = new Size(134, 59);
            Quit.TabIndex = 3;
            Quit.Text = "QUIT GAME";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 553);
            Controls.Add(Quit);
            Controls.Add(Play_Game);
            Controls.Add(Title_two);
            Controls.Add(Title);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dice Duel";
            Load += Main_Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Title_two;
        private Button Play_Game;
        private Button Quit;
    }
}