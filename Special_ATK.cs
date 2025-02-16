using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Special_ATK
    {
        public static (int val,int sup,string type) Bonus(int num)
        {
            int atk = 4;
            int dmg = 0;
            int heal = 0;
            string atk_type = "";
            switch (num)
            {
                case 1:
                    dmg = atk / 2;
                    atk_type = "Weak Strike!";
                    break;
                case 2:
                    dmg = atk * 2;
                    atk_type = "Power Strike!";
                    break;
                case 3:
                    heal = 10;
                    atk_type = "Heal!";
                    break;
                case 4:
                    dmg = atk * 3;
                    atk_type = "Critical Strike";
                    break;
                case 5:
                    dmg = 5;
                    atk_type = "Counter!";
                    break;
                case 6:
                    dmg = 20;
                    atk_type = "Ultimate Strike";
                    break;
            }

            return (dmg,heal,atk_type);

        }
    }
}
