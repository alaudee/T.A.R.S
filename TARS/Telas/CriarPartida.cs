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

namespace TARS.Telas
{
    public partial class CriarPartida : Form
    {
        DataGridView atualizar = new DataGridView();

        public CriarPartida(DataGridView partidas)
        {
            InitializeComponent();
            //Oculta a senha
            txt_senhapartida.PasswordChar = '*';
            //Recebe a datagridview para atualizar quando sair da tela 
            this.atualizar = partidas;
        }

        private void btn_criarpartida_Click(object sender, EventArgs e)
        {
            string nomepartida = txt_nomepartida.Text;
            string senhapartida = txt_senhapartida.Text;
            string validadorCriarPartida = Jogo.CriarPartida(nomepartida, senhapartida);
            if (validadorCriarPartida.Contains("ERRO"))
            {
                txt_nomepartida.Text = "";
                txt_senhapartida.Text = "";
                MessageBox.Show(validadorCriarPartida);
            }
           
            else
            {
                MessageBox.Show("Você criou uma partida!");
                this.Close();
                atualizar.DataSource = Partida.listarPartidas();
                atualizar.Columns[4].Visible = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
