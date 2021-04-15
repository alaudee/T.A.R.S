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
            txt_senhapartida.PasswordChar = '*';
            this.atualizar = partidas;
        }

        private void btn_criarpartida_Click(object sender, EventArgs e)
        {
            string nomepartida = txt_nomepartida.Text;
            string senhapartida = txt_senhapartida.Text;
            string validadorCriarPartida = Jogo.CriarPartida(nomepartida, senhapartida);
            if (validadorCriarPartida[0] == 'E')
            {
                txt_nomepartida.Text = "";
                txt_senhapartida.Text = "";
                MessageBox.Show(validadorCriarPartida);
            }
           
            else
            {
                MessageBox.Show("Você criou uma partida!");
                this.Close();
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
                atualizar.DataSource = partidas;
                atualizar.Columns[4].Visible = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
