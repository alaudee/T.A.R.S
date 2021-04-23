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
        public Jogador JogadorAtivo { get; set; }
        public  string Infojogador { get; set; }
        public int IdPartida { get; set; }

        char[] valordado = new char[4];
        char[] numerodado = new char[4];
        string dadoescolha;

        string op_dado;

        DataTable dtb_tabuleiro;

        public Tabuleiro(string infojogador, int idpartida) //coloquei mais um parametro no construtor para pegar o idpartida
        {
            InitializeComponent();
            JogadorAtivo = new Jogador();
            this.Infojogador = infojogador;
            this.IdPartida = idpartida;

            rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);

            btn_rolarDado.Enabled = false;
            btn_verificarvez.Enabled = false;

            gb_jogadas.Visible = false;
            btn_mover.Visible = false;

            string[] linha = Infojogador.Split(',');
            JogadorAtivo.Id = Convert.ToInt32(linha[0]);
            JogadorAtivo.Senha = linha[1];
            JogadorAtivo.corjogador = linha[2];
            JogadorAtivo.corjogador = JogadorAtivo.corjogador.Replace("\r\n","");

            lbl_idjogador.Text = "Id: "+ JogadorAtivo.Id;
            lbl_senhajogador.Text = "Senha: " + JogadorAtivo.Senha;
            lbl_corjogador.Text = "Cor: " + JogadorAtivo.corjogador;

            dtb_tabuleiro = TabuleiroP.CriarDataTable();
        }


        public void desenharTabuleiro(string[] trilhas, string[] posicoes, string[] tipo, Jogador jogadorativo)
        {
            int numerojogador = Jogador.VerificarNumeroJogador(jogadorativo);
            for (int i = 0; i < trilhas.Length; i++)
            {
                if (trilhas[i] == "2")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            if(tipo[i]== "A")
                            {
                                pcb_A21.BackColor = Color.Black;
                                pcb_A21.Visible = true;
                            }
                            else
                            {
                                if (numerojogador == 1)
                                {
                                    pcb_j121.BackColor = Color.Red;
                                    pcb_j121.Visible = true;
                                }
                                else if (numerojogador == 2)
                                {
                                    pcb_j221.BackColor = Color.Blue;
                                    pcb_j221.Visible = true;
                                }
                                else if (numerojogador == 3)
                                {
                                    pcb_j321.BackColor = Color.Green;
                                    pcb_j321.Visible = true;
                                }
                                else
                                {
                                    pcb_j421.BackColor = Color.Yellow;
                                    pcb_j421.Visible = true;
                                }
                            }
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_j121.BackColor = Color.Red;
                            pcb_j121.Visible = true;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "3")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A31.BackColor = Color.Black;
                            pcb_A31.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "4")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A41.BackColor = Color.Black;
                            pcb_A41.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "5")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A51.BackColor = Color.Black;
                            pcb_A51.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "6")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A61.BackColor = Color.Black;
                            pcb_A61.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "7")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            if (tipo[i] == "A")
                            {
                                pcb_A71.BackColor = Color.Black;
                                pcb_A71.Visible = true;
                            }
                            else
                            {
                                if (numerojogador == 1)
                                {
                                    pcb_j171.BackColor = Color.Red;
                                    pcb_j171.Visible = true;
                                }
                                else if (numerojogador == 2)
                                {
                                    pcb_j271.BackColor = Color.Blue;
                                    pcb_j271.Visible = true;
                                }
                                else if (numerojogador == 3)
                                {
                                    pcb_j371.BackColor = Color.Green;
                                    pcb_j371.Visible = true;
                                }
                                else
                                {
                                    pcb_j471.BackColor = Color.Yellow;
                                    pcb_j471.Visible = true;
                                }
                                pcb_A71.Visible = false;
                            }


                        }
                        else if (posicoes[j] == "2")
                        {
                            
                        }
                        else if (posicoes[j] == "3")
                        {
                            
                        }
                        else if (posicoes[j] == "4")
                        {

                        }
                        else if (posicoes[j] == "5")
                        {

                        }
                        else if (posicoes[j] == "6")
                        {

                        }
                        else if (posicoes[j] == "7")
                        {

                        }
                        else if (posicoes[j] == "8")
                        {

                        }
                        else if (posicoes[j] == "9")
                        {

                        }
                        else if (posicoes[j] == "10")
                        {

                        }
                        else if (posicoes[j] == "11")
                        {

                        }
                        else if (posicoes[j] == "12")
                        {

                        }
                        else
                        {

                        }
                }

                if (trilhas[i] == "8")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A81.BackColor = Color.Black;
                            pcb_A81.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "9")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A91.BackColor = Color.Black;
                            pcb_A91.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "10")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A101.BackColor = Color.Black;
                            pcb_A101.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "11")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A111.BackColor = Color.Black;
                            pcb_A111.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }

                if (trilhas[i] == "12")
                {
                    for (int j = 0; j < posicoes.Length; j++)
                        if (posicoes[j] == "1")
                        {
                            pcb_A121.BackColor = Color.Black;
                            pcb_A121.Visible = true;
                        }
                        else if (posicoes[j] == "2")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                        else if (posicoes[j] == "3")
                        {
                            pcb_A21.BackColor = Color.Black;
                        }
                }
            }

        }

        public void valorTabuleiro(DataTable dtb_tabuleiro)
        {
            string[] trilhas = new string[dtb_tabuleiro.Rows.Count];
            string[] posicoes = new string[dtb_tabuleiro.Rows.Count];
            string[] tipo = new string[dtb_tabuleiro.Rows.Count];
            for (int i = 0; i < dtb_tabuleiro.Rows.Count; i++)
            {
                trilhas[i] = dtb_tabuleiro.Rows[i]["trilha"].ToString(); //Selecionando os rows i na coluna trilha
                posicoes[i] = dtb_tabuleiro.Rows[i]["posicao"].ToString();
                tipo[i] = dtb_tabuleiro.Rows[i]["tipo"].ToString();
            }
            /*
            // para pegar as cores de todos os jogadores
            List<Jogador> jogadores = new List<Jogador>();
            string retorno = Jogo.ListarJogadores(IdPartida);
            retorno = retorno.Replace("\r", " ");
            string[] linha = retorno.Split('\n');
            for (int i = 0; i < linha.Length - 1; i++)
            {
                Jogador j = new Jogador();
                string[] itens = linha[i].Split(',');
                //j.Id = Convert.ToInt32(itens[0]);
                //j.Nomejogador = itens[1];
                //j.corjogador = itens[2];
                coresJogadores[i] = itens[2];
                jogadores.Add(j);
            }
            */ 
            desenharTabuleiro(trilhas, posicoes, tipo ,JogadorAtivo);
        }

        private void btn_iniciarpartida_Click(object sender, EventArgs e) 
        {
            string retorno = Jogo.IniciarPartida(JogadorAtivo.Id, JogadorAtivo.Senha);
            MessageBox.Show("Iniciada a partida");
            lbl_statuspart.Text = "Partida iniciada";
            lbl_statuspart.ForeColor = System.Drawing.Color.Green;
            btn_rolarDado.Enabled = true;
            btn_verificarvez.Enabled = true;
            
            
            rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
        }

        private void lbl_rolarDado_Click(object sender, EventArgs e)
        {
            try 
            {
                string dados = Jogo.RolarDados(JogadorAtivo.Id, JogadorAtivo.Senha);
                dados = dados.Replace("\r\n", "");
                int contador = 0;
                int contvalor = 0;

                for (int i = 0; i < dados.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        numerodado[contador] = dados[i];
                        contador++;
                    }
                    else
                    {
                        valordado[contvalor] = dados[i];
                        contvalor++;
                    }

                }

                List<Dado> ListaDados = new List<Dado>();


                for (int i = 0; i < 4; i++)
                {
                    Dado d = new Dado();
                    d.NumeroDado = numerodado[i];
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
                btn_parar.Visible = true;
                rdb_jogada1.Text = trilhas[0] + " e " + trilhas[5];
                rdb_jogada2.Text = trilhas[1] + " e " + trilhas[4];
                rdb_jogada3.Text = trilhas[2] + " e " + trilhas[3];
                btn_mover.Enabled = true;

                rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }

        }

        private void bnt_verificarvez_Click(object sender, EventArgs e)
        {
            string teste = Jogo.VerificarVez(IdPartida);
            string[] linha = teste.Split(',');
            string jogadorvez = linha[1];
            int comparar = Convert.ToInt32(jogadorvez);

            if (comparar == JogadorAtivo.Id)
                MessageBox.Show("É a sua vez de jogar!", jogadorvez);
            else
                MessageBox.Show("Não é a sua vez de jogar!", jogadorvez);
        }

        private void bnt_exibirTabuleiro_Click(object sender, EventArgs e)
        {
            string tabuleiro = Jogo.ExibirTabuleiro(IdPartida);
            dtb_tabuleiro = TabuleiroP.LimparExibirTabuleiro(tabuleiro,dtb_tabuleiro);
            dgv_teste.DataSource = dtb_tabuleiro;
            rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
            valorTabuleiro(dtb_tabuleiro);

        }

        private void rdb_jogada1_CheckedChanged(object sender, EventArgs e)
        {
            op_dado = rdb_jogada1.Text;

            dadoescolha = "";
            dadoescolha = numerodado[0].ToString();
            dadoescolha += numerodado[1].ToString();
            dadoescolha += numerodado[2].ToString();
            dadoescolha += numerodado[3].ToString();
        }

        private void rdb_jogada2_CheckedChanged(object sender, EventArgs e)
        {
            op_dado = rdb_jogada2.Text;
            dadoescolha = "";
            dadoescolha = numerodado[0].ToString();
            dadoescolha += numerodado[2].ToString();
            dadoescolha += numerodado[1].ToString();
            dadoescolha += numerodado[3].ToString();
        }

        private void rdb_jogada3_CheckedChanged(object sender, EventArgs e)
        {
            op_dado = rdb_jogada3.Text;
            dadoescolha = "";
            dadoescolha = numerodado[0].ToString();
            dadoescolha += numerodado[3].ToString();
            dadoescolha += numerodado[1].ToString();
            dadoescolha += numerodado[2].ToString();
        }

        private void btn_mover_Click(object sender, EventArgs e)
        {
            Jogo.Mover(JogadorAtivo.Id, JogadorAtivo.Senha, dadoescolha, Dado.tratarTextoEscolhaRadio(op_dado));
            string retornotab = Jogo.ExibirTabuleiro(IdPartida);
            dtb_tabuleiro = TabuleiroP.AdicionarMovimentos(retornotab, dtb_tabuleiro);
            dgv_teste.DataSource = dtb_tabuleiro;
            btn_mover.Enabled = false;
            valorTabuleiro(dtb_tabuleiro);
            rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{dadoescolha} e {Dado.tratarTextoEscolhaRadio(op_dado)}");
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            string parar = Jogo.Parar(JogadorAtivo.Id, JogadorAtivo.Senha);
            rtxt_historicoP.Text = Jogo.ExibirHistorico(IdPartida);
            string tabuleiro = Jogo.ExibirTabuleiro(IdPartida);
            dtb_tabuleiro = TabuleiroP.LimparExibirTabuleiro(tabuleiro, dtb_tabuleiro);
            valorTabuleiro(dtb_tabuleiro);
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox138_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox355_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void pcb_t81_Click(object sender, EventArgs e)
        {

        }
    }
}
