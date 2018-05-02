using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class door : local
    {

        player play;
        key key;

        local move_1;
        local move_2;
        local move_3;
        local move_4;

        control_interface control;
        RichTextBox rtb;
        ListBox bag;


        public door(ListBox l,RichTextBox r,control_interface c,player p,key k, string name_1, string name_2, string name_3, string name_4, int amount,
                    local l_1, local l_2, local l_3, local l_4, string desc) :
            base(name_1, name_2, name_3, name_4, amount, desc)
        {
            key = k;

            move_1 = l_1;
            move_2 = l_2;
            move_3 = l_3;
            move_4 = l_4;

            rtb = r;
            bag = l;
            control = c;
            play = p;
        }

        public override local act_1()
        {
            if (play.bag.Contains(key))
            {
                if (play.hand != null)
                {
                    rtb.Text = control.invert_text(rtb.Text, play.use_item(key.name, bag));
                    return move_1;
                }
                else
                {
                    rtb.Text = control.invert_text(rtb.Text, "Você não deve sair desarmado\n");
                    return this;
                }

            }
            else
                return this;
        }

        public override local act_2()
        {
            return move_2;
        }

        public override local act_3()
        {
            return move_3;
        }

        public override local act_4()
        {
            return move_4;
        }

        public void init(local l1, local l2, local l3, local l4)
        {
            move_1 = l1;
            move_2 = l2;
            move_3 = l3;
            move_4 = l4;
        }

        public void bag_att()
        {

        }
    }
}
