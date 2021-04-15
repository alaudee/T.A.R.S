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

        char[] valordado = new char[4];
        char[] numerodado = new char[4];
        string dadoescolha;
        
        public Tabuleiro(string infojogador, int idpartida) //coloquei mais um parametro no construtor para pegar o idpartida
        {
            InitializeComponent();
            this.Infojogador = infojogador;
            this.IdPartida = idpartida;

            btn_rolarDado.Enabled = false;
            btn_verificarvez.Enabled = false;

            gb_jogadas.Visible = false;
            btn_mover.Visible = false;

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
            btn_rolarDado.Enabled = true;
            btn_verificarvez.Enabled = true;

        }

        private void lbl_rolarDado_Click(object sender, EventArgs e)
        {
            
            string dados = Jogo.RolarDados(IDJogador, SenhaJogador);
            dados = dados.Replace("\r\n", "");
            int contador = 0;
            int contvalor = 0;

            char[] dado = new char[4];

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
                numerodado[i] = dado[i];
                d.ValorDado = valordado[i];
                d.PopularImagens(d.ValorDado);
                ListaDados.Add(d);
            }

            pcb_dado1.Image = ListaDados[0].FaceDado;
            pcb_dado2.Image = ListaDados[1].FaceDado;
            pcb_dado3.Image = ListaDados[2].FaceDado;
            pcb_dado4.Image = ListaDados[3].FaceDado;

            Dado de = new Dado();
            int[] trilhas = Dado.FormarDuplasSomaDados(valordado);
            gb_jogadas.Visible = true;
            btn_mover.Visible = true;
            //rdb_jogada1.Text = stringteste[0]; // trilhas [0] e[1] não pode ser a trilha 0 e 1, pois repete o mesmo dado
            //rdb_jogada2.Text = stringteste[1]; // trilhas [2] e[3]
            //rdb_jogada3.Text = stringteste[2]; // trilhas [4] e[5]
            rdb_jogada1.Text = trilhas[0] + " e " + trilhas[5];
            rdb_jogada2.Text = trilhas[1] + " e " + trilhas[4];
            rdb_jogada3.Text = trilhas[2] + " e " + trilhas[3];
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
            MessageBox.Show(tabuleiro);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_mover_Click(object sender, EventArgs e)
        {
            int[] trilhas = Dado.FormarDuplasSomaDados(valordado);
            //char dadoescolha;
            if (rdb_jogada1.Checked)
            {
                dadoescolha = "";
                dadoescolha = numerodado[0].ToString();
                dadoescolha += numerodado[1].ToString();
                dadoescolha += numerodado[2].ToString();
                dadoescolha += numerodado[3].ToString();
            }
            if (rdb_jogada2.Checked)
            {
                dadoescolha = "";
                dadoescolha = numerodado[0].ToString();
                dadoescolha += numerodado[2].ToString();
                dadoescolha += numerodado[1].ToString();
                dadoescolha += numerodado[3].ToString();
            }

            if (rdb_jogada3.Checked)
            {
                dadoescolha = "";
                dadoescolha = numerodado[0].ToString();
                dadoescolha += numerodado[3].ToString();
                dadoescolha += numerodado[1].ToString();
                dadoescolha += numerodado[2].ToString();
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(dadoescolha);
        }
    }
}
