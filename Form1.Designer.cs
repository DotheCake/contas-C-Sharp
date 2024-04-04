namespace modulo_de_divisão
{
    partial class frmRestoDeDivisao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtRestoDaDivisao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSoma1 = new System.Windows.Forms.TextBox();
            this.txtSoma2 = new System.Windows.Forms.TextBox();
            this.txtResultadoDaSoma = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.txtResultadoSub = new System.Windows.Forms.TextBox();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMulti1 = new System.Windows.Forms.TextBox();
            this.txtMulti2 = new System.Windows.Forms.TextBox();
            this.txtResultadoDaMulti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSomaTres1 = new System.Windows.Forms.TextBox();
            this.txtSomaTres2 = new System.Windows.Forms.TextBox();
            this.txtSomaTres3 = new System.Windows.Forms.TextBox();
            this.txtResultadoSomaTres = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.txtNumero4 = new System.Windows.Forms.TextBox();
            this.txtNumero5 = new System.Windows.Forms.TextBox();
            this.txtResultadoDaConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dividendo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Divisor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resto:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(141, 47);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 26);
            this.txtDividendo.TabIndex = 3;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(352, 47);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 26);
            this.txtDivisor.TabIndex = 4;
            // 
            // txtRestoDaDivisao
            // 
            this.txtRestoDaDivisao.Location = new System.Drawing.Point(352, 128);
            this.txtRestoDaDivisao.Name = "txtRestoDaDivisao";
            this.txtRestoDaDivisao.ReadOnly = true;
            this.txtRestoDaDivisao.Size = new System.Drawing.Size(100, 26);
            this.txtRestoDaDivisao.TabIndex = 5;
            this.txtRestoDaDivisao.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Realizar divisão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(607, 50);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(82, 20);
            this.lb.TabIndex = 7;
            this.lb.Text = "Numero 1:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(812, 50);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(82, 20);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "Numero 2:";
            this.lb2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(808, 131);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(86, 20);
            this.lb3.TabIndex = 9;
            this.lb3.Text = "Resultado:";
            this.lb3.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Realizar Soma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSoma1
            // 
            this.txtSoma1.Location = new System.Drawing.Point(695, 47);
            this.txtSoma1.Name = "txtSoma1";
            this.txtSoma1.Size = new System.Drawing.Size(100, 26);
            this.txtSoma1.TabIndex = 11;
            // 
            // txtSoma2
            // 
            this.txtSoma2.Location = new System.Drawing.Point(900, 47);
            this.txtSoma2.Name = "txtSoma2";
            this.txtSoma2.Size = new System.Drawing.Size(100, 26);
            this.txtSoma2.TabIndex = 12;
            // 
            // txtResultadoDaSoma
            // 
            this.txtResultadoDaSoma.Location = new System.Drawing.Point(900, 128);
            this.txtResultadoDaSoma.Name = "txtResultadoDaSoma";
            this.txtResultadoDaSoma.ReadOnly = true;
            this.txtResultadoDaSoma.Size = new System.Drawing.Size(100, 26);
            this.txtResultadoDaSoma.TabIndex = 13;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(53, 233);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(82, 20);
            this.lb4.TabIndex = 14;
            this.lb4.Text = "Numero 1:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(264, 233);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(82, 20);
            this.lb5.TabIndex = 15;
            this.lb5.Text = "Numero 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Resultado:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Realizar Subtração";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSub1
            // 
            this.txtSub1.Location = new System.Drawing.Point(141, 230);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(100, 26);
            this.txtSub1.TabIndex = 18;
            // 
            // txtResultadoSub
            // 
            this.txtResultadoSub.Location = new System.Drawing.Point(352, 315);
            this.txtResultadoSub.Name = "txtResultadoSub";
            this.txtResultadoSub.ReadOnly = true;
            this.txtResultadoSub.Size = new System.Drawing.Size(100, 26);
            this.txtResultadoSub.TabIndex = 19;
            // 
            // txtSub2
            // 
            this.txtSub2.Location = new System.Drawing.Point(352, 230);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(100, 26);
            this.txtSub2.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(611, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "Realizar Multiplicação";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Numero 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(812, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Numero 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(808, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Resultado:";
            // 
            // txtMulti1
            // 
            this.txtMulti1.Location = new System.Drawing.Point(697, 230);
            this.txtMulti1.Name = "txtMulti1";
            this.txtMulti1.Size = new System.Drawing.Size(100, 26);
            this.txtMulti1.TabIndex = 25;
            // 
            // txtMulti2
            // 
            this.txtMulti2.Location = new System.Drawing.Point(900, 230);
            this.txtMulti2.Name = "txtMulti2";
            this.txtMulti2.Size = new System.Drawing.Size(100, 26);
            this.txtMulti2.TabIndex = 26;
            // 
            // txtResultadoDaMulti
            // 
            this.txtResultadoDaMulti.Location = new System.Drawing.Point(900, 318);
            this.txtResultadoDaMulti.Name = "txtResultadoDaMulti";
            this.txtResultadoDaMulti.ReadOnly = true;
            this.txtResultadoDaMulti.Size = new System.Drawing.Size(100, 26);
            this.txtResultadoDaMulti.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Numero 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Numero 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Numero 3:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(56, 555);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 35);
            this.button5.TabIndex = 31;
            this.button5.Text = "Realizar Soma ^3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtSomaTres1
            // 
            this.txtSomaTres1.Location = new System.Drawing.Point(141, 480);
            this.txtSomaTres1.Name = "txtSomaTres1";
            this.txtSomaTres1.Size = new System.Drawing.Size(100, 26);
            this.txtSomaTres1.TabIndex = 32;
            // 
            // txtSomaTres2
            // 
            this.txtSomaTres2.Location = new System.Drawing.Point(352, 483);
            this.txtSomaTres2.Name = "txtSomaTres2";
            this.txtSomaTres2.Size = new System.Drawing.Size(100, 26);
            this.txtSomaTres2.TabIndex = 33;
            // 
            // txtSomaTres3
            // 
            this.txtSomaTres3.Location = new System.Drawing.Point(568, 483);
            this.txtSomaTres3.Name = "txtSomaTres3";
            this.txtSomaTres3.Size = new System.Drawing.Size(100, 26);
            this.txtSomaTres3.TabIndex = 34;
            // 
            // txtResultadoSomaTres
            // 
            this.txtResultadoSomaTres.Location = new System.Drawing.Point(407, 559);
            this.txtResultadoSomaTres.Name = "txtResultadoSomaTres";
            this.txtResultadoSomaTres.ReadOnly = true;
            this.txtResultadoSomaTres.Size = new System.Drawing.Size(100, 26);
            this.txtResultadoSomaTres.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Resultado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(781, 483);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Numero 1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(984, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Numero 2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(781, 642);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Numero 5:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(781, 570);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Numero 3:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(984, 570);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "Numero 4:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(795, 682);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 36);
            this.button6.TabIndex = 42;
            this.button6.Text = "Realizar conta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(980, 698);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 43;
            this.label17.Text = "Resultado:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(859, 480);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 26);
            this.txtNumero1.TabIndex = 44;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(1072, 480);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 26);
            this.txtNumero2.TabIndex = 45;
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(859, 567);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 26);
            this.txtNumero3.TabIndex = 46;
            // 
            // txtNumero4
            // 
            this.txtNumero4.Location = new System.Drawing.Point(1072, 567);
            this.txtNumero4.Name = "txtNumero4";
            this.txtNumero4.Size = new System.Drawing.Size(100, 26);
            this.txtNumero4.TabIndex = 47;
            // 
            // txtNumero5
            // 
            this.txtNumero5.Location = new System.Drawing.Point(859, 639);
            this.txtNumero5.Name = "txtNumero5";
            this.txtNumero5.Size = new System.Drawing.Size(100, 26);
            this.txtNumero5.TabIndex = 48;
            this.txtNumero5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtResultadoDaConta
            // 
            this.txtResultadoDaConta.Location = new System.Drawing.Point(1072, 695);
            this.txtResultadoDaConta.Name = "txtResultadoDaConta";
            this.txtResultadoDaConta.ReadOnly = true;
            this.txtResultadoDaConta.Size = new System.Drawing.Size(100, 26);
            this.txtResultadoDaConta.TabIndex = 49;
            // 
            // frmRestoDeDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 810);
            this.Controls.Add(this.txtResultadoDaConta);
            this.Controls.Add(this.txtNumero5);
            this.Controls.Add(this.txtNumero4);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtResultadoSomaTres);
            this.Controls.Add(this.txtSomaTres3);
            this.Controls.Add(this.txtSomaTres2);
            this.Controls.Add(this.txtSomaTres1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtResultadoDaMulti);
            this.Controls.Add(this.txtMulti2);
            this.Controls.Add(this.txtMulti1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.txtResultadoSub);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.txtResultadoDaSoma);
            this.Controls.Add(this.txtSoma2);
            this.Controls.Add(this.txtSoma1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRestoDaDivisao);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRestoDeDivisao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtRestoDaDivisao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSoma1;
        private System.Windows.Forms.TextBox txtSoma2;
        private System.Windows.Forms.TextBox txtResultadoDaSoma;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.TextBox txtResultadoSub;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMulti1;
        private System.Windows.Forms.TextBox txtMulti2;
        private System.Windows.Forms.TextBox txtResultadoDaMulti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSomaTres1;
        private System.Windows.Forms.TextBox txtSomaTres2;
        private System.Windows.Forms.TextBox txtSomaTres3;
        private System.Windows.Forms.TextBox txtResultadoSomaTres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.TextBox txtNumero4;
        private System.Windows.Forms.TextBox txtNumero5;
        private System.Windows.Forms.TextBox txtResultadoDaConta;
    }
}

