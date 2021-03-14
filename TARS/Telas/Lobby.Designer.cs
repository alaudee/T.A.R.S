
namespace TARS
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.btn_listarpartidas = new System.Windows.Forms.Button();
            this.btn_listarjogadores = new System.Windows.Forms.Button();
            this.txt_jogadores = new System.Windows.Forms.TextBox();
            this.btn_entrarpartida = new System.Windows.Forms.Button();
            this.dgv_partidas = new System.Windows.Forms.DataGridView();
            this.txt_nomejogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_criarpartida = new System.Windows.Forms.Button();
            this.txt_senhapartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nomepartida = new System.Windows.Forms.TextBox();
            this.lbl_versao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_listarpartidas
            // 
            this.btn_listarpartidas.Location = new System.Drawing.Point(12, 12);
            this.btn_listarpartidas.Name = "btn_listarpartidas";
            this.btn_listarpartidas.Size = new System.Drawing.Size(125, 70);
            this.btn_listarpartidas.TabIndex = 0;
            this.btn_listarpartidas.Text = "Listar partidas";
            this.btn_listarpartidas.UseVisualStyleBackColor = true;
            this.btn_listarpartidas.Click += new System.EventHandler(this.btn_Listarpartidas_Click);
            // 
            // btn_listarjogadores
            // 
            this.btn_listarjogadores.Location = new System.Drawing.Point(619, 12);
            this.btn_listarjogadores.Name = "btn_listarjogadores";
            this.btn_listarjogadores.Size = new System.Drawing.Size(125, 70);
            this.btn_listarjogadores.TabIndex = 2;
            this.btn_listarjogadores.Text = "Listar jogadores";
            this.btn_listarjogadores.UseVisualStyleBackColor = true;
            this.btn_listarjogadores.Click += new System.EventHandler(this.btn_listarjogadores_Click);
            // 
            // txt_jogadores
            // 
            this.txt_jogadores.Location = new System.Drawing.Point(750, 12);
            this.txt_jogadores.Multiline = true;
            this.txt_jogadores.Name = "txt_jogadores";
            this.txt_jogadores.Size = new System.Drawing.Size(174, 289);
            this.txt_jogadores.TabIndex = 3;
            this.txt_jogadores.TextChanged += new System.EventHandler(this.txt_jogadores_TextChanged);
            // 
            // btn_entrarpartida
            // 
            this.btn_entrarpartida.Location = new System.Drawing.Point(619, 322);
            this.btn_entrarpartida.Name = "btn_entrarpartida";
            this.btn_entrarpartida.Size = new System.Drawing.Size(125, 70);
            this.btn_entrarpartida.TabIndex = 4;
            this.btn_entrarpartida.Text = "Entrar Partida";
            this.btn_entrarpartida.UseVisualStyleBackColor = true;
            this.btn_entrarpartida.Click += new System.EventHandler(this.btn_entrarpartida_Click);
            // 
            // dgv_partidas
            // 
            this.dgv_partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_partidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_partidas.Location = new System.Drawing.Point(143, 12);
            this.dgv_partidas.MultiSelect = false;
            this.dgv_partidas.Name = "dgv_partidas";
            this.dgv_partidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_partidas.Size = new System.Drawing.Size(470, 310);
            this.dgv_partidas.TabIndex = 5;
            this.dgv_partidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_partidas_CellContentClick);
            // 
            // txt_nomejogador
            // 
            this.txt_nomejogador.Location = new System.Drawing.Point(140, 351);
            this.txt_nomejogador.Name = "txt_nomejogador";
            this.txt_nomejogador.Size = new System.Drawing.Size(232, 20);
            this.txt_nomejogador.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(140, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(392, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite a senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(395, 351);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(218, 20);
            this.txt_senha.TabIndex = 9;
            // 
            // btn_criarpartida
            // 
            this.btn_criarpartida.Location = new System.Drawing.Point(619, 398);
            this.btn_criarpartida.Name = "btn_criarpartida";
            this.btn_criarpartida.Size = new System.Drawing.Size(125, 70);
            this.btn_criarpartida.TabIndex = 10;
            this.btn_criarpartida.Text = "Criar Partida";
            this.btn_criarpartida.UseVisualStyleBackColor = true;
            this.btn_criarpartida.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_senhapartida
            // 
            this.txt_senhapartida.Location = new System.Drawing.Point(395, 420);
            this.txt_senhapartida.Name = "txt_senhapartida";
            this.txt_senhapartida.Size = new System.Drawing.Size(218, 20);
            this.txt_senhapartida.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(392, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Digite a senha da partida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(140, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite o nome da partida:";
            // 
            // txt_nomepartida
            // 
            this.txt_nomepartida.Location = new System.Drawing.Point(140, 420);
            this.txt_nomepartida.Name = "txt_nomepartida";
            this.txt_nomepartida.Size = new System.Drawing.Size(232, 20);
            this.txt_nomepartida.TabIndex = 11;
            // 
            // lbl_versao
            // 
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_versao.Location = new System.Drawing.Point(872, 530);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(35, 13);
            this.lbl_versao.TabIndex = 15;
            this.lbl_versao.Text = "label5";
            this.lbl_versao.Click += new System.EventHandler(this.lbl_versao_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 552);
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.txt_senhapartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nomepartida);
            this.Controls.Add(this.btn_criarpartida);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomejogador);
            this.Controls.Add(this.dgv_partidas);
            this.Controls.Add(this.btn_entrarpartida);
            this.Controls.Add(this.txt_jogadores);
            this.Controls.Add(this.btn_listarjogadores);
            this.Controls.Add(this.btn_listarpartidas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Lobby";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listarpartidas;
        private System.Windows.Forms.Button btn_listarjogadores;
        private System.Windows.Forms.TextBox txt_jogadores;
        private System.Windows.Forms.Button btn_entrarpartida;
        private System.Windows.Forms.DataGridView dgv_partidas;
        private System.Windows.Forms.TextBox txt_nomejogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_criarpartida;
        private System.Windows.Forms.TextBox txt_senhapartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nomepartida;
        private System.Windows.Forms.Label lbl_versao;
    }
}

