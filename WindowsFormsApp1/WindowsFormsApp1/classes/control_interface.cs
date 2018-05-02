using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    class control_interface
    {
        private GroupBox game;
        private GroupBox combat;
        private GroupBox bag;

        Button option_1;
        Button option_2;
        Button option_3;
        Button option_4;

        Button combate_button;

        public control_interface(GroupBox g, GroupBox c, GroupBox b,
            Button btn_1, Button btn_2, Button btn_3, Button btn_4, Button cbt_btn )
        {
            game = g;
            combat = c;
            bag = b;

            option_1 = btn_1;
            option_2 = btn_2;
            option_3 = btn_3;
            option_4 = btn_4;

            combate_button = cbt_btn;

        }

        public void game_mode()
        {
            game.Visible = true;
            combat.Visible = false;
            bag.Enabled = true;
        }

        public void combat_mode()
        {
            game.Visible = false;
            combat.Visible = true;
            bag.Enabled = false;

        }

        public string invert_text(string old, string neww)
        {
            return neww +"\n"+ old;
        }

        public void game_options(int amount, string name_1, string name_2, string name_3, string name_4)
        {
            switch (amount)
            {
                case 0:
                    option_1.Visible = false;
                    option_2.Visible = false;
                    option_3.Visible = false;
                    option_4.Visible = false;
                    break;
                case 1:
                    option_1.Visible = true;
                    option_2.Visible = false;
                    option_3.Visible = false;
                    option_4.Visible = false;
                    break;
                case 2:
                    option_1.Visible = true;
                    option_2.Visible = true;
                    option_3.Visible = false;
                    option_4.Visible = false;
                    break;
                case 3:
                    option_1.Visible = true;
                    option_2.Visible = true;
                    option_3.Visible = true;
                    option_4.Visible = false;
                    break;
                case 4:
                    option_1.Visible = true;
                    option_2.Visible = true;
                    option_3.Visible = true;
                    option_4.Visible = true;
                    break;
            }
            option_1.Text = name_1;
            option_2.Text = name_2;
            option_3.Text = name_3;
            option_4.Text = name_4;

        }

        public void end_game()
        {
            combate_button.Enabled = false;
        }
    }
}
