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
            this.idpartida = idpartida;

            string retorno = Jogo.ListarJogadores(idpartida);
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            for (int i = 0; i < linha.Length - 1; i++)
            {
                Jogador j = new Jogador();
                string[] itens = linha[i].Split(',');
                j.Id = Convert.ToInt32(itens[0]);
                j.Nomejogador = itens[1];
                j.corjogador = itens[2];
                jogadores.Add(j);
            }
            dgv_jogadores.DataSource = jogadores;
            dgv_jogadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            txt_senha.PasswordChar = '*';
        }

        

        private void txt_jogadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_entrarpartida_Click(object sender, EventArgs e)
        {
            string nomejogador = txt_nomejogador.Text;
            string senha = txt_senha.Text;
            string validadorEntrarPartida = Jogo.EntrarPartida(idpartida, nomejogador, senha);
            int linhas = dgv_jogadores.Rows.Count;

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
                Tabuleiro tabuleiro = new Tabuleiro(validadorEntrarPartida);
                Menu menu = new Menu();

                this.Close();
                tabuleiro.Show();
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_jogadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
