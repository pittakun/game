using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class enemy
    {
        public string name { get; set; }
        public int min_damage { get; set; }
        public int max_damage { get; set; }
        public int life { get; set; }

        public enemy(string n, int min, int max, int l)
        {
            name = n;
            min_damage = min;
            max_damage = max;
            life = l;
        }

        public int damage()
        {
            Random n = new Random();
            return n.Next(min_damage,max_damage);
        }

    }
}
