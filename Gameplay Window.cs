using System.Drawing.Text;
using Dice_Duel;

namespace WinFormsApp1
{
    public partial class Gameplay_Window : Form
    {

        public Gameplay_Window(string[] data, int[] character)
        {
            InitializeComponent();
            Player1_Name.Text = data[0];
            Player2_Name.Text = data[1];
            Player2_Name.Left = this.ClientSize.Width - Player2_Name.Width - 12;
            player1_name = data[0];
            player2_name = data[1];
            player1_character = character[0];
            player2_character = character[1];
        }

        //GLOBAL VARIABLES
        int player1_health = 50;
        int player2_health = 50;
        int player1_def_chance = 0;
        int player2_def_chance = 0;
        int p1_self_dmg = 0;
        int p2_self_dmg = 0;
        string p_one_def_type = "";
        string p_two_def_type = "";
        string player1_name = "";
        string player2_name = "";
        int player1_character;
        int player2_character;
        readonly Image[] diceImages =
            [
                Dice_img.one,
                Dice_img.two,
                Dice_img.three,
                Dice_img.four,
                Dice_img.five,
                Dice_img.six
            ];

        private void Form1_Load(object sender, EventArgs e)
        {
            if (player1_character == 0)
            {
                P_one_character_model.Image = Characters.samurai_model;
            }
            else if (player1_character == 1)
            {
                P_one_character_model.Image = Characters.Shogun_model;
            }
            if (player2_character == 0)
            {
                P_two_character_model.Image = Characters.samurai_model;
            }
            else if (player2_character == 1)
            {
                P_two_character_model.Image = Characters.Shogun_model;
            }

            P_one_hp.Text = player1_health.ToString();
            P_two_hp.Text = player2_health.ToString();

            //FIRST PLAYER TURN
            int who_turn = Dice.Rand_one_or_two();
            Main_Function(who_turn);
            P_one_hp_bar.Minimum = 0;
            P_one_hp_bar.Maximum = 50;
            P_two_hp_bar.Minimum = 0;
            P_two_hp_bar.Maximum = 50;
            Update_HP();
        }

        //PLAYER 1 ATTRIBUTES**********************************************************************************
        private void P1_Dice_roll(object sender, EventArgs e)
        {
            int p = 1;
            int nextplayer = 2;
            int outcome1 = Dice.Dice_Roll();
            int outcome2 = Dice.Dice_Roll();

            Load_Dice_Img(p, outcome1, outcome2);

            int p1_damage = outcome1 + outcome2;

            if (p1_self_dmg == 1)
            {
                    ApplySelfDamage(ref player2_health, p1_damage);
                    p1_self_dmg = 0;
                    LogMove(player1_name,$"[Self-Damage] Damage : {p1_damage} ");
                    Main_Function(nextplayer);
            }
            else if (player2_def_chance == 1)
            {
                int modified_dmg = Modify_DMG(p_two_def_type, p1_damage);
                ReduceHealth(ref player2_health, modified_dmg);
                LogMove(player1_name, $"[Defended] Damage : {modified_dmg}");
                player2_def_chance = 0;
                p_two_def_type = "";
                P_two_def.Left = 930;
                P_two_def.Text = "[ Defense ]";
                Update_HP();
                Main_Function(nextplayer);
            }
            else
            {
                if (outcome1 == outcome2)
                {
                    var (dmg, heal, atk_type) = Special_ATK.Bonus(outcome1);

                    if (heal > 0)
                    {
                        player1_health += heal;
                        LogMove(player1_name, $"[Heal] +{heal} HP ");
                        Update_HP();
                        Main_Function(nextplayer);
                    }
                    else if (atk_type == "Counter!")
                    {
                        ReduceHealth(ref player2_health,dmg);
                        Update_HP();
                        p2_self_dmg = 1;
                        LogMove(player1_name, $"[{atk_type}] Damage : {dmg}");
                        LogMove("","NEXT PLAYER TAKES HIS OWN DMG");
                        Main_Function(nextplayer);
                    }
                    else
                    {
                        ReduceHealth(ref player2_health, dmg);
                        LogMove(player1_name, $"[{atk_type}] Damage : {dmg} ");
                        Update_HP();
                        Main_Function(nextplayer);
                    }
                }
                else
                {
                    ReduceHealth(ref player2_health, p1_damage);
                    LogMove(player1_name, $"[Normal DMG] Damage : {p1_damage} ");
                    Update_HP();
                    Main_Function(nextplayer);
                }
            }
        }

