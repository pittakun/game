using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class weapon : item
    {
        public int min_damage { get; set; }
        public int max_damage { get; set; }

        public weapon (int min, int max, string n) : base(n , "weapon")
        {
            min_damage = min;
            max_damage = max;
        }

        public override string used(player p, ListBox l)
        {
            if (p.hand != null)
            {
                p.bag.Add(p.hand);
                l.Items.Add(p.hand.name);
                             
                p.hand = this;
                return "\n" + this.name + " equipada";

            }
            else
            {
                p.hand = this;
                return "\n" + this.name + " equipada";
            }
            
        }

        public int attack()
        {
            Random rd = new Random();
            return rd.Next(min_damage, max_damage) + 1;

        }
    }
}
