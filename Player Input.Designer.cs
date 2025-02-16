namespace WinFormsApp1
{
    partial class Player_Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Input));
            P_one_input = new TextBox();
            P_one_name_input = new Label();
            P_one_character = new PictureBox();
            comboBox1 = new ComboBox();
            P_two_character = new PictureBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            P_two_input = new TextBox();
            button1 = new Button();
            label1 = new Label();
            Main_Menu = new Button();
            ((System.ComponentModel.ISupportInitialize)P_one_character).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_two_character).BeginInit();
            SuspendLayout();
            // 
            // P_one_input
            // 
            P_one_input.BackColor = Color.Black;
            P_one_input.BorderStyle = BorderStyle.FixedSingle;
            P_one_input.Cursor = Cursors.IBeam;
            P_one_input.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            P_one_input.ForeColor = SystemColors.ButtonHighlight;
            P_one_input.Location = new Point(120, 101);
            P_one_input.MaxLength = 10;
            P_one_input.Name = "P_one_input";
            P_one_input.Size = new Size(125, 27);
            P_one_input.TabIndex = 0;
            P_one_input.TextChanged += P_one_input_TextChanged;
            // 
            // P_one_name_input
            // 
            P_one_name_input.AutoSize = true;
            P_one_name_input.BackColor = Color.Transparent;
            P_one_name_input.BorderStyle = BorderStyle.FixedSingle;
            P_one_name_input.Font = new Font("Elephant", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            P_one_name_input.ForeColor = Color.Turquoise;
            P_one_name_input.Location = new Point(90, 56);
            P_one_name_input.Name = "P_one_name_input";
            P_one_name_input.Size = new Size(182, 24);
            P_one_name_input.TabIndex = 1;
            P_one_name_input.Text = "[ 1 ] Player Name ";
            // 
            // P_one_character
            // 
            P_one_character.BackColor = Color.Transparent;
            P_one_character.BorderStyle = BorderStyle.FixedSingle;
            P_one_character.Location = new Point(70, 144);
            P_one_character.Name = "P_one_character";
            P_one_character.Size = new Size(220, 180);
            P_one_character.SizeMode = PictureBoxSizeMode.StretchImage;
            P_one_character.TabIndex = 2;
            P_one_character.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DimGray;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 349);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // P_two_character
            // 
            P_two_character.AccessibleRole = AccessibleRole.Sound;
            P_two_character.BackColor = Color.Transparent;
            P_two_character.BorderStyle = BorderStyle.FixedSingle;
            P_two_character.Location = new Point(510, 144);
            P_two_character.Name = "P_two_character";
            P_two_character.Size = new Size(220, 180);
            P_two_character.SizeMode = PictureBoxSizeMode.StretchImage;
            P_two_character.TabIndex = 4;
            P_two_character.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.DimGray;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(550, 349);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Elephant", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(530, 56);
            label2.Name = "label2";
            label2.Size = new Size(183, 22);
            label2.TabIndex = 8;
            label2.Text = "[ 2 ] Player Name ";
            // 
            // P_two_input
            // 
            P_two_input.BackColor = Color.Black;
            P_two_input.BorderStyle = BorderStyle.FixedSingle;
            P_two_input.Cursor = Cursors.IBeam;
            P_two_input.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            P_two_input.ForeColor = SystemColors.ButtonHighlight;
            P_two_input.Location = new Point(560, 101);
            P_two_input.MaxLength = 10;
            P_two_input.Name = "P_two_input";
            P_two_input.Size = new Size(125, 27);
            P_two_input.TabIndex = 9;
            P_two_input.TextChanged += P_two_input_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(348, 360);
            button1.Name = "button1";
            button1.Size = new Size(104, 48);
            button1.TabIndex = 10;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Elephant", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 24);
            label1.TabIndex = 11;
            label1.Text = "CHOOSE YOUR CHARACTER!!";
            label1.Click += label1_Click;
            // 
            // Main_Menu
            // 
            Main_Menu.BackColor = Color.DarkRed;
            Main_Menu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Main_Menu.ForeColor = SystemColors.ButtonHighlight;
            Main_Menu.Location = new Point(348, 414);
            Main_Menu.Name = "Main_Menu";
            Main_Menu.Size = new Size(104, 29);
            Main_Menu.TabIndex = 12;
            Main_Menu.Text = "Main Menu";
            Main_Menu.UseVisualStyleBackColor = false;
            Main_Menu.Click += button2_Click;
            // 
            // Player_Input
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Main_Menu);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(P_two_input);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(P_two_character);
            Controls.Add(comboBox1);
            Controls.Add(P_one_character);
            Controls.Add(P_one_name_input);
            Controls.Add(P_one_input);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Player_Input";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dice Duel";
            Load += Player_Name_Input_Load;
            ((System.ComponentModel.ISupportInitialize)P_one_character).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_two_character).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox P_one_input;
        private Label P_one_name_input;
        private PictureBox P_one_character;
        private ComboBox comboBox1;
        private PictureBox P_two_character;
        private ComboBox comboBox2;
        private Label label2;
        private TextBox P_two_input;
        private Button button1;
        private Label label1;
        private Button Main_Menu;
    }
}