        private void P_one_Def_Dice_Click(object sender, EventArgs e)
        {
            int p = 1;
            int player = 2;
            int outcome = Dice.Dice_Roll();
            Load_Dice_Img_Def(p, outcome);
            p_one_def_type = Defense_Type(outcome);
            P_one_def.Text = p_one_def_type;
            player1_def_chance = 1;
            Main_Function(player);
        }
        //*****************************************************************************************************

        //PLAYER 2 ATTRIBUTES**********************************************************************************
        private void P2_Dice_roll_Click(object sender, EventArgs e)
        {
            int p = 2;
            int nextplayer = 1;
            int outcome1 = Dice.Dice_Roll();
            int outcome2 = Dice.Dice_Roll();

            Load_Dice_Img(p, outcome1, outcome2);

            int p2_damage = outcome1 + outcome2;

            if (p2_self_dmg == 1)
            {
                ApplySelfDamage(ref player2_health, p2_damage);
                LogMove(player2_name, $"[Self-Damage] Damage : {p2_damage} ");
                p2_self_dmg = 0;
                Main_Function(nextplayer);
            }
            else if (player1_def_chance == 1)
            {
                int modified_dmg = Modify_DMG(p_one_def_type, p2_damage);
                ReduceHealth(ref player1_health, modified_dmg);
                LogMove(player2_name, $"[Defended] Damage : {modified_dmg} ");
                player1_def_chance = 0;
                p_one_def_type = "";
                P_one_def.Text = "[ Defense ]";
                Update_HP();
                Main_Function(nextplayer);
            }
            else
            {
                if (outcome1 == outcome2)
                {
                    var (dmg, heal, atk_type) = Special_ATK.Bonus(outcome1);

                    if (heal > 0)
                    {
                        player2_health += heal;
                        LogMove(player2_name, $"[Heal] +{heal} HP");
                        Update_HP();
                        Main_Function(nextplayer);
                    }
                    else if (atk_type == "Counter!")
                    {
                        ReduceHealth(ref player1_health, dmg);
                        Update_HP();
                        p1_self_dmg = 1;
                        LogMove(player1_name, $"[{atk_type}] Damage : {dmg}");
                        LogMove("", "NEXT PLAYER TAKES HIS OWN DMG");
                        Main_Function(nextplayer);
                    }
                    else
                    {
                        ReduceHealth(ref player1_health, dmg);
                        LogMove(player2_name, $"[{atk_type}] Damage : {dmg} ");
                        Update_HP();
                        Main_Function(nextplayer);
                    }
                }
                else
                {
                    ReduceHealth(ref player1_health, p2_damage);
                    LogMove(player2_name, $"[Normal_DMG] Damage : {p2_damage}");
                    Update_HP();
                    Main_Function(nextplayer);
                }
            }
        }
        private void P_two_Def_Dice_Click(object sender, EventArgs e)
        {
            int p = 2;
            int player = 1;
            int outcome = Dice.Dice_Roll();
            Load_Dice_Img_Def(p, outcome);
            p_two_def_type = Defense_Type(outcome);
            P_two_def.Text = p_two_def_type;
            P_two_def.Left = 1016 - P_two_def.Width;
            player2_def_chance = 1;
            Main_Function(player);
        }
        //*****************************************************************************************************

        //GAME FUNCTIONS********************************************************************************************
        private static void ReduceHealth(ref int playerHealth, int damage)
        {
            playerHealth -= damage;
            if (playerHealth < 0)
                playerHealth = 0;
        }

