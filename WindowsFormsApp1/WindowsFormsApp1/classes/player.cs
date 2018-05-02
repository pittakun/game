using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class player
    {
        public string name { get; set; }
        public int life { get; set; }
        public int hunger { get; set; }
        public int thirst { get; set; }

        public weapon hand { get; set; }

        public List<item> bag = new List<item>();

        public string take_item (item i, ListBox l )
        {
            if (bag.Count() <= 7)
            {
                bag.Add(i);
                l.Items.Add(i.name);
                return "item " + i.name + " coletado.\n";
            }
            else
            {
                return "Mochila cheia.\n";
            }
        }

        public string use_item(string n, ListBox l)
        {
            item i;
            for(int c = 0; c<=7 ; c++)
            {
                if(bag[c].name == n)
                {
                    i = bag[c];
                    if (i.type != "key")
                    {
                        string x = i.used(this, l) + "\n";
                        bag.Remove(i);
                        l.Items.Remove(i.name);
                        return x;
                    }
                    else
                        return "Não pode usar esse item ! \n";
                }
                
            }

            return "";
        }


        public player(string n)
        {
            name = n;
            life = 10;
            hunger = thirst = 10;

        }
              
    }
}
