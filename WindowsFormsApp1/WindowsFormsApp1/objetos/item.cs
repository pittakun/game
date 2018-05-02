using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class item
    {
        public string name { get; set; }
        public string type { get; set; }
        public bool caught = false;

        public item(string n, string t)
        {
            name = n;
            type = t;
        }

        public virtual string used(player p, ListBox l)
        {
            return"";
        }
    }
}
