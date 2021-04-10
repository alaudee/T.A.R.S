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
            lbl_statuspart.Text = "Partida iniciada";
            lbl_statuspart.ForeColor = System.Drawing.Color.Green;
        }

        private void lbl_rolarDado_Click(object sender, EventArgs e)
        {

            string dados = Jogo.RolarDados(IDJogador, SenhaJogador);
            dados = dados.Replace("\r\n", "");
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
                d.PopularImagens(d.ValorDado);
                ListaDados.Add(d);
            }
            pcb_dado1.Image = ListaDados[0].FaceDado;
            pcb_dado2.Image = ListaDados[1].FaceDado;
            pcb_dado3.Image = ListaDados[2].FaceDado;
            pcb_dado4.Image = ListaDados[3].FaceDado;

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

    }
}
