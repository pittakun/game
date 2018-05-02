using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class local
    {
        public int amount_options { get; set; }


        public string option_name_1 { get; set; }
        public string option_name_2 { get; set; }
        public string option_name_3 { get; set; }
        public string option_name_4 { get; set; }

        public string description { get; set; }

        public local(string nome_1, string nome_2, string nome_3, string nome_4, int amount,string desc)
        {
            
            option_name_1 = nome_1;
            option_name_2 = nome_2;
            option_name_3 = nome_3;
            option_name_4 = nome_4;

            amount_options = amount;
            description = desc + "\n";
        }
        

        public virtual local act_1()
        {
            return null;
        }

        public virtual local act_2()
        {
            return null;
        }

        public virtual local act_3()
        {
            return null;
        }

        public virtual local act_4()
        {
            return null;
        }

      
    }
}