        private void Update_HP()
        {
            if (player1_health < 0) player1_health = 0;
            if (player2_health < 0) player2_health = 0;
            if (player1_health > 50) player1_health = 50;
            if (player2_health > 50) player2_health = 50;
            P_two_hp.Text = player2_health.ToString();
            P_one_hp.Text = player1_health.ToString();
            P_one_hp_bar.Value = player1_health;
            P_two_hp_bar.Value = player2_health;
        }
        private static string Defense_Type(int outcome)
        {
            string block_type = "";

            if (outcome == 1 || outcome == 2)
            {
                block_type = "Reduce DMG";
            }
            else if (outcome == 3 || outcome == 4)
            {
                block_type = "Recieve Half DMG";
            }
            else if (outcome == 5 || outcome == 6)
            {
                block_type = "Block All DMG";
            }
            return block_type;
        }
        private static int Modify_DMG(string type, int dmg)
        {
            int modified_dmg = 0;

            if (type == "Reduce DMG")
            {
                int random_dmg = Dice.Rand_one_or_two();
                modified_dmg = dmg - random_dmg;
            }
            else if (type == "Recieve Half DMG")
            {
                modified_dmg = dmg / 2;
            }
            else if (type == "Block All DMG")
            {
                modified_dmg = 0;
            }

            return modified_dmg;
        }
        private void GameOver_Condition()
        {
            DialogResult result = MessageBox.Show("Do you want a new game?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Reset_Game();
                Player_Input player_Input = new Player_Input();
                player_Input.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void ApplySelfDamage(ref int playerHealth, int damage)
        {
            ReduceHealth(ref playerHealth, damage);
            Update_HP();
        }

        private void Load_Dice_Img(int player, int outcome1, int outcome2)
        {
            PictureBox[] playerDice = (player == 1) ? [P_one_dice_img1, P_one_dice_img2] : [P_two_dice_img1, P_two_dice_img2];

            playerDice[0].Image = diceImages[outcome1 - 1];
            playerDice[1].Image = diceImages[outcome2 - 1];
        }

        private void Load_Dice_Img_Def(int player, int outcome)
        {
            PictureBox playerDice = (player == 1) ? P_one_def_img : P_two_def_img;

            playerDice.Image = diceImages[outcome - 1];
        }
        
        private void Reset_Game()
        {
            player1_health = 50;
            player2_health = 50;
            P_one_def.Text = "";
            P_two_def.Text = "";
            P_one_dice_img1.Image = default;
            P_one_dice_img2.Image = default;
            P_two_dice_img1.Image = default;
            P_two_dice_img2.Image = default;
            P_one_def_img.Image = default;
            P_two_def_img.Image = default;
        }
        private void LogMove(string player, string moveDescription)
        {
            string logEntry = $"{player}:{moveDescription}";
            Player_Logs.Items.Add(logEntry);
            Player_Logs.SelectedIndex = Player_Logs.Items.Count - 1;
        }
        //*****************************************************************************************************

        //MAIN FUNCTION****************************************************************************************
        private async void Main_Function(int player)
        {
            int delay_sec = 1000;

            //PLAYER 1 TURN
            if (player == 1)
            {
                Player_Turn.BackColor = Color.SteelBlue;
                Player_Turn.Text = $"{player1_name}'S TURN";
                Player_Turn.Left = (this.ClientSize.Width / 2) - (Player_Turn.Width / 2);
                await Task.Delay(delay_sec);

                if (player1_def_chance == 1)
                {
                    P_one_Def_Dice.BackColor = Color.Gray;
                    P_one_Def_Dice.Enabled = false;
                }
                else
                {
                    P_one_Def_Dice.Enabled = true;
                    P_one_Def_Dice.BackColor = Color.DeepSkyBlue;
                }
                P_one_Dice_Roll.BackColor = Color.Brown;
                P_one_Dice_Roll.Enabled = true;
                P_two_Dice_roll.BackColor = Color.Gray;
                P_two_Def_Dice.BackColor = Color.Gray;
                P_two_Dice_roll.Enabled = false;
                P_two_Def_Dice.Enabled = false;
            }

            //PLAYER 2 TURN
            if (player == 2)
            {
                Player_Turn.BackColor = Color.DarkRed;
                Player_Turn.Text = $"{player2_name}'S TURN";
                Player_Turn.Left = (this.ClientSize.Width / 2) - (Player_Turn.Width / 2);
                await Task.Delay(delay_sec);
                if (player2_def_chance == 1)
                {
                    P_two_Def_Dice.BackColor = Color.Gray;
                    P_two_Def_Dice.Enabled = false;
                }
                else
                {
                    P_two_Def_Dice.BackColor = Color.DeepSkyBlue;
                    P_two_Def_Dice.Enabled = true;
                }
                P_two_Dice_roll.BackColor = Color.Brown;
                P_two_Dice_roll.Enabled = true;
                P_one_Dice_Roll.BackColor = Color.Gray;
                P_one_Def_Dice.BackColor = Color.Gray;
                P_one_Dice_Roll.Enabled = false;
                P_one_Def_Dice.Enabled = false;
            }

            if (player1_health == 0)
            {
                P_one_Dice_Roll.Enabled = false;
                MessageBox.Show($"GAME OVER!! {player2_name} Wins");
                GameOver_Condition();
            }

            if (player2_health == 0)
            {
                P_two_Dice_roll.Enabled = false;
                MessageBox.Show($"GAME OVER!! {player1_name} Wins");
                GameOver_Condition();
            }
        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Start A New Game?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Reset_Game();
                Player_Input player_Input = new Player_Input();
                player_Input.Show();
                this.Hide();
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
