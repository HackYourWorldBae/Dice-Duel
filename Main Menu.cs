using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.PortableExecutable;
using Dice_Duel;





namespace WinFormsApp1
{

    public partial class Main_Menu : Form
    {

        public Main_Menu()
        {
            InitializeComponent();

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
        }

        private void Two_Player_mode_Click(object sender, EventArgs e)
        {
            Player_Input name_Input = new Player_Input();
            name_Input.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
