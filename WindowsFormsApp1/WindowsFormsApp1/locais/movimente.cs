using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class movimente : local
    {

        local move_1;
        local move_2;
        local move_3;
        local move_4;

        

        public movimente(string name_1, string name_2, string name_3, string name_4, int amount,
                    local l_1, local l_2, local l_3, local l_4, string desc)  :
            base( name_1, name_2, name_3, name_4, amount, desc)
        {
            move_1 = l_1;
            move_2 = l_2;
            move_3 = l_3;
            move_4 = l_4;

          
        }

        public override local act_1()
        {

            return move_1;
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
    }
}
