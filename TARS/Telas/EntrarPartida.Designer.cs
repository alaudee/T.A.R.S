
namespace TARS.Telas
{
    partial class EntrarPartida
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
            this.btn_entrarpartida = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomejogador = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_jogadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_entrarpartida
            // 
            this.btn_entrarpartida.Location = new System.Drawing.Point(11, 278);
            this.btn_entrarpartida.Name = "btn_entrarpartida";
            this.btn_entrarpartida.Size = new System.Drawing.Size(97, 44);
            this.btn_entrarpartida.TabIndex = 4;
            this.btn_entrarpartida.Text = "Entrar na partida";
            this.btn_entrarpartida.UseVisualStyleBackColor = true;
            this.btn_entrarpartida.Click += new System.EventHandler(this.btn_entrarpartida_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(11, 252);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(303, 20);
            this.txt_senha.TabIndex = 13;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Digite a senha:";
            // 
            // txt_nomejogador
            // 
            this.txt_nomejogador.Location = new System.Drawing.Point(11, 213);
            this.txt_nomejogador.Name = "txt_nomejogador";
            this.txt_nomejogador.Size = new System.Drawing.Size(303, 20);
            this.txt_nomejogador.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(213, 278);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 44);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite seu nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jogadores:";
            // 
            // dgv_jogadores
            // 
            this.dgv_jogadores.AllowUserToAddRows = false;
            this.dgv_jogadores.AllowUserToDeleteRows = false;
            this.dgv_jogadores.AllowUserToResizeColumns = false;
            this.dgv_jogadores.AllowUserToResizeRows = false;
            this.dgv_jogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_jogadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_jogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jogadores.Location = new System.Drawing.Point(12, 25);
            this.dgv_jogadores.MultiSelect = false;
            this.dgv_jogadores.Name = "dgv_jogadores";
            this.dgv_jogadores.ReadOnly = true;
            this.dgv_jogadores.RowHeadersVisible = false;
            this.dgv_jogadores.Size = new System.Drawing.Size(302, 169);
            this.dgv_jogadores.TabIndex = 16;
            this.dgv_jogadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_jogadores_CellContentClick);
            // 
            // EntrarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 329);
            this.Controls.Add(this.dgv_jogadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomejogador);
            this.Controls.Add(this.btn_entrarpartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EntrarPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntrarPartida";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jogadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_entrarpartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomejogador;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_jogadores;
        private System.Windows.Forms.TextBox txt_senha;
    }
}