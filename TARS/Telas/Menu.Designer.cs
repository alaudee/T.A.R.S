
namespace TARS
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_criarpartida = new System.Windows.Forms.Button();
            this.btn_entrarpartida = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.dgv_partidas = new System.Windows.Forms.DataGridView();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.btn_atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Can\'t Stop";
            // 
            // btn_criarpartida
            // 
            this.btn_criarpartida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_criarpartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criarpartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criarpartida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_criarpartida.Location = new System.Drawing.Point(61, 473);
            this.btn_criarpartida.Name = "btn_criarpartida";
            this.btn_criarpartida.Size = new System.Drawing.Size(199, 73);
            this.btn_criarpartida.TabIndex = 1;
            this.btn_criarpartida.Text = "Criar nova partida";
            this.btn_criarpartida.UseVisualStyleBackColor = false;
            this.btn_criarpartida.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_entrarpartida
            // 
            this.btn_entrarpartida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_entrarpartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrarpartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrarpartida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_entrarpartida.Location = new System.Drawing.Point(337, 473);
            this.btn_entrarpartida.Name = "btn_entrarpartida";
            this.btn_entrarpartida.Size = new System.Drawing.Size(199, 73);
            this.btn_entrarpartida.TabIndex = 2;
            this.btn_entrarpartida.Text = "Entrar na partida";
            this.btn_entrarpartida.UseVisualStyleBackColor = false;
            this.btn_entrarpartida.Click += new System.EventHandler(this.btn_entrarpartida_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sair.Location = new System.Drawing.Point(607, 473);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(199, 73);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair do jogo";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_partidas
            // 
            this.dgv_partidas.AllowUserToAddRows = false;
            this.dgv_partidas.AllowUserToDeleteRows = false;
            this.dgv_partidas.AllowUserToResizeColumns = false;
            this.dgv_partidas.AllowUserToResizeRows = false;
            this.dgv_partidas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_partidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_partidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_partidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_partidas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_partidas.Location = new System.Drawing.Point(176, 97);
            this.dgv_partidas.MultiSelect = false;
            this.dgv_partidas.Name = "dgv_partidas";
            this.dgv_partidas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_partidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_partidas.RowHeadersVisible = false;
            this.dgv_partidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_partidas.Size = new System.Drawing.Size(551, 353);
            this.dgv_partidas.TabIndex = 4;
            // 
            // lbl_versao
            // 
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versao.Location = new System.Drawing.Point(821, 566);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(41, 13);
            this.lbl_versao.TabIndex = 6;
            this.lbl_versao.Text = "label2";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_atualizar.Location = new System.Drawing.Point(733, 97);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(129, 37);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 588);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.dgv_partidas);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrarpartida);
            this.Controls.Add(this.btn_criarpartida);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_criarpartida;
        private System.Windows.Forms.Button btn_entrarpartida;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridView dgv_partidas;
        private System.Windows.Forms.Label lbl_versao;
        private System.Windows.Forms.Button btn_atualizar;
    }
}