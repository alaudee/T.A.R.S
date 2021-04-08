
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
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
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
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.AllowUserToResizeColumns = false;
            this.dgv_dados.AllowUserToResizeRows = false;
            this.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(12, 199);
            this.dgv_dados.MultiSelect = false;
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.RowHeadersVisible = false;
            this.dgv_dados.Size = new System.Drawing.Size(172, 129);
            this.dgv_dados.TabIndex = 7;
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 604);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.lbl_rolarDado);
            this.Controls.Add(this.lbl_corjogador);
            this.Controls.Add(this.lbl_senhajogador);
            this.Controls.Add(this.lbl_idjogador);
            this.Controls.Add(this.btn_iniciarpartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciarpartida;
        private System.Windows.Forms.Label lbl_idjogador;
        private System.Windows.Forms.Label lbl_senhajogador;
        private System.Windows.Forms.Label lbl_corjogador;
        private System.Windows.Forms.Button lbl_rolarDado;
        private System.Windows.Forms.DataGridView dgv_dados;
    }
}