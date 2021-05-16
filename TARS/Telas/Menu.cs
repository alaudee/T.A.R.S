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
            //Mostra a versão da DLL atual
            lbl_versao.Text = "Versão: " + Jogo.Versao;

            // Popula a dataGridView com as partidas disponíveis
            dgv_partidas.DataSource = Partida.listarPartidas();
            dgv_partidas.Columns[4].Visible = false;
            dgv_partidas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cria uma partida
            CriarPartida criarpartida = new CriarPartida(dgv_partidas);
            criarpartida.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Fecha o programa
            Application.Exit();
        }

        private void btn_entrarpartida_Click(object sender, EventArgs e)
        {
            //Entrar em uma partida
            Partida p = (Partida)dgv_partidas.SelectedRows[0].DataBoundItem;
            EntrarPartida entrarpartida = new EntrarPartida(p.id);
            entrarpartida.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            //Atualiza as partidas
            dgv_partidas.DataSource = Partida.listarPartidas();
            dgv_partidas.Columns[4].Visible = false;
            dgv_partidas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
