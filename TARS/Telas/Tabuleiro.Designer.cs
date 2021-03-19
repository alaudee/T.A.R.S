
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
            this.SuspendLayout();
            // 
            // btn_iniciarpartida
            // 
            this.btn_iniciarpartida.Location = new System.Drawing.Point(12, 12);
            this.btn_iniciarpartida.Name = "btn_iniciarpartida";
            this.btn_iniciarpartida.Size = new System.Drawing.Size(119, 58);
            this.btn_iniciarpartida.TabIndex = 0;
            this.btn_iniciarpartida.Text = "Iniciar Partida";
            this.btn_iniciarpartida.UseVisualStyleBackColor = true;
            this.btn_iniciarpartida.Click += new System.EventHandler(this.btn_iniciarpartida_Click);
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 604);
            this.Controls.Add(this.btn_iniciarpartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciarpartida;
    }
}