namespace WinFormsApp1
{
    partial class Gameplay_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay_Window));
            Player1_Name = new Label();
            P_one_hp = new Label();
            P_two_hp = new Label();
            Player2_Name = new Label();
            P_one_Dice_Roll = new Button();
            P_two_Dice_roll = new Button();
            P_one_Def_Dice = new Button();
            P_two_Def_Dice = new Button();
            P_one_def = new Label();
            P_two_def = new Label();
            P_one_hp_bar = new ProgressBar();
            P_two_hp_bar = new ProgressBar();
            P_one_character_model = new PictureBox();
            P_two_character_model = new PictureBox();
            P_one_dice_img1 = new PictureBox();
            P_one_dice_img2 = new PictureBox();
            P_one_def_img = new PictureBox();
            P_two_def_img = new PictureBox();
            P_two_dice_img2 = new PictureBox();
            P_two_dice_img1 = new PictureBox();
            New_Game = new Button();
            Quit = new Button();
            Player_Logs = new ListBox();
            Player_Turn = new Label();
            ((System.ComponentModel.ISupportInitialize)P_one_character_model).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_two_character_model).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_one_dice_img1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_one_dice_img2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_one_def_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_two_def_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_two_dice_img2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_two_dice_img1).BeginInit();
            SuspendLayout();
            // 
            // Player1_Name
            // 
            Player1_Name.AutoSize = true;
            Player1_Name.BackColor = Color.SteelBlue;
            Player1_Name.BorderStyle = BorderStyle.Fixed3D;
            Player1_Name.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Player1_Name.ForeColor = SystemColors.ButtonHighlight;
            Player1_Name.Location = new Point(12, 21);
            Player1_Name.Name = "Player1_Name";
            Player1_Name.Size = new Size(120, 22);
            Player1_Name.TabIndex = 0;
            Player1_Name.Text = "Player1_Name";
            // 
            // P_one_hp
            // 
            P_one_hp.AutoSize = true;
            P_one_hp.BackColor = SystemColors.ActiveCaption;
            P_one_hp.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            P_one_hp.ForeColor = SystemColors.ActiveCaptionText;
            P_one_hp.Location = new Point(183, 55);
            P_one_hp.Name = "P_one_hp";
            P_one_hp.Size = new Size(26, 17);
            P_one_hp.TabIndex = 1;
            P_one_hp.Text = "50";
            // 
            // P_two_hp
            // 
            P_two_hp.AutoSize = true;
            P_two_hp.BackColor = SystemColors.ActiveCaption;
            P_two_hp.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            P_two_hp.ForeColor = SystemColors.ActiveCaptionText;
            P_two_hp.Location = new Point(817, 59);
            P_two_hp.Name = "P_two_hp";
            P_two_hp.Size = new Size(26, 17);
            P_two_hp.TabIndex = 3;
            P_two_hp.Text = "50";
            // 
            // Player2_Name
            // 
            Player2_Name.AutoSize = true;
            Player2_Name.BackColor = Color.DarkRed;
            Player2_Name.BorderStyle = BorderStyle.Fixed3D;
            Player2_Name.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Player2_Name.ForeColor = SystemColors.ButtonHighlight;
            Player2_Name.Location = new Point(889, 24);
            Player2_Name.Name = "Player2_Name";
            Player2_Name.Size = new Size(123, 22);
            Player2_Name.TabIndex = 2;
            Player2_Name.Text = "Player2_Name";
            // 
            // P_one_Dice_Roll
            // 
            P_one_Dice_Roll.BackColor = Color.Brown;
            P_one_Dice_Roll.Cursor = Cursors.Hand;
            P_one_Dice_Roll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P_one_Dice_Roll.ForeColor = SystemColors.ButtonHighlight;
            P_one_Dice_Roll.Location = new Point(20, 451);
            P_one_Dice_Roll.Name = "P_one_Dice_Roll";
            P_one_Dice_Roll.Size = new Size(120, 50);
            P_one_Dice_Roll.TabIndex = 5;
            P_one_Dice_Roll.Text = "Roll Dice (ATK)";
            P_one_Dice_Roll.UseVisualStyleBackColor = false;
            P_one_Dice_Roll.Click += P1_Dice_roll;
            // 
            // P_two_Dice_roll
            // 
            P_two_Dice_roll.BackColor = Color.Brown;
            P_two_Dice_roll.Cursor = Cursors.Hand;
            P_two_Dice_roll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P_two_Dice_roll.ForeColor = SystemColors.ButtonHighlight;
            P_two_Dice_roll.Location = new Point(894, 451);
            P_two_Dice_roll.Name = "P_two_Dice_roll";
            P_two_Dice_roll.Size = new Size(120, 50);
            P_two_Dice_roll.TabIndex = 7;
            P_two_Dice_roll.Text = "Roll Dice (ATK)";
            P_two_Dice_roll.UseVisualStyleBackColor = false;
            P_two_Dice_roll.Click += P2_Dice_roll_Click;
            // 
            // P_one_Def_Dice
            // 
            P_one_Def_Dice.BackColor = Color.DarkCyan;
            P_one_Def_Dice.Cursor = Cursors.Hand;
            P_one_Def_Dice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P_one_Def_Dice.ForeColor = SystemColors.ButtonHighlight;
            P_one_Def_Dice.Location = new Point(20, 513);
            P_one_Def_Dice.Name = "P_one_Def_Dice";
            P_one_Def_Dice.Size = new Size(120, 50);
            P_one_Def_Dice.TabIndex = 12;
            P_one_Def_Dice.Text = "Roll Dice (DEF)";
            P_one_Def_Dice.UseVisualStyleBackColor = false;
            P_one_Def_Dice.Click += P_one_Def_Dice_Click;
            // 
            // P_two_Def_Dice
            // 
            P_two_Def_Dice.BackColor = Color.DarkCyan;
            P_two_Def_Dice.Cursor = Cursors.Hand;
            P_two_Def_Dice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P_two_Def_Dice.ForeColor = SystemColors.ButtonHighlight;
            P_two_Def_Dice.Location = new Point(894, 513);
            P_two_Def_Dice.Name = "P_two_Def_Dice";
            P_two_Def_Dice.Size = new Size(120, 50);
            P_two_Def_Dice.TabIndex = 13;
            P_two_Def_Dice.Text = "Roll Dice (DEF)";
            P_two_Def_Dice.UseVisualStyleBackColor = false;
            P_two_Def_Dice.Click += P_two_Def_Dice_Click;
            // 
            // P_one_def
            // 
            P_one_def.AutoSize = true;
            P_one_def.BackColor = Color.Transparent;
            P_one_def.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P_one_def.ForeColor = Color.Aqua;
            P_one_def.Location = new Point(14, 75);
            P_one_def.Name = "P_one_def";
            P_one_def.Size = new Size(82, 20);
            P_one_def.TabIndex = 14;
            P_one_def.Text = "[ Defense ]";
            // 
            // P_two_def
            // 
            P_two_def.AutoSize = true;
            P_two_def.BackColor = Color.Transparent;
            P_two_def.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P_two_def.ForeColor = Color.Aqua;
            P_two_def.Location = new Point(930, 79);
            P_two_def.Name = "P_two_def";
            P_two_def.Size = new Size(82, 20);
            P_two_def.TabIndex = 15;
            P_two_def.Text = "[ Defense ]";
            // 
            // P_one_hp_bar
            // 
            P_one_hp_bar.BackColor = Color.DimGray;
            P_one_hp_bar.ForeColor = Color.Tomato;
            P_one_hp_bar.Location = new Point(12, 43);
            P_one_hp_bar.Name = "P_one_hp_bar";
            P_one_hp_bar.Size = new Size(197, 29);
            P_one_hp_bar.TabIndex = 20;
            // 
            // P_two_hp_bar
            // 
            P_two_hp_bar.ForeColor = Color.Transparent;
            P_two_hp_bar.Location = new Point(817, 47);
            P_two_hp_bar.Name = "P_two_hp_bar";
            P_two_hp_bar.Size = new Size(197, 29);
            P_two_hp_bar.TabIndex = 21;
            // 
            // P_one_character_model
            // 
            P_one_character_model.BackColor = Color.Transparent;
            P_one_character_model.Location = new Point(12, 125);
            P_one_character_model.Name = "P_one_character_model";
            P_one_character_model.Size = new Size(360, 320);
            P_one_character_model.SizeMode = PictureBoxSizeMode.StretchImage;
            P_one_character_model.TabIndex = 22;
            P_one_character_model.TabStop = false;
            // 
            // P_two_character_model
            // 
            P_two_character_model.BackColor = Color.Transparent;
            P_two_character_model.Location = new Point(651, 125);
            P_two_character_model.Name = "P_two_character_model";
            P_two_character_model.Size = new Size(360, 320);
            P_two_character_model.SizeMode = PictureBoxSizeMode.StretchImage;
            P_two_character_model.TabIndex = 23;
            P_two_character_model.TabStop = false;
            // 
            // P_one_dice_img1
            // 
            P_one_dice_img1.BackColor = Color.Transparent;
            P_one_dice_img1.BorderStyle = BorderStyle.FixedSingle;
            P_one_dice_img1.Location = new Point(146, 451);
            P_one_dice_img1.Name = "P_one_dice_img1";
            P_one_dice_img1.Size = new Size(50, 50);
            P_one_dice_img1.SizeMode = PictureBoxSizeMode.StretchImage;
            P_one_dice_img1.TabIndex = 24;
            P_one_dice_img1.TabStop = false;
            // 
            // P_one_dice_img2
            // 
            P_one_dice_img2.BackColor = Color.Transparent;
            P_one_dice_img2.BorderStyle = BorderStyle.FixedSingle;
            P_one_dice_img2.Location = new Point(202, 451);
            P_one_dice_img2.Name = "P_one_dice_img2";
            P_one_dice_img2.Size = new Size(50, 50);
            P_one_dice_img2.SizeMode = PictureBoxSizeMode.StretchImage;
            P_one_dice_img2.TabIndex = 26;
            P_one_dice_img2.TabStop = false;
            // 
            // P_one_def_img
            // 
            P_one_def_img.BackColor = Color.Transparent;
            P_one_def_img.BorderStyle = BorderStyle.FixedSingle;
            P_one_def_img.Location = new Point(146, 513);
            P_one_def_img.Name = "P_one_def_img";
            P_one_def_img.Size = new Size(50, 50);
            P_one_def_img.SizeMode = PictureBoxSizeMode.StretchImage;
            P_one_def_img.TabIndex = 27;
            P_one_def_img.TabStop = false;
            // 
            // P_two_def_img
            // 
            P_two_def_img.BackColor = Color.Transparent;
            P_two_def_img.BorderStyle = BorderStyle.FixedSingle;
            P_two_def_img.Location = new Point(838, 513);
            P_two_def_img.Name = "P_two_def_img";
            P_two_def_img.Size = new Size(50, 50);
            P_two_def_img.SizeMode = PictureBoxSizeMode.StretchImage;
            P_two_def_img.TabIndex = 30;
            P_two_def_img.TabStop = false;
            // 
            // P_two_dice_img2
            // 
            P_two_dice_img2.BackColor = Color.Transparent;
            P_two_dice_img2.BorderStyle = BorderStyle.FixedSingle;
            P_two_dice_img2.Location = new Point(838, 451);
            P_two_dice_img2.Name = "P_two_dice_img2";
            P_two_dice_img2.Size = new Size(50, 50);
            P_two_dice_img2.SizeMode = PictureBoxSizeMode.StretchImage;
            P_two_dice_img2.TabIndex = 29;
            P_two_dice_img2.TabStop = false;
            // 
            // P_two_dice_img1
            // 
            P_two_dice_img1.BackColor = Color.Transparent;
            P_two_dice_img1.BorderStyle = BorderStyle.FixedSingle;
            P_two_dice_img1.Location = new Point(782, 451);
            P_two_dice_img1.Name = "P_two_dice_img1";
            P_two_dice_img1.Size = new Size(50, 50);
            P_two_dice_img1.SizeMode = PictureBoxSizeMode.StretchImage;
            P_two_dice_img1.TabIndex = 28;
            P_two_dice_img1.TabStop = false;
            // 
            // New_Game
            // 
            New_Game.BackColor = Color.ForestGreen;
            New_Game.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            New_Game.ForeColor = SystemColors.ButtonHighlight;
            New_Game.Location = new Point(412, 534);
            New_Game.Name = "New_Game";
            New_Game.Size = new Size(94, 29);
            New_Game.TabIndex = 31;
            New_Game.Text = "New Game";
            New_Game.UseVisualStyleBackColor = false;
            New_Game.Click += New_Game_Click;
            // 
            // Quit
            // 
            Quit.BackColor = Color.DarkRed;
            Quit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quit.ForeColor = SystemColors.ButtonHighlight;
            Quit.Location = new Point(512, 534);
            Quit.Name = "Quit";
            Quit.Size = new Size(94, 29);
            Quit.TabIndex = 32;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // Player_Logs
            // 
            Player_Logs.BackColor = SystemColors.InactiveCaption;
            Player_Logs.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Player_Logs.FormattingEnabled = true;
            Player_Logs.Location = new Point(348, 444);
            Player_Logs.Name = "Player_Logs";
            Player_Logs.Size = new Size(327, 84);
            Player_Logs.TabIndex = 33;
            // 
            // Player_Turn
            // 
            Player_Turn.AutoSize = true;
            Player_Turn.BackColor = SystemColors.ActiveCaptionText;
            Player_Turn.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Player_Turn.ForeColor = SystemColors.ButtonHighlight;
            Player_Turn.Location = new Point(419, 13);
            Player_Turn.Name = "Player_Turn";
            Player_Turn.Size = new Size(188, 26);
            Player_Turn.TabIndex = 34;
            Player_Turn.Text = "PLAYER_TURN";
            // 
            // Gameplay_Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1026, 575);
            Controls.Add(Player_Turn);
            Controls.Add(Player_Logs);
            Controls.Add(Quit);
            Controls.Add(New_Game);
            Controls.Add(P_two_def_img);
            Controls.Add(P_two_dice_img2);
            Controls.Add(P_two_dice_img1);
            Controls.Add(P_one_def_img);
            Controls.Add(P_one_dice_img2);
            Controls.Add(P_one_dice_img1);
            Controls.Add(P_two_character_model);
            Controls.Add(P_one_character_model);
            Controls.Add(P_two_def);
            Controls.Add(P_one_def);
            Controls.Add(P_two_Def_Dice);
            Controls.Add(P_one_Def_Dice);
            Controls.Add(P_two_Dice_roll);
            Controls.Add(P_one_Dice_Roll);
            Controls.Add(P_two_hp);
            Controls.Add(Player2_Name);
            Controls.Add(P_one_hp);
            Controls.Add(Player1_Name);
            Controls.Add(P_one_hp_bar);
            Controls.Add(P_two_hp_bar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gameplay_Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dice Duel";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)P_one_character_model).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_two_character_model).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_one_dice_img1).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_one_dice_img2).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_one_def_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_two_def_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_two_dice_img2).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_two_dice_img1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Player1_Name;
        private Label P_one_hp;
        private Label P_two_hp;
        private Label Player2_Name;
        private Button P_one_Dice_Roll;
        private Button P_two_Dice_roll;
        private Button P_one_Def_Dice;
        private Button P_two_Def_Dice;
        private Label P_one_def;
        private Label P_two_def;
        private ProgressBar P_one_hp_bar;
        private ProgressBar P_two_hp_bar;
        private PictureBox P_one_character_model;
        private PictureBox P_two_character_model;
        private PictureBox P_one_dice_img1;
        private PictureBox P_one_dice_img2;
        private PictureBox P_one_def_img;
        private PictureBox P_two_def_img;
        private PictureBox P_two_dice_img2;
        private PictureBox P_two_dice_img1;
        private Button New_Game;
        private Button Quit;
        private ListBox Player_Logs;
        private Label Player_Turn;
    }
}
