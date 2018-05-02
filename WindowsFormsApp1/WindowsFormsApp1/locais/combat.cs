using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class combat : local
    {
        List<string> action = new List<string>();
        List<string> error = new List<string>();
        List<string> hit = new List<string>();
        List<string> super_hit = new List<string>();

        int position = 0;
        control_interface control;
        local  next;

        player player;
        enemy enemy;

        public string resolution()
        {
            string x;
            Random rd = new Random();
            Random speak = new Random();
            int roll;
            int lucky;

            roll = rd.Next(0, 10);

            if (roll <= 2)
            {
                lucky = 0;
            } else if( roll >= 9)
            {
                lucky = 2;
            }
            else
            {
                lucky = 1;
            } 


            



            x = action[speak.Next(action.Count)];
            switch (lucky)
            {
                case 0 :
                    x += error[speak.Next(error.Count)];
                    player.life -= enemy.damage();
                    break;
                case 1:
                    enemy.life -= player.hand.attack();
                    x += hit[speak.Next(hit.Count)];
                    break;
                case 2:
                    x += super_hit[speak.Next(super_hit.Count)];
                    enemy.life -= (player.hand.attack()*2);
                    break;
            }


            switch (position)
            {
                case -1:
                    switch (lucky)
                    {
                        case 0:
                            x += "e ele te mordeu...  você morreu!";
                            player.life = 0;
                            break;
                        case 1:
                            x += "e ele ainda continua em cima de você.";
                            break;
                        case 2:
                            x += "e você consegue levantar.";
                            position = 0;
                            break;
                    }
                    break;
                case 0:
                    switch (lucky)
                    {
                        case 0:
                            x += "e ele te derruba no chão e vai para cima de você.";
                            position = -1;
                            break;
                        case 1:
                            x += "e vocês continuam frente a frente!";
                            break;
                        case 2:
                            x += "e você derruba ele, e vai pra cima!";
                            position = 1;
                            break;
                    }
                    break;
                case 1:
                    switch (lucky)
                    {
                        case 0:
                            x += "e vocês ficam de pé!";
                            position = 0;
                            break;
                        case 1:
                            x += "e você continua em cima dele!";
                            break;
                        case 2:
                            x += "";
                            break;
                    }
                    break;
            }

            if(player.life <= 0)
            {
                control.end_game();
                x += "\n\n\n Obriado Por Jogar!\n\nGame Over ";
            }

            if (enemy.life <= 0)
            {
                control.end_game();
                x += "\n\n\n Obriado Por Jogar!\n\nVocê Matou ele ";
            }
            x += "\n";



            return x;
        }


        public combat(control_interface c, player p, enemy e, string desc,local l):base("inciar combate",null,null,null,1,desc)
        {
            player = p;
            enemy = e;

            action.Add("Você socou na altura do rosto e ");
            action.Add("Você chutou com muita força e ");
            action.Add("Mirando direto na cabeça, um soco direto e ");

            hit.Add("pegou em cheio ");
            hit.Add("acertou direto ");
            hit.Add("acerto no meio com muita força ");

            error.Add("passou reto ");
            error.Add("até acertou, mas bem fraco ");
            error.Add("errou miseravelmente ");

            super_hit.Add("pegou diretamente que ele morreu.");
            super_hit.Add("pegou em cheio, explodiu tudo.");
            super_hit.Add("com uma direta ele morreu.");

            control = c;
            next = l;
        }

        public override local act_1()
        {
            control.combat_mode();
            return next;
        }



    }
}
