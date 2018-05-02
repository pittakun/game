namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_hand = new System.Windows.Forms.Label();
            this.lbl_life = new System.Windows.Forms.Label();
            this.lbl_thirst = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_hunger = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lb_bag = new System.Windows.Forms.ListBox();
            this.gb_bag = new System.Windows.Forms.GroupBox();
            this.gb_game = new System.Windows.Forms.GroupBox();
            this.act_4 = new System.Windows.Forms.Button();
            this.act_3 = new System.Windows.Forms.Button();
            this.act_2 = new System.Windows.Forms.Button();
            this.act_1 = new System.Windows.Forms.Button();
            this.rtb_game = new System.Windows.Forms.RichTextBox();
            this.gb_combat = new System.Windows.Forms.GroupBox();
            this.btn_attack = new System.Windows.Forms.Button();
            this.rtb_combat = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.gb_bag.SuspendLayout();
            this.gb_game.SuspendLayout();
            this.gb_combat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_hand);
            this.groupBox1.Controls.Add(this.lbl_life);
            this.groupBox1.Controls.Add(this.lbl_thirst);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_hunger);
            this.groupBox1.Location = new System.Drawing.Point(485, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personagem";
            // 
            // lbl_hand
            // 
            this.lbl_hand.AutoSize = true;
            this.lbl_hand.Location = new System.Drawing.Point(35, 151);
            this.lbl_hand.Name = "lbl_hand";
            this.lbl_hand.Size = new System.Drawing.Size(34, 13);
            this.lbl_hand.TabIndex = 2;
            this.lbl_hand.Text = "Arma:";
            // 
            // lbl_life
            // 
            this.lbl_life.AutoSize = true;
            this.lbl_life.Location = new System.Drawing.Point(175, 29);
            this.lbl_life.Name = "lbl_life";
            this.lbl_life.Size = new System.Drawing.Size(35, 13);
            this.lbl_life.TabIndex = 1;
            this.lbl_life.Text = "label2";
            // 
            // lbl_thirst
            // 
            this.lbl_thirst.AutoSize = true;
            this.lbl_thirst.Location = new System.Drawing.Point(35, 87);
            this.lbl_thirst.Name = "lbl_thirst";
            this.lbl_thirst.Size = new System.Drawing.Size(35, 13);
            this.lbl_thirst.TabIndex = 1;
            this.lbl_thirst.Text = "label2";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(35, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            // 
            // lbl_hunger
            // 
            this.lbl_hunger.AutoSize = true;
            this.lbl_hunger.Location = new System.Drawing.Point(35, 74);
            this.lbl_hunger.Name = "lbl_hunger";
            this.lbl_hunger.Size = new System.Drawing.Size(35, 13);
            this.lbl_hunger.TabIndex = 0;
            this.lbl_hunger.Text = "label1";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(85, 151);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Usar";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lb_bag
            // 
            this.lb_bag.FormattingEnabled = true;
            this.lb_bag.Location = new System.Drawing.Point(38, 63);
            this.lb_bag.Name = "lb_bag";
            this.lb_bag.Size = new System.Drawing.Size(172, 82);
            this.lb_bag.TabIndex = 2;
            // 
            // gb_bag
            // 
            this.gb_bag.Controls.Add(this.btn_remove);
            this.gb_bag.Controls.Add(this.lb_bag);
            this.gb_bag.Location = new System.Drawing.Point(485, 238);
            this.gb_bag.Name = "gb_bag";
            this.gb_bag.Size = new System.Drawing.Size(244, 195);
            this.gb_bag.TabIndex = 3;
            this.gb_bag.TabStop = false;
            this.gb_bag.Text = "Mochila";
            // 
            // gb_game
            // 
            this.gb_game.Controls.Add(this.act_4);
            this.gb_game.Controls.Add(this.act_3);
            this.gb_game.Controls.Add(this.act_2);
            this.gb_game.Controls.Add(this.act_1);
            this.gb_game.Controls.Add(this.rtb_game);
            this.gb_game.Location = new System.Drawing.Point(28, 28);
            this.gb_game.Name = "gb_game";
            this.gb_game.Size = new System.Drawing.Size(440, 405);
            this.gb_game.TabIndex = 4;
            this.gb_game.TabStop = false;
            this.gb_game.Text = "Game";
            // 
            // act_4
            // 
            this.act_4.Location = new System.Drawing.Point(220, 376);
            this.act_4.Name = "act_4";
            this.act_4.Size = new System.Drawing.Size(199, 23);
            this.act_4.TabIndex = 6;
            this.act_4.UseVisualStyleBackColor = true;
            this.act_4.Click += new System.EventHandler(this.act_4_Click);
            // 
            // act_3
            // 
            this.act_3.Location = new System.Drawing.Point(6, 376);
            this.act_3.Name = "act_3";
            this.act_3.Size = new System.Drawing.Size(199, 23);
            this.act_3.TabIndex = 5;
            this.act_3.UseVisualStyleBackColor = true;
            this.act_3.Click += new System.EventHandler(this.act_3_Click);
            // 
            // act_2
            // 
            this.act_2.Location = new System.Drawing.Point(220, 342);
            this.act_2.Name = "act_2";
            this.act_2.Size = new System.Drawing.Size(199, 23);
            this.act_2.TabIndex = 4;
            this.act_2.UseVisualStyleBackColor = true;
            this.act_2.Click += new System.EventHandler(this.act_2_Click);
            // 
            // act_1
            // 
            this.act_1.Location = new System.Drawing.Point(6, 342);
            this.act_1.Name = "act_1";
            this.act_1.Size = new System.Drawing.Size(199, 23);
            this.act_1.TabIndex = 3;
            this.act_1.UseVisualStyleBackColor = true;
            this.act_1.Click += new System.EventHandler(this.act_1_Click);
            // 
            // rtb_game
            // 
            this.rtb_game.Location = new System.Drawing.Point(6, 19);
            this.rtb_game.Name = "rtb_game";
            this.rtb_game.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_game.Size = new System.Drawing.Size(428, 293);
            this.rtb_game.TabIndex = 2;
            this.rtb_game.Text = "";
            // 
            // gb_combat
            // 
            this.gb_combat.Controls.Add(this.btn_attack);
            this.gb_combat.Controls.Add(this.rtb_combat);
            this.gb_combat.Location = new System.Drawing.Point(28, 28);
            this.gb_combat.Name = "gb_combat";
            this.gb_combat.Size = new System.Drawing.Size(440, 405);
            this.gb_combat.TabIndex = 5;
            this.gb_combat.TabStop = false;
            this.gb_combat.Text = "Combat";
            // 
            // btn_attack
            // 
            this.btn_attack.Location = new System.Drawing.Point(38, 361);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(75, 23);
            this.btn_attack.TabIndex = 1;
            this.btn_attack.Text = "attack";
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // rtb_combat
            // 
            this.rtb_combat.Location = new System.Drawing.Point(6, 19);
            this.rtb_combat.Name = "rtb_combat";
            this.rtb_combat.Size = new System.Drawing.Size(428, 293);
            this.rtb_combat.TabIndex = 2;
            this.rtb_combat.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 512);
            this.Controls.Add(this.gb_bag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_game);
            this.Controls.Add(this.gb_combat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_bag.ResumeLayout(false);
            this.gb_game.ResumeLayout(false);
            this.gb_combat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_life;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ListBox lb_bag;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_thirst;
        private System.Windows.Forms.Label lbl_hunger;
        private System.Windows.Forms.GroupBox gb_bag;
        private System.Windows.Forms.Label lbl_hand;
        private System.Windows.Forms.GroupBox gb_game;
        private System.Windows.Forms.RichTextBox rtb_game;
        private System.Windows.Forms.GroupBox gb_combat;
        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.RichTextBox rtb_combat;
        private System.Windows.Forms.Button act_4;
        private System.Windows.Forms.Button act_3;
        private System.Windows.Forms.Button act_2;
        private System.Windows.Forms.Button act_1;
    }
}

