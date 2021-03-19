using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace TARS
{
    public partial class Tabuleiro : Form
    {
        public string Infojogador { get; set; }
     
        public Tabuleiro(string infojogador)
        {
            InitializeComponent();
            this.Infojogador = infojogador;

            string[] linha = Infojogador.Split(',');
            string idjogador = linha[0];
            string senhajog = linha[1];
            string corjogador = linha[2];
            lbl_idjogador.Text = "Id: "+ idjogador;
            lbl_senhajogador.Text = "Senha: " + senhajog;
            lbl_corjogador.Text = "Cor: " + corjogador;

        }

        private void btn_iniciarpartida_Click(object sender, EventArgs e) 
        {
            string[] linha = Infojogador.Split(',');
            string senhajog = linha[1];
            int idjogador = Convert.ToInt32(linha[0]);
            string retorno = Jogo.IniciarPartida(idjogador,senhajog);
            MessageBox.Show("Iniciada a partida");
        }
    }
}
