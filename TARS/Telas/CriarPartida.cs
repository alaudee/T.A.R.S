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
        public CriarPartida()
        {
            InitializeComponent();
            txt_senhapartida.PasswordChar = '*';
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
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
