
namespace TARS
{
    partial class Tabuleiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuleiro));
            this.btn_iniciarpartida = new System.Windows.Forms.Button();
            this.lbl_idjogador = new System.Windows.Forms.Label();
            this.lbl_senhajogador = new System.Windows.Forms.Label();
            this.lbl_corjogador = new System.Windows.Forms.Label();
            this.btn_rolarDado = new System.Windows.Forms.Button();
            this.btn_verificarvez = new System.Windows.Forms.Button();
            this.btn_exibirTabuleiro = new System.Windows.Forms.Button();
            this.btn_mover = new System.Windows.Forms.Button();
            this.pcb_dado1 = new System.Windows.Forms.PictureBox();
            this.pcb_dado2 = new System.Windows.Forms.PictureBox();
            this.pcb_dado3 = new System.Windows.Forms.PictureBox();
            this.pcb_dado4 = new System.Windows.Forms.PictureBox();
            this.lbl_statuspart = new System.Windows.Forms.Label();
            this.gb_jogadas = new System.Windows.Forms.GroupBox();
            this.rdb_jogada3 = new System.Windows.Forms.RadioButton();
            this.rdb_jogada2 = new System.Windows.Forms.RadioButton();
            this.rdb_jogada1 = new System.Windows.Forms.RadioButton();
            this.btn_parar = new System.Windows.Forms.Button();
            this.dgv_teste = new System.Windows.Forms.DataGridView();
            this.pcb_t51 = new System.Windows.Forms.PictureBox();
            this.pcb_t21 = new System.Windows.Forms.PictureBox();
            this.pcb_t41 = new System.Windows.Forms.PictureBox();
            this.pcb_t31 = new System.Windows.Forms.PictureBox();
            this.pcb_t61 = new System.Windows.Forms.PictureBox();
            this.pcb_t71 = new System.Windows.Forms.PictureBox();
            this.pcb_81 = new System.Windows.Forms.PictureBox();
            this.pcb_t91 = new System.Windows.Forms.PictureBox();
            this.pcb_t101 = new System.Windows.Forms.PictureBox();
            this.pcb_t111 = new System.Windows.Forms.PictureBox();
            this.pcb_t121 = new System.Windows.Forms.PictureBox();
            this.pcb_t22 = new System.Windows.Forms.PictureBox();
            this.pcb_t23 = new System.Windows.Forms.PictureBox();
            this.rtxt_historicoP = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado4)).BeginInit();
            this.gb_jogadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t121)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t23)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciarpartida
            // 
            this.btn_iniciarpartida.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_iniciarpartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarpartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarpartida.Location = new System.Drawing.Point(12, 12);
            this.btn_iniciarpartida.Name = "btn_iniciarpartida";
            this.btn_iniciarpartida.Size = new System.Drawing.Size(119, 58);
            this.btn_iniciarpartida.TabIndex = 0;
            this.btn_iniciarpartida.Text = "Iniciar Partida";
            this.btn_iniciarpartida.UseVisualStyleBackColor = false;
            this.btn_iniciarpartida.Click += new System.EventHandler(this.btn_iniciarpartida_Click);
            // 
            // lbl_idjogador
            // 
            this.lbl_idjogador.AutoSize = true;
            this.lbl_idjogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idjogador.Location = new System.Drawing.Point(974, 560);
            this.lbl_idjogador.Name = "lbl_idjogador";
            this.lbl_idjogador.Size = new System.Drawing.Size(81, 20);
            this.lbl_idjogador.TabIndex = 1;
            this.lbl_idjogador.Text = "IdJogador";
            // 
            // lbl_senhajogador
            // 
            this.lbl_senhajogador.AutoSize = true;
            this.lbl_senhajogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhajogador.Location = new System.Drawing.Point(974, 590);
            this.lbl_senhajogador.Name = "lbl_senhajogador";
            this.lbl_senhajogador.Size = new System.Drawing.Size(56, 20);
            this.lbl_senhajogador.TabIndex = 2;
            this.lbl_senhajogador.Text = "Senha";
            // 
            // lbl_corjogador
            // 
            this.lbl_corjogador.AutoSize = true;
            this.lbl_corjogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_corjogador.Location = new System.Drawing.Point(974, 616);
            this.lbl_corjogador.Name = "lbl_corjogador";
            this.lbl_corjogador.Size = new System.Drawing.Size(34, 20);
            this.lbl_corjogador.TabIndex = 3;
            this.lbl_corjogador.Text = "Cor";
            // 
            // btn_rolarDado
            // 
            this.btn_rolarDado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_rolarDado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rolarDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rolarDado.Location = new System.Drawing.Point(12, 106);
            this.btn_rolarDado.Name = "btn_rolarDado";
            this.btn_rolarDado.Size = new System.Drawing.Size(119, 58);
            this.btn_rolarDado.TabIndex = 4;
            this.btn_rolarDado.Text = "Rolar Dados";
            this.btn_rolarDado.UseVisualStyleBackColor = false;
            this.btn_rolarDado.Click += new System.EventHandler(this.lbl_rolarDado_Click);
            // 
            // btn_verificarvez
            // 
            this.btn_verificarvez.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_verificarvez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verificarvez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificarvez.Location = new System.Drawing.Point(148, 12);
            this.btn_verificarvez.Name = "btn_verificarvez";
            this.btn_verificarvez.Size = new System.Drawing.Size(119, 58);
            this.btn_verificarvez.TabIndex = 8;
            this.btn_verificarvez.Text = "Verificar Vez";
            this.btn_verificarvez.UseVisualStyleBackColor = false;
            this.btn_verificarvez.Click += new System.EventHandler(this.bnt_verificarvez_Click);
            // 
            // btn_exibirTabuleiro
            // 
            this.btn_exibirTabuleiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_exibirTabuleiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exibirTabuleiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exibirTabuleiro.Location = new System.Drawing.Point(148, 106);
            this.btn_exibirTabuleiro.Name = "btn_exibirTabuleiro";
            this.btn_exibirTabuleiro.Size = new System.Drawing.Size(119, 58);
            this.btn_exibirTabuleiro.TabIndex = 9;
            this.btn_exibirTabuleiro.Text = "Exibir tabuleiro";
            this.btn_exibirTabuleiro.UseVisualStyleBackColor = false;
            this.btn_exibirTabuleiro.Click += new System.EventHandler(this.bnt_exibirTabuleiro_Click);
            // 
            // btn_mover
            // 
            this.btn_mover.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_mover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mover.Location = new System.Drawing.Point(12, 489);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(119, 58);
            this.btn_mover.TabIndex = 15;
            this.btn_mover.Text = "Mover";
            this.btn_mover.UseVisualStyleBackColor = false;
            this.btn_mover.Click += new System.EventHandler(this.btn_mover_Click);
            // 
            // pcb_dado1
            // 
            this.pcb_dado1.Location = new System.Drawing.Point(12, 189);
            this.pcb_dado1.Name = "pcb_dado1";
            this.pcb_dado1.Size = new System.Drawing.Size(77, 68);
            this.pcb_dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_dado1.TabIndex = 17;
            this.pcb_dado1.TabStop = false;
            // 
            // pcb_dado2
            // 
            this.pcb_dado2.Location = new System.Drawing.Point(95, 189);
            this.pcb_dado2.Name = "pcb_dado2";
            this.pcb_dado2.Size = new System.Drawing.Size(77, 68);
            this.pcb_dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_dado2.TabIndex = 18;
            this.pcb_dado2.TabStop = false;
            // 
            // pcb_dado3
            // 
            this.pcb_dado3.Location = new System.Drawing.Point(12, 272);
            this.pcb_dado3.Name = "pcb_dado3";
            this.pcb_dado3.Size = new System.Drawing.Size(77, 68);
            this.pcb_dado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_dado3.TabIndex = 19;
            this.pcb_dado3.TabStop = false;
            // 
            // pcb_dado4
            // 
            this.pcb_dado4.Location = new System.Drawing.Point(96, 272);
            this.pcb_dado4.Name = "pcb_dado4";
            this.pcb_dado4.Size = new System.Drawing.Size(77, 68);
            this.pcb_dado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_dado4.TabIndex = 20;
            this.pcb_dado4.TabStop = false;
            // 
            // lbl_statuspart
            // 
            this.lbl_statuspart.AutoSize = true;
            this.lbl_statuspart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_statuspart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statuspart.ForeColor = System.Drawing.Color.Red;
            this.lbl_statuspart.Location = new System.Drawing.Point(918, 9);
            this.lbl_statuspart.Name = "lbl_statuspart";
            this.lbl_statuspart.Size = new System.Drawing.Size(224, 29);
            this.lbl_statuspart.TabIndex = 21;
            this.lbl_statuspart.Text = "Partida não iniciada";
            // 
            // gb_jogadas
            // 
            this.gb_jogadas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_jogadas.Controls.Add(this.rdb_jogada3);
            this.gb_jogadas.Controls.Add(this.rdb_jogada2);
            this.gb_jogadas.Controls.Add(this.rdb_jogada1);
            this.gb_jogadas.Location = new System.Drawing.Point(12, 373);
            this.gb_jogadas.Name = "gb_jogadas";
            this.gb_jogadas.Size = new System.Drawing.Size(245, 110);
            this.gb_jogadas.TabIndex = 22;
            this.gb_jogadas.TabStop = false;
            this.gb_jogadas.Text = "Jogadas";
            // 
            // rdb_jogada3
            // 
            this.rdb_jogada3.AutoSize = true;
            this.rdb_jogada3.Location = new System.Drawing.Point(73, 74);
            this.rdb_jogada3.Name = "rdb_jogada3";
            this.rdb_jogada3.Size = new System.Drawing.Size(85, 17);
            this.rdb_jogada3.TabIndex = 2;
            this.rdb_jogada3.TabStop = true;
            this.rdb_jogada3.Text = "radioButton3";
            this.rdb_jogada3.UseVisualStyleBackColor = true;
            this.rdb_jogada3.CheckedChanged += new System.EventHandler(this.rdb_jogada3_CheckedChanged);
            // 
            // rdb_jogada2
            // 
            this.rdb_jogada2.AutoSize = true;
            this.rdb_jogada2.Location = new System.Drawing.Point(73, 51);
            this.rdb_jogada2.Name = "rdb_jogada2";
            this.rdb_jogada2.Size = new System.Drawing.Size(85, 17);
            this.rdb_jogada2.TabIndex = 1;
            this.rdb_jogada2.TabStop = true;
            this.rdb_jogada2.Text = "radioButton2";
            this.rdb_jogada2.UseVisualStyleBackColor = true;
            this.rdb_jogada2.CheckedChanged += new System.EventHandler(this.rdb_jogada2_CheckedChanged);
            // 
            // rdb_jogada1
            // 
            this.rdb_jogada1.AutoSize = true;
            this.rdb_jogada1.Location = new System.Drawing.Point(73, 28);
            this.rdb_jogada1.Name = "rdb_jogada1";
            this.rdb_jogada1.Size = new System.Drawing.Size(85, 17);
            this.rdb_jogada1.TabIndex = 0;
            this.rdb_jogada1.TabStop = true;
            this.rdb_jogada1.Text = "radioButton1";
            this.rdb_jogada1.UseVisualStyleBackColor = true;
            this.rdb_jogada1.CheckedChanged += new System.EventHandler(this.rdb_jogada1_CheckedChanged);
            // 
            // btn_parar
            // 
            this.btn_parar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_parar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parar.Location = new System.Drawing.Point(148, 489);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(119, 58);
            this.btn_parar.TabIndex = 24;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = false;
            this.btn_parar.Visible = false;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // dgv_teste
            // 
            this.dgv_teste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teste.Location = new System.Drawing.Point(292, 12);
            this.dgv_teste.Name = "dgv_teste";
            this.dgv_teste.Size = new System.Drawing.Size(446, 150);
            this.dgv_teste.TabIndex = 25;
            // 
            // pcb_t51
            // 
            this.pcb_t51.Location = new System.Drawing.Point(711, 539);
            this.pcb_t51.Name = "pcb_t51";
            this.pcb_t51.Size = new System.Drawing.Size(30, 30);
            this.pcb_t51.TabIndex = 26;
            this.pcb_t51.TabStop = false;
            this.pcb_t51.Visible = false;
            // 
            // pcb_t21
            // 
            this.pcb_t21.Location = new System.Drawing.Point(549, 382);
            this.pcb_t21.Name = "pcb_t21";
            this.pcb_t21.Size = new System.Drawing.Size(30, 30);
            this.pcb_t21.TabIndex = 27;
            this.pcb_t21.TabStop = false;
            this.pcb_t21.Visible = false;
            // 
            // pcb_t41
            // 
            this.pcb_t41.Location = new System.Drawing.Point(654, 489);
            this.pcb_t41.Name = "pcb_t41";
            this.pcb_t41.Size = new System.Drawing.Size(30, 30);
            this.pcb_t41.TabIndex = 28;
            this.pcb_t41.TabStop = false;
            this.pcb_t41.Visible = false;
            // 
            // pcb_t31
            // 
            this.pcb_t31.Location = new System.Drawing.Point(603, 437);
            this.pcb_t31.Name = "pcb_t31";
            this.pcb_t31.Size = new System.Drawing.Size(30, 30);
            this.pcb_t31.TabIndex = 29;
            this.pcb_t31.TabStop = false;
            this.pcb_t31.Visible = false;
            // 
            // pcb_t61
            // 
            this.pcb_t61.Location = new System.Drawing.Point(751, 583);
            this.pcb_t61.Name = "pcb_t61";
            this.pcb_t61.Size = new System.Drawing.Size(30, 30);
            this.pcb_t61.TabIndex = 30;
            this.pcb_t61.TabStop = false;
            this.pcb_t61.Visible = false;
            // 
            // pcb_t71
            // 
            this.pcb_t71.Location = new System.Drawing.Point(797, 626);
            this.pcb_t71.Name = "pcb_t71";
            this.pcb_t71.Size = new System.Drawing.Size(30, 30);
            this.pcb_t71.TabIndex = 31;
            this.pcb_t71.TabStop = false;
            this.pcb_t71.Visible = false;
            // 
            // pcb_81
            // 
            this.pcb_81.Location = new System.Drawing.Point(845, 584);
            this.pcb_81.Name = "pcb_81";
            this.pcb_81.Size = new System.Drawing.Size(30, 30);
            this.pcb_81.TabIndex = 32;
            this.pcb_81.TabStop = false;
            this.pcb_81.Visible = false;
            // 
            // pcb_t91
            // 
            this.pcb_t91.Location = new System.Drawing.Point(888, 539);
            this.pcb_t91.Name = "pcb_t91";
            this.pcb_t91.Size = new System.Drawing.Size(30, 30);
            this.pcb_t91.TabIndex = 33;
            this.pcb_t91.TabStop = false;
            this.pcb_t91.Visible = false;
            // 
            // pcb_t101
            // 
            this.pcb_t101.Location = new System.Drawing.Point(939, 489);
            this.pcb_t101.Name = "pcb_t101";
            this.pcb_t101.Size = new System.Drawing.Size(30, 30);
            this.pcb_t101.TabIndex = 34;
            this.pcb_t101.TabStop = false;
            this.pcb_t101.Visible = false;
            // 
            // pcb_t111
            // 
            this.pcb_t111.Location = new System.Drawing.Point(997, 436);
            this.pcb_t111.Name = "pcb_t111";
            this.pcb_t111.Size = new System.Drawing.Size(30, 30);
            this.pcb_t111.TabIndex = 35;
            this.pcb_t111.TabStop = false;
            this.pcb_t111.Visible = false;
            // 
            // pcb_t121
            // 
            this.pcb_t121.Location = new System.Drawing.Point(1046, 382);
            this.pcb_t121.Name = "pcb_t121";
            this.pcb_t121.Size = new System.Drawing.Size(30, 30);
            this.pcb_t121.TabIndex = 36;
            this.pcb_t121.TabStop = false;
            this.pcb_t121.Visible = false;
            // 
            // pcb_t22
            // 
            this.pcb_t22.Location = new System.Drawing.Point(549, 326);
            this.pcb_t22.Name = "pcb_t22";
            this.pcb_t22.Size = new System.Drawing.Size(30, 30);
            this.pcb_t22.TabIndex = 37;
            this.pcb_t22.TabStop = false;
            this.pcb_t22.Visible = false;
            // 
            // pcb_t23
            // 
            this.pcb_t23.Location = new System.Drawing.Point(549, 270);
            this.pcb_t23.Name = "pcb_t23";
            this.pcb_t23.Size = new System.Drawing.Size(30, 30);
            this.pcb_t23.TabIndex = 38;
            this.pcb_t23.TabStop = false;
            this.pcb_t23.Visible = false;
            // 
            // rtxt_historicoP
            // 
            this.rtxt_historicoP.Location = new System.Drawing.Point(335, 539);
            this.rtxt_historicoP.Name = "rtxt_historicoP";
            this.rtxt_historicoP.Size = new System.Drawing.Size(295, 128);
            this.rtxt_historicoP.TabIndex = 39;
            this.rtxt_historicoP.Text = "";
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 679);
            this.Controls.Add(this.rtxt_historicoP);
            this.Controls.Add(this.pcb_t23);
            this.Controls.Add(this.pcb_t22);
            this.Controls.Add(this.pcb_t121);
            this.Controls.Add(this.pcb_t111);
            this.Controls.Add(this.pcb_t101);
            this.Controls.Add(this.pcb_t91);
            this.Controls.Add(this.pcb_81);
            this.Controls.Add(this.pcb_t71);
            this.Controls.Add(this.pcb_t61);
            this.Controls.Add(this.pcb_t31);
            this.Controls.Add(this.pcb_t41);
            this.Controls.Add(this.pcb_t21);
            this.Controls.Add(this.pcb_t51);
            this.Controls.Add(this.dgv_teste);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.gb_jogadas);
            this.Controls.Add(this.lbl_statuspart);
            this.Controls.Add(this.pcb_dado4);
            this.Controls.Add(this.pcb_dado3);
            this.Controls.Add(this.pcb_dado2);
            this.Controls.Add(this.pcb_dado1);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.btn_exibirTabuleiro);
            this.Controls.Add(this.btn_verificarvez);
            this.Controls.Add(this.btn_rolarDado);
            this.Controls.Add(this.lbl_corjogador);
            this.Controls.Add(this.lbl_senhajogador);
            this.Controls.Add(this.lbl_idjogador);
            this.Controls.Add(this.btn_iniciarpartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado4)).EndInit();
            this.gb_jogadas.ResumeLayout(false);
            this.gb_jogadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t121)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_t23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciarpartida;
        private System.Windows.Forms.Label lbl_idjogador;
        private System.Windows.Forms.Label lbl_senhajogador;
        private System.Windows.Forms.Label lbl_corjogador;
        private System.Windows.Forms.Button btn_rolarDado;
        private System.Windows.Forms.Button btn_verificarvez;
        private System.Windows.Forms.Button btn_exibirTabuleiro;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.PictureBox pcb_dado1;
        private System.Windows.Forms.PictureBox pcb_dado2;
        private System.Windows.Forms.PictureBox pcb_dado3;
        private System.Windows.Forms.PictureBox pcb_dado4;
        private System.Windows.Forms.Label lbl_statuspart;
        private System.Windows.Forms.GroupBox gb_jogadas;
        private System.Windows.Forms.RadioButton rdb_jogada3;
        private System.Windows.Forms.RadioButton rdb_jogada2;
        private System.Windows.Forms.RadioButton rdb_jogada1;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.DataGridView dgv_teste;
        private System.Windows.Forms.PictureBox pcb_t51;
        private System.Windows.Forms.PictureBox pcb_t21;
        private System.Windows.Forms.PictureBox pcb_t41;
        private System.Windows.Forms.PictureBox pcb_t31;
        private System.Windows.Forms.PictureBox pcb_t61;
        private System.Windows.Forms.PictureBox pcb_t71;
        private System.Windows.Forms.PictureBox pcb_81;
        private System.Windows.Forms.PictureBox pcb_t91;
        private System.Windows.Forms.PictureBox pcb_t101;
        private System.Windows.Forms.PictureBox pcb_t111;
        private System.Windows.Forms.PictureBox pcb_t121;
        private System.Windows.Forms.PictureBox pcb_t22;
        private System.Windows.Forms.PictureBox pcb_t23;
        private System.Windows.Forms.RichTextBox rtxt_historicoP;
    }
}