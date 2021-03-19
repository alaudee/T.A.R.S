using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TARS.Telas;
using CantStopServer;

namespace TARS.Telas
{
    public partial class EntrarPartida : Form
    {
        public int idpartida { get; set; }

        public EntrarPartida(int idpartida)
        {
            InitializeComponent();
            txt_jogadores.Text = Jogo.ListarJogadores(idpartida);
            this.idpartida = idpartida;
        }

        private void txt_jogadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_entrarpartida_Click(object sender, EventArgs e)
        {
            string nomejogador = txt_nomejogador.Text;
            string senha = txt_senha.Text;
            string validadorEntrarPartida = Jogo.EntrarPartida(idpartida, nomejogador, senha);

            if (validadorEntrarPartida[0] == 'E')
            {
                MessageBox.Show(validadorEntrarPartida);
                txt_nomejogador.Text = "";
                txt_senha.Text = "";
            }
            else
            {
                txt_nomejogador.Text = "";
                txt_senha.Text = "";
                MessageBox.Show("Você entrou na partida");
                Tabuleiro tabuleiro = new Tabuleiro();
                Menu menu = new Menu();
                this.Close();
                tabuleiro.Show();
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
