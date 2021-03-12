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
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            lbl_versao.Text = "Versão: " + Jogo.Versao;
        }

        private void btn_Listarpartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            List<Partida> partidas = new List<Partida>();
            for (int i = 0; i < linha.Length - 1; i++)
            {
                Partida p = new Partida();
                string[] itens = linha[i].Split(',');
                p.id = Convert.ToInt32(itens[0]);
                p.nome = itens[1];
                p.data = itens[2];
                p.status = itens[3];
                partidas.Add(p);
            }
            dgv_partidas.DataSource = partidas;
            dgv_partidas.Columns[4].Visible = false;

        }

        private void lsb_partidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_listarjogadores_Click(object sender, EventArgs e)
        {
            Partida p = (Partida)dgv_partidas.SelectedRows[0].DataBoundItem;
            txt_jogadores.Text = Jogo.ListarJogadores(p.id);
            
            
        }

        private void btn_entrarpartida_Click(object sender, EventArgs e)
        {
            string nomejogador = txt_nomejogador.Text;
            string senha = txt_senha.Text;
            Partida p = (Partida)dgv_partidas.SelectedRows[0].DataBoundItem;
            Jogo.EntrarPartida(p.id, nomejogador, senha);
            txt_nomejogador.Text = "";
            txt_senha.Text = "";
            MessageBox.Show("Você entrou na partida: " + p.nome);

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomepartida = txt_nomepartida.Text;
            string senhapartida = txt_senhapartida.Text;
            Jogo.CriarPartida(nomepartida, senhapartida);
            txt_nomepartida.Text = "";
            txt_senhapartida.Text = "";
            MessageBox.Show("Você criou uma partida!");
        }

        private void lbl_versao_Click(object sender, EventArgs e)
        {
  

        }
    }
}
