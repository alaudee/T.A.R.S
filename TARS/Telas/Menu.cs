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
using TARS.Telas;

namespace TARS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            lbl_versao.Text = "Versão: " + Jogo.Versao;

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
            dgv_partidas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarPartida criarpartida = new CriarPartida(dgv_partidas);
            criarpartida.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entrarpartida_Click(object sender, EventArgs e)
        {
            Partida p = (Partida)dgv_partidas.SelectedRows[0].DataBoundItem;
            EntrarPartida entrarpartida = new EntrarPartida(p.id);
            entrarpartida.ShowDialog();
        }

        private void lbl_versão_Click(object sender, EventArgs e)
        {

        }
    }
}
