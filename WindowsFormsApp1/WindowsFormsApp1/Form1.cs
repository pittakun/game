using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        player p1= new player("Pitta");


        enemy zumbie = new enemy("zumbie", 1, 4, 20);

        control_interface control;
        local atual;

        //---------Locais--------------------

        
        movimente meu_quarto;
        loot mesa;
        key chave = new key("chave da casa");
        loot guardaroupa;
        weapon taco = new weapon(1, 3, "taco de baseball");

        movimente corredor;

        movimente banheiro;
        loot armario;
        food remedio = new food(5, 5, "remédio");

        movimente cozinha;
        loot geladeira;
        food vitamina = new food(2, 4, "vitamina");

        movimente sala;
        movimente TV;
        door porta_minha_casa;
        combat cbt;


        local obrigado;

        private void Form1_Load(object sender, EventArgs e)
        {

            // ------------Auxiliares-----------------
            control = new control_interface(gb_game,gb_combat, gb_bag,act_1, act_2, act_3, act_4, btn_attack);
            atual = new local("Acender a luz", "Sair pela porta", "", "",2,"Um local escuro");






            //-------------instaces ---------------

            

            obrigado = new local("", "", "", "",0, "Obrigado por jogar a demo");

            cbt = new combat(control, p1, zumbie, "Um homem parado perto do carro começa a caminha em sua direção, e vem para te atacar", obrigado);

            porta_minha_casa = new door(lb_bag, rtb_game, control, p1, chave, "Abrir a porta", "Voltar a sala", "", "", 2, cbt, sala, null, null
                , "Você ve a porta da sua casa, porem ela está trancada");
            TV = new movimente("Ir sala", "", "", "", 1, sala, null, null, null
            , "(Jornalista) algo estranho está acontecendo,\n\n você ve uma imagem com carros capotados e pessoas correndo" +
            " \n(Jornalista) um caos a cida... Ahhhhg... pessoa ata... ahhhg \n\n e a televisão sai do ar!");

            sala = new movimente("Ir à cozinha", "Ir à porta", "Ligar a TV", "", 3, cozinha, porta_minha_casa, TV, null
            , "Você ve seu a sala, com alguma carras perto do sofá, a porta da sua casa e a televisão.");

            geladeira = new loot(control, lb_bag, p1, rtb_game, "Voltar a cozinha", "pegar Vitamina", "", "", 2, cozinha, vitamina, null, null
                , "Você abre a geladeira e vê uma vitamina de morango.");

            cozinha = new movimente("Ir ao Corredor", "Ir à sala", "Abrir geladeira", "", 3, corredor, sala, geladeira, null
            , "você esta na cozinha, ve a geladeira, a pia suja e a entrada da sala.");

            armario = new loot(control, lb_bag, p1, rtb_game, "ir ao banheiro", "pegar remédio", "", "", 2, banheiro, remedio, null, null
                , "Você abre o armário e vê um remédio para infecção.");

            banheiro = new movimente("Abrir Armario", "Voltar ao Corredor", "", "", 2, armario, corredor, null, null
            , "Você ve seu banheiro, ainda meio sujo e o armário.");

            corredor = new movimente("Ir ao banheiro", "Ir a cozinha", "Ir ao quarto", "", 3, banheiro, cozinha, meu_quarto, null
            , "Nesse corredor você ve o banheiro e a cozinha.");

            guardaroupa = new loot(control, lb_bag, p1, rtb_game, "ir ao quarto", "pegar Taco de Baseball", "", "", 2, meu_quarto, taco, null, null
                , "Você abre o guarda roupa e ve um taco de Baseball no multuado de roupas");

            mesa = new loot(control, lb_bag, p1, rtb_game, "ir ao quarto", "pegar chave", "", "", 2, meu_quarto, chave, null, null
                , "Você abre a gaveta e ve uma chave");


            meu_quarto = new movimente("Ir para a comoda", "Abrir guarda-roupa", "Sair pela porta","", 3, mesa , guardaroupa, corredor ,null
               , "Você está em seu quarto, você ve uma mesa de comoda, um guarda-roupa e a porta para o corredor.");



            meu_quarto.init(mesa, guardaroupa, corredor, null);
            mesa.init(meu_quarto);
            guardaroupa.init(meu_quarto);
            corredor.init(banheiro, cozinha, meu_quarto, null);
            banheiro.init(armario, corredor, null, null);
            armario.init(banheiro);
            cozinha.init(corredor, sala, geladeira, null);
            geladeira.init(cozinha);
            sala.init(cozinha, porta_minha_casa, TV, null);
            TV.init(sala, null, null, null);
            porta_minha_casa.init(cbt, sala, null, null);



            


            //------------Game-----------------

            atual = meu_quarto;



           
            update_persongem();
            rtb_game.Text = atual.description;
            control.game_options(atual.amount_options, atual.option_name_1, atual.option_name_2, atual.option_name_3, atual.option_name_4);

          


        }

        //----------------------------------------------------------------------
        int t_calc = 15;
        int h_calc = 15;
        
        public void update_persongem()
        {

            Random r = new Random();

            if(r.Next(1,h_calc) <= 2){
                p1.hunger -= 1;
                h_calc = 15;
            }
            else
            {
                h_calc -= 1;
            }

            if (r.Next(1, t_calc) <= 2)
            {
                p1.thirst -= 1;
                t_calc = 15;
            }
            else
            {
                t_calc -= 1;
            }

            if(p1.thirst <= 0)
            {
                p1.life -= 1;
            }

            if (p1.hunger <= 0)
            {
                p1.life -= 1;
            }


            if(p1.life <= 0)
            {
                rtb_game.Text = control.invert_text(rtb_game.Text, "\n\nVocê morreu por não ter vida\n\n");
                atual = obrigado;
            }

            lbl_name.Text = p1.name;
            lbl_hunger.Text = "Fome: " + p1.hunger;
            lbl_thirst.Text = "Sede: " + p1.thirst;
            lbl_life.Text = "Vida: " + p1.life;

            if (p1.hand == null)
                lbl_hand.Text = "Arma:";
            else
                lbl_hand.Text = "Arma: " + p1.hand.name;
        }


        //------------------Mochila----------------------------------

                //----------------Ações----------------------------------

        private void act_1_Click(object sender, EventArgs e)
        {
            atual = atual.act_1();
            update_persongem();
            rtb_game.Text = control.invert_text(rtb_game.Text,atual.description);
            control.game_options(atual.amount_options, atual.option_name_1, atual.option_name_2, atual.option_name_3, atual.option_name_4);
        }
        private void act_2_Click(object sender, EventArgs e)
        {
            atual = atual.act_2();
            update_persongem();
            rtb_game.Text = control.invert_text(rtb_game.Text, atual.description);
            control.game_options(atual.amount_options, atual.option_name_1, atual.option_name_2, atual.option_name_3, atual.option_name_4);
        }

        private void act_3_Click(object sender, EventArgs e)
        {
            atual = atual.act_3();
            update_persongem();
            rtb_game.Text = control.invert_text(rtb_game.Text, atual.description);
            control.game_options(atual.amount_options, atual.option_name_1, atual.option_name_2, atual.option_name_3, atual.option_name_4);
        }

        private void act_4_Click(object sender, EventArgs e)
        {
            atual = atual.act_4();
            update_persongem();
            rtb_game.Text = control.invert_text(rtb_game.Text, atual.description);
            control.game_options(atual.amount_options, atual.option_name_1, atual.option_name_2, atual.option_name_3, atual.option_name_4);
        }






        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lb_bag.SelectedItem != null)
            {

                string n = lb_bag.SelectedItem.ToString();
                rtb_game.Text = control.invert_text(rtb_game.Text, p1.use_item(n, lb_bag));
                update_persongem();


            }
        }

        private void btn_attack_Click(object sender, EventArgs e)
        {
           rtb_combat.Text = control.invert_text(rtb_combat.Text, cbt.resolution());
            
        }

       
        
    }
}