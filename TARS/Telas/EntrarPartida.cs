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

        List<Jogador> jogadores = new List<Jogador>();

        public EntrarPartida(int idpartida)
        {
            InitializeComponent();
            //Seta o id da partida escolha como global e lista os jogadores dentro dela
            this.idpartida = idpartida;
            jogadores = Jogador.listarJogadores(this.idpartida);


            //Popula a grid com os jogadores, ocultando a Senha[3] e o numerodojogador[4]
            dgv_jogadores.DataSource = jogadores;
            dgv_jogadores.Columns[3].Visible = false;
            dgv_jogadores.Columns[4].Visible = false;
            dgv_jogadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_senha.PasswordChar = '*';
        }
        private void btn_entrarpartida_Click(object sender, EventArgs e)
        {
            string nomejogador = txt_nomejogador.Text;
            string senha = txt_senha.Text;
            string validadorEntrarPartida = Jogo.EntrarPartida(idpartida, nomejogador, senha);

            if (validadorEntrarPartida.Contains("ERRO"))
            {
                MessageBox.Show(validadorEntrarPartida);
                txt_nomejogador.Text = "";
                txt_senha.Text = "";
            }
            else
            {
                txt_nomejogador.Text = "";
                txt_senha.Text = "";
                this.Hide();
                Tabuleiro tabuleiro = new Tabuleiro(validadorEntrarPartida, idpartida);
                DialogResult = DialogResult.OK;
                tabuleiro.ShowDialog();
                this.Show();
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
