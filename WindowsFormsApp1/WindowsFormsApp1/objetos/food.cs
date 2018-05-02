using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class food : item
    {
        public int hunger_satiation;
        public int thirst_satiation;

        public food(int hunger, int thirst,string n) : base(n, "food")
        {
            hunger_satiation = hunger;
            thirst_satiation = thirst;
        }

        public override string used(player p, ListBox l)
        {
            p.hunger += this.hunger_satiation;
            p.thirst += this.thirst_satiation;

            if (p.hunger > 10)
                p.hunger = 10;

            if (p.thirst > 10)
                p.thirst = 10;


            return "\nVocê ingeriu um " + this.name + " e ganhou " + this.hunger_satiation + " de fome e " + this.thirst_satiation + " de sede";
        }
    }
}
