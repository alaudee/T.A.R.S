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
    public partial class Tabuleiro : Form
    {
        public  string Infojogador { get; set; }
        public int IDJogador { get; set; }
        public string SenhaJogador { get; set; }
        public int IdPartida { get; set; }

        string nova;

        public Tabuleiro(string infojogador, int idpartida) //coloquei mais um parametro no construtor para pegar o idpartida
        {
            InitializeComponent();
            this.Infojogador = infojogador;
            this.IdPartida = idpartida;

            string[] linha = Infojogador.Split(',');
            string idjogador = linha[0];
            string senhajog = linha[1];
            string corjogador = linha[2];
            lbl_idjogador.Text = "Id: "+ idjogador;
            lbl_senhajogador.Text = "Senha: " + senhajog;
            lbl_corjogador.Text = "Cor: " + corjogador;
            IDJogador = Convert.ToInt32(idjogador);
            SenhaJogador = senhajog;

        }


        private void btn_iniciarpartida_Click(object sender, EventArgs e) 
        {
            string retorno = Jogo.IniciarPartida(IDJogador, SenhaJogador);
            MessageBox.Show("Iniciada a partida");
        }

        private void lbl_rolarDado_Click(object sender, EventArgs e)
        {
            string dados = Jogo.RolarDados(IDJogador, SenhaJogador);
            dados = dados.Replace("\r", "");
            dados = dados.Replace("\n", "");
            char[] dado = new char[4];
            char[] valordado = new char[4];
            int contador = 0;
            int contvalor = 0;

            for (int i = 0; i < dados.Length; i++)
            {
                if (i % 2 == 0)
                {
                    dado[contador] = dados[i];
                    contador++;
                }
                else
                {
                    valordado[contvalor] = dados[i];
                    contvalor++;
                }

            }

            List<Dado> ListaDados  = new List<Dado>();

            for (int i = 0; i < 4; i++)
            {
                Dado d = new Dado();
                d.NumeroDado = dado[i];
                d.ValorDado = valordado[i];
                ListaDados.Add(d);
            }
            dgv_dados.DataSource = ListaDados;
            dgv_dados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }

        private void bnt_verificarvez_Click(object sender, EventArgs e)
        {
            string teste = Jogo.VerificarVez(IdPartida);
            string[] linha = teste.Split(',');
            string jogadorvez = linha[1];
            int comparar = Convert.ToInt32(jogadorvez);

            if (comparar == IDJogador)
                MessageBox.Show("É a sua vez de jogar!", jogadorvez);
            else
                MessageBox.Show("Não é a sua vez de jogar!", jogadorvez);
        }

        private void bnt_exibirTabuleiro_Click(object sender, EventArgs e)
        {
            string tabuleiro = Jogo.ExibirTabuleiro(IdPartida);
            //label1.Text = tabuleiro;

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_dados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_dados.CurrentRow.Selected = true;
                txt_valorDado.Text = dgv_dados.Rows[e.RowIndex].Cells["ValorDado"].FormattedValue.ToString();
            }
        }

        private void btn_escolha_Click(object sender, EventArgs e)
        {
            nova += txt_valorDado.Text;
        }

        private void btn_valorDado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nova);
        }
    }
}
