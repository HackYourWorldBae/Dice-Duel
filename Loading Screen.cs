using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }

        private async void Loading_Screen_Load(object sender, EventArgs e)
        {
            await LoadProcessAsync();
            this.Close();

        }

        private async Task LoadProcessAsync()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;

                if (i < 30)
                {
                    Loading_progress.Text = $"{i}% : Loading Resources";
                }
                else if (i < 50)
                {
                    Loading_progress.Text = $"{i}% : Preparing Assets";
                }
                else
                {
                    Loading_progress.Text = $"{i}% : Loading Game";
                }

                await Task.Delay(50);

            }
        }
    }


}
