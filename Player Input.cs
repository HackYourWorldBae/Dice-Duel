using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dice_Duel;

namespace WinFormsApp1
{
    public partial class Player_Input : Form
    {

        public Player_Input()
        {
            InitializeComponent();
            comboBox1.Items.Add("Samurai");
            comboBox1.Items.Add("Shogun");
            comboBox2.Items.Add("Samurai");
            comboBox2.Items.Add("Shogun");

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void Player_Name_Input_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    P_one_character.Image = Characters.samurai;
                    break;
                case 1:
                    P_one_character.Image = Characters.Shogun;
                    break;


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    P_two_character.Image = Characters.samurai;
                    break;
                case 1:
                    P_two_character.Image = Characters.Shogun;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool con = true;
            string player1_name = P_one_input.Text.ToUpper();
            string player2_name = P_two_input.Text.ToUpper();
            if (player1_name == player2_name && (player1_name != "" && player2_name != ""))
            {
                MessageBox.Show("The same names are not allowed");
                con = false;
            }
            else if (player1_name == "" || player2_name == "")
            {
                MessageBox.Show("Please enter each player names");
                con = false;
            }

            if (con)
            {
                int[] Character = { comboBox1.SelectedIndex, comboBox2.SelectedIndex };
                string[] Names = { player1_name, player2_name };
                Gameplay_Window gameplay_Window = new Gameplay_Window(Names, Character);
                this.Hide();
                gameplay_Window.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new();
            main_Menu.Show();
            this.Hide();

        }

        private void P_one_input_TextChanged(object sender, EventArgs e)
        {
            P_one_input.Text = P_one_input.Text.ToUpper();
            P_one_input.SelectionStart = P_one_input.Text.Length;
        }

        private void P_two_input_TextChanged(object sender, EventArgs e)
        {
            P_two_input.Text = P_two_input.Text.ToUpper();
            P_two_input.SelectionStart = P_two_input.Text.Length;
        }
    }
}
