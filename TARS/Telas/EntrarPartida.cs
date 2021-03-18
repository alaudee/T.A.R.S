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
            this.idpartida = idpartida;

            string retorno = Jogo.ListarJogadores(idpartida);
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            List<Jogadores> jogadores = new List<Jogadores>();
            for (int i = 0; i < linha.Length - 1; i++)
            {
                Jogadores j = new Jogadores();
                string[] itens = linha[i].Split(',');
                j.Id = Convert.ToInt32(itens[0]);
                j.Jogador = itens[1];
                j.corjogador = itens[2];
                jogadores.Add(j);
            }
            dgv_jogadores.DataSource = jogadores;
           
        }

        private void txt_jogadores_TextChanged(object sender, EventArgs e)
        {

        }

        public bool verificarJogador(int idpartida, string nomeJogador)
        {
            string retorno = Jogo.ListarJogadores(idpartida);
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            List<Jogadores> jogadores = new List<Jogadores>();
            //compara os jogadores já existentes com o "novo jogador"
            string[] comparar = new string[3];
            bool vai = true;

            Jogadores j = new Jogadores();
            for (int i = 0; i < linha.Length - 1; i++)
            {       
                string[] itens = linha[i].Split(',');
                j.Id = Convert.ToInt32(itens[0]);
                j.Jogador = itens[1];
                comparar[i] = j.Jogador;
                j.corjogador = itens[2];
                jogadores.Add(j);
            }

            for(int i = 0; i < 3; i++)
            {
                if(comparar[i] == nomeJogador)
                {
                    return false;
                }
            }

            return vai;
        }
        private void btn_entrarpartida_Click(object sender, EventArgs e)
        {

            string nomejogador = txt_nomejogador.Text;
            string senha = txt_senha.Text;
            bool ok = verificarJogador(idpartida, nomejogador);

            if (ok)
            {
                Jogo.EntrarPartida(idpartida, nomejogador, senha);
                txt_nomejogador.Text = "";
                txt_senha.Text = "";
                MessageBox.Show("Você entrou na partida");
                Tabuleiro tabuleiro = new Tabuleiro();
                Menu menu = new Menu();
                tabuleiro.Show();
                this.Close();
                menu.Close();
            }
            else
            {
                MessageBox.Show("Erro, jogador já existe!!");
            }
           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nomejogador_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
