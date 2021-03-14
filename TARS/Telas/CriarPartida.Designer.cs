
namespace TARS.Telas
{
    partial class CriarPartida
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
            this.txt_senhapartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nomepartida = new System.Windows.Forms.TextBox();
            this.btn_criarpartida = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_senhapartida
            // 
            this.txt_senhapartida.Location = new System.Drawing.Point(15, 100);
            this.txt_senhapartida.Name = "txt_senhapartida";
            this.txt_senhapartida.Size = new System.Drawing.Size(229, 20);
            this.txt_senhapartida.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Digite a senha da partida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Digite o nome da partida:";
            // 
            // txt_nomepartida
            // 
            this.txt_nomepartida.Location = new System.Drawing.Point(12, 45);
            this.txt_nomepartida.Name = "txt_nomepartida";
            this.txt_nomepartida.Size = new System.Drawing.Size(232, 20);
            this.txt_nomepartida.TabIndex = 17;
            // 
            // btn_criarpartida
            // 
            this.btn_criarpartida.Location = new System.Drawing.Point(250, 29);
            this.btn_criarpartida.Name = "btn_criarpartida";
            this.btn_criarpartida.Size = new System.Drawing.Size(101, 70);
            this.btn_criarpartida.TabIndex = 16;
            this.btn_criarpartida.Text = "Criar Partida";
            this.btn_criarpartida.UseVisualStyleBackColor = true;
            this.btn_criarpartida.Click += new System.EventHandler(this.btn_criarpartida_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(250, 105);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 23);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CriarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 147);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_senhapartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nomepartida);
            this.Controls.Add(this.btn_criarpartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CriarPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriarPartida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_senhapartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nomepartida;
        private System.Windows.Forms.Button btn_criarpartida;
        private System.Windows.Forms.Button btn_cancelar;
    }
}