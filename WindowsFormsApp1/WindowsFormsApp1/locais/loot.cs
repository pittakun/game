using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class loot : local
    {

        local move_1;
        item item_2;
        item item_3;
        item item_4;
        RichTextBox text;
        player p;
        ListBox lb;
        control_interface control;

        public loot(control_interface ctrl, ListBox l, player play, RichTextBox rb, string name_1, string name_2, string name_3, string name_4, int amount,
                    local l_1, item i_2, item i_3, item i_4, string desc) :
            base(name_1, name_2, name_3, name_4, amount, desc)
        {
            move_1 = l_1;
            item_2 = i_2;
            item_3 = i_3;
            item_4 = i_4;

            text = rb;
            p = play;
            lb = l;
            control = ctrl;

        }

        public override local act_1()
        {
            
            return move_1;
        }

        public override local act_2()
        {
            if (item_2.caught == false)
            {
                text.Text = control.invert_text(text.Text, p.take_item(item_2, lb));
                this.description = "não há mais nada aqui.\n";
                item_2.caught = true;
                return this;
            }
            else
            {
                text.Text = control.invert_text(text.Text, "Item já coletado.\n");
                return this ;
            }
        }

        public override local act_3()
        {
            if (item_3.caught == false)
            {
                text.Text = control.invert_text(text.Text, p.take_item(item_3, lb));
                this.description = "não há mais nada aqui.\n";
                item_3.caught = true;
                return this;
            }
            else
            {
                text.Text += control.invert_text(text.Text, "\nItem já coletado.\n");
                return this;
            }
        }

        public override local act_4()
        {
            if (item_4.caught == false)
            {
                text.Text += control.invert_text(text.Text, p.take_item(item_4, lb));
                this.description = "não há mais nada aqui.\n";
                item_4.caught = true;
                return this;
            }
            else
            {
                text.Text += control.invert_text(text.Text, "\nItem já coletado.\n");
                return this;
            }

        }



        public void init(local l1)
        {
            move_1 = l1;
        }
    }
}
