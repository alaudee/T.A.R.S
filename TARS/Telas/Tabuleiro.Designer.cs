
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
            this.lbl_rolarDado = new System.Windows.Forms.Button();
            this.bnt_verificarvez = new System.Windows.Forms.Button();
            this.bnt_exibirTabuleiro = new System.Windows.Forms.Button();
            this.btn_mover = new System.Windows.Forms.Button();
            this.pcb_dado1 = new System.Windows.Forms.PictureBox();
            this.pcb_dado2 = new System.Windows.Forms.PictureBox();
            this.pcb_dado3 = new System.Windows.Forms.PictureBox();
            this.pcb_dado4 = new System.Windows.Forms.PictureBox();
            this.lbl_statuspart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado4)).BeginInit();
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
            this.lbl_idjogador.Location = new System.Drawing.Point(832, 514);
            this.lbl_idjogador.Name = "lbl_idjogador";
            this.lbl_idjogador.Size = new System.Drawing.Size(81, 20);
            this.lbl_idjogador.TabIndex = 1;
            this.lbl_idjogador.Text = "IdJogador";
            // 
            // lbl_senhajogador
            // 
            this.lbl_senhajogador.AutoSize = true;
            this.lbl_senhajogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhajogador.Location = new System.Drawing.Point(832, 544);
            this.lbl_senhajogador.Name = "lbl_senhajogador";
            this.lbl_senhajogador.Size = new System.Drawing.Size(56, 20);
            this.lbl_senhajogador.TabIndex = 2;
            this.lbl_senhajogador.Text = "Senha";
            // 
            // lbl_corjogador
            // 
            this.lbl_corjogador.AutoSize = true;
            this.lbl_corjogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_corjogador.Location = new System.Drawing.Point(832, 570);
            this.lbl_corjogador.Name = "lbl_corjogador";
            this.lbl_corjogador.Size = new System.Drawing.Size(34, 20);
            this.lbl_corjogador.TabIndex = 3;
            this.lbl_corjogador.Text = "Cor";
            // 
            // lbl_rolarDado
            // 
            this.lbl_rolarDado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_rolarDado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_rolarDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rolarDado.Location = new System.Drawing.Point(12, 106);
            this.lbl_rolarDado.Name = "lbl_rolarDado";
            this.lbl_rolarDado.Size = new System.Drawing.Size(119, 58);
            this.lbl_rolarDado.TabIndex = 4;
            this.lbl_rolarDado.Text = "Rolar Dados";
            this.lbl_rolarDado.UseVisualStyleBackColor = false;
            this.lbl_rolarDado.Click += new System.EventHandler(this.lbl_rolarDado_Click);
            // 
            // bnt_verificarvez
            // 
            this.bnt_verificarvez.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bnt_verificarvez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_verificarvez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_verificarvez.Location = new System.Drawing.Point(148, 12);
            this.bnt_verificarvez.Name = "bnt_verificarvez";
            this.bnt_verificarvez.Size = new System.Drawing.Size(119, 58);
            this.bnt_verificarvez.TabIndex = 8;
            this.bnt_verificarvez.Text = "Verificar Vez";
            this.bnt_verificarvez.UseVisualStyleBackColor = false;
            this.bnt_verificarvez.Click += new System.EventHandler(this.bnt_verificarvez_Click);
            // 
            // bnt_exibirTabuleiro
            // 
            this.bnt_exibirTabuleiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bnt_exibirTabuleiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_exibirTabuleiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_exibirTabuleiro.Location = new System.Drawing.Point(148, 106);
            this.bnt_exibirTabuleiro.Name = "bnt_exibirTabuleiro";
            this.bnt_exibirTabuleiro.Size = new System.Drawing.Size(119, 58);
            this.bnt_exibirTabuleiro.TabIndex = 9;
            this.bnt_exibirTabuleiro.Text = "Exibir tabuleiro";
            this.bnt_exibirTabuleiro.UseVisualStyleBackColor = false;
            this.bnt_exibirTabuleiro.Click += new System.EventHandler(this.bnt_exibirTabuleiro_Click);
            // 
            // btn_mover
            // 
            this.btn_mover.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_mover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mover.Location = new System.Drawing.Point(285, 12);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(119, 58);
            this.btn_mover.TabIndex = 15;
            this.btn_mover.Text = "Mover";
            this.btn_mover.UseVisualStyleBackColor = false;
            // 
            // pcb_dado1
            // 
            this.pcb_dado1.Location = new System.Drawing.Point(12, 225);
            this.pcb_dado1.Name = "pcb_dado1";
            this.pcb_dado1.Size = new System.Drawing.Size(77, 68);
            this.pcb_dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_dado1.TabIndex = 17;
            this.pcb_dado1.TabStop = false;
            // 
            // pcb_dado2
            // 
            this.pcb_dado2.Location = new System.Drawing.Point(95, 225);
            this.pcb_dado2.Name = "pcb_dado2";
            this.pcb_dado2.Size = new System.Drawing.Size(77, 68);
            this.pcb_dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_dado2.TabIndex = 18;
            this.pcb_dado2.TabStop = false;
            // 
            // pcb_dado3
            // 
            this.pcb_dado3.Location = new System.Drawing.Point(12, 308);
            this.pcb_dado3.Name = "pcb_dado3";
            this.pcb_dado3.Size = new System.Drawing.Size(77, 68);
            this.pcb_dado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_dado3.TabIndex = 19;
            this.pcb_dado3.TabStop = false;
            // 
            // pcb_dado4
            // 
            this.pcb_dado4.Location = new System.Drawing.Point(96, 308);
            this.pcb_dado4.Name = "pcb_dado4";
            this.pcb_dado4.Size = new System.Drawing.Size(77, 68);
            this.pcb_dado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_dado4.TabIndex = 20;
            this.pcb_dado4.TabStop = false;
            // 
            // lbl_statuspart
            // 
            this.lbl_statuspart.AutoSize = true;
            this.lbl_statuspart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statuspart.ForeColor = System.Drawing.Color.Red;
            this.lbl_statuspart.Location = new System.Drawing.Point(745, 12);
            this.lbl_statuspart.Name = "lbl_statuspart";
            this.lbl_statuspart.Size = new System.Drawing.Size(224, 29);
            this.lbl_statuspart.TabIndex = 21;
            this.lbl_statuspart.Text = "Partida não iniciada";
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 604);
            this.Controls.Add(this.lbl_statuspart);
            this.Controls.Add(this.pcb_dado4);
            this.Controls.Add(this.pcb_dado3);
            this.Controls.Add(this.pcb_dado2);
            this.Controls.Add(this.pcb_dado1);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.bnt_exibirTabuleiro);
            this.Controls.Add(this.bnt_verificarvez);
            this.Controls.Add(this.lbl_rolarDado);
            this.Controls.Add(this.lbl_corjogador);
            this.Controls.Add(this.lbl_senhajogador);
            this.Controls.Add(this.lbl_idjogador);
            this.Controls.Add(this.btn_iniciarpartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_dado4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciarpartida;
        private System.Windows.Forms.Label lbl_idjogador;
        private System.Windows.Forms.Label lbl_senhajogador;
        private System.Windows.Forms.Label lbl_corjogador;
        private System.Windows.Forms.Button lbl_rolarDado;
        private System.Windows.Forms.Button bnt_verificarvez;
        private System.Windows.Forms.Button bnt_exibirTabuleiro;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.PictureBox pcb_dado1;
        private System.Windows.Forms.PictureBox pcb_dado2;
        private System.Windows.Forms.PictureBox pcb_dado3;
        private System.Windows.Forms.PictureBox pcb_dado4;
        private System.Windows.Forms.Label lbl_statuspart;
    }
}