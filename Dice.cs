using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Dice
    {
        public static int Dice_Roll() {


            Random rand = new();

            int random_number = rand.Next(1,7);

            return (random_number);

        }

        public static int Rand_one_or_two()
        {
            Random rand = new();
            int random_number = rand.Next(1, 3);
            return (random_number);

        }

    }
}